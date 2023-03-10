using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace TabletopArmyCreator.DatabaseRequests
{
    public interface ISqlDatasbaseInterractionService
    {
        Task<DataTable> SendRequestAsync(IRequest request, SqlConnection sqlConn);

        //SqlConnection GetSqlConnection(IRequest request);

        SqlConnection GetSqlConnection();
    }
}
