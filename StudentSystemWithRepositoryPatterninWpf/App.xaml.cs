using StudentSystemWithRepositoryPatterninWpf.DataAccess.SqlServer;
using StudentSystemWithRepositoryPatterninWpf.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StudentSystemWithRepositoryPatterninWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork DB;
        public App()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder() {
                IntegratedSecurity = false,
                UserID="admin",Password="admin",DataSource= "STHQ0116-06",
                InitialCatalog= "StudentDb"
            };

            DB = new SqlUnitOfWork(stringBuilder.ConnectionString);
        }
    }
}
