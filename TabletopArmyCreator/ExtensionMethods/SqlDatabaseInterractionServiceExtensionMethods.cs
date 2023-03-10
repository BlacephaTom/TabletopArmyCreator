using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using TabletopArmyCreator.Attributes;
using TabletopArmyCreator.DatabaseRequests;

using System.Data.SqlClient;

namespace TabletopArmyCreator.ExtensionMethods// System.Data.SqlClient
{
    public static class SqlDatabaseInterractionServiceExtensionMethods
    {
        public static void HandleResponse(this DbConnection conn)
        {

        }

        //public static async void SendRequestAsync<IRequest>(this TabletopArmyCreator.DatabaseRequests.ISqlDatasbaseInterractionService conn, IRequest request, SqlConnection sqlConn)
        //{
        //    // check StoredProcedure is not null

        //    var requestDetails = (StoredProcedure)request.GetType().GetCustomAttribute(typeof(StoredProcedure));

        //    using (var sqlCommand = new SqlCommand(
        //                                    requestDetails.StoredProcedureName,
        //                                    sqlConn)
        //            )
        //    {
        //        var parameters = request.GetType().GetProperties().Where(x => x.GetCustomAttributes()
        //                                    .Any(y => y.GetType() == typeof(StoredProcedureParameter)));

        //        foreach (var parameter in parameters)
        //        {
        //            var attributeData = parameter.GetCustomAttribute<StoredProcedureParameter>();
        //            sqlCommand.Parameters.Add(new SqlParameter()
        //            {
        //                ParameterName = parameter.Name,
        //                Value = parameter.GetValue(request),
        //                SqlDbType = attributeData.ParamterType
        //            }
        //            );
        //        }

        //        try
        //        {
        //            sqlCommand.CommandTimeout = requestDetails.Timeout;
        //            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //            sqlCommand.Connection.Open();
        //            await sqlCommand.ExecuteNonQueryAsync();
        //        }
        //        catch (SqlException sqlEx)
        //        {

        //        }
        //        finally
        //        {
        //            sqlCommand.Connection.Dispose();
        //        }
        //    }
        //}
    }


}
