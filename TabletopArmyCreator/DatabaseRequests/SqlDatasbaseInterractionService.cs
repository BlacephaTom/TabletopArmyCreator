using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TabletopArmyCreator.BaseClasses;
using System.Reflection;
using System.Linq;
using TabletopArmyCreator.Attributes;

namespace TabletopArmyCreator.DatabaseRequests
{
    public class SqlDatasbaseInterractionService : ISqlDatasbaseInterractionService
    {
        public static void GetSqlConnection()
        {

        }

        public static void SendRequestAsync<IRequest>(IRequest request, string sqlConnection)
        {

            using (var sqlCon = new SqlConnection(sqlConnection))
            using (var sqlCommand = new SqlCommand())
            {
                var properties = typeof(IRequest).GetProperties();

                foreach(var property in properties)
                {
                    if (!property.GetCustomAttributes().Any(x => x.GetType() == typeof(StoredProcedureParameter)))
                        continue;

                }

                sqlCommand.CommandText = ((StoredProcedure)Attribute.GetCustomAttribute(typeof(IRequest), typeof(StoredProcedure))).StoredProcedureName;
            }
        }
    }
}
