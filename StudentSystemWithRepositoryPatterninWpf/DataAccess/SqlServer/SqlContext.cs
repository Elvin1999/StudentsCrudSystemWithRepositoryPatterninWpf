using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.DataAccess.SqlServer
{
    class SqlContext
    {
        public string ConnectionString { get; set; }
        SqlUnitOfWork db;

        public SqlContext(SqlUnitOfWork db)
        {
            this.db = db;
            ConnectionString = db.ConnectionString;
        }
        public void AddCommandToTransaction(SqlCommand cmd)
        {
            db.EnqueueCommand(cmd);
        }
    }
}
