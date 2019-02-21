using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AeroORMFramework;
using DataLib.Models;

namespace DataLib
{
    internal class Database
    {
        #region Properties
        private Connector Connector { get; }
        #endregion

        #region Constrcutors 
        public Database(string connectionsString) =>
            Connector = new Connector(connectionsString);
        public Database(SqlConnection connection) =>
            Connector = new Connector(connection);
        #endregion

        public List<GoodInfo> GetAllGoods()
        {
            return Connector.GetAllRecords<GoodInfo>();
        }

    }
}
