using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using TabletopArmyCreator.Attributes;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace TabletopArmyCreator.DatabaseRequests
{
    public class SqlDatasbaseInterractionService : ISqlDatasbaseInterractionService
    {
        public SqlConnection GetSqlConnection()
        {
            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnectionString"].ConnectionString);
            return sqlConn;
        }

        //public SqlConnection GetSqlConnection(IRequest request)
        //{
        //    if (request == null) throw new ArgumentNullException(nameof(request));

        //    var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnectionString"].ConnectionString);
        //    return sqlConn;
        //}


        public async Task<DataTable> SendRequestAsync(IRequest request, SqlConnection sqlConn)
        {
            var requestDetails = (StoredProcedure)request.GetType().GetCustomAttribute(typeof(StoredProcedure));
            if(requestDetails is null)
            {
                throw new Exception("StoredProcedure Attribute not present on request");
            }

            var resultSet = new DataTable();

            await Task.Run(
                       () =>
                       {
                           using (var sqlCommand = new SqlCommand(requestDetails.StoredProcedureName, sqlConn))
                           {
                               var parameters = request.GetType().GetProperties().Where(x => x.GetCustomAttributes()
                                                           .Any(y => y.GetType() == typeof(StoredProcedureParameter)));

                               foreach (var parameter in parameters)
                               {
                                   var attributeData = parameter.GetCustomAttribute<StoredProcedureParameter>();
                                   sqlCommand.Parameters.Add(new SqlParameter()
                                                                   {
                                                                       ParameterName = attributeData.ParameterName,
                                                                       Value = parameter.GetValue(request),
                                                                       SqlDbType = attributeData.ParamterType
                                                                   }
                                   );
                               }

                               sqlCommand.CommandTimeout = requestDetails.Timeout;
                               sqlCommand.CommandType = CommandType.StoredProcedure;

                               try
                               {
                                   using (var da = new SqlDataAdapter(sqlCommand))
                                   {
                                       da.Fill(resultSet);
                                   }
                               }
                               catch (SqlException sqlEx)
                               {

                               }
                               finally
                               {
                                   sqlCommand.Connection.Dispose();
                               }
                           }
                       });

                return resultSet;
        }
    }
}
