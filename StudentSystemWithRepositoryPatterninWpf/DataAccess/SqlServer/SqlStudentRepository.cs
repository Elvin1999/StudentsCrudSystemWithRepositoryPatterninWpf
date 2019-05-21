using StudentSystemWithRepositoryPatterninWpf.Domain.Abstraction;
using StudentSystemWithRepositoryPatterninWpf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.DataAccess.SqlServer
{
    class SqlStudentRepository : IStudentRepository
    {
        SqlContext db;
        public SqlStudentRepository(SqlContext db)
        {
            this.db = db;
        }
        /* public List<Product> GetProducts()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string cmdText = "select * from Products";
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                   SqlDataReader reader =  cmd.ExecuteReader();

                    List<Product> products = new List<Product>();
                    while(reader.Read())
                    {
                        Product product = new Product();

                        //product.Id = reader.GetInt32(0);
                        //product.Name = reader.GetString(1);
                        //product.Barcode = reader.GetString(2);
                        //product.Price = reader.GetDecimal(3);

                        //product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        //product.Name = reader.GetString(reader.GetOrdinal("Name"));
                        //product.Barcode = reader.GetString(reader.GetOrdinal("Barcode"));
                        //product.Price = reader.GetDecimal(reader.GetOrdinal("Price"));


                        //product.Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? null : (decimal?) reader.GetDecimal(reader.GetOrdinal("Price"));

                        //product.Id = Convert.ToInt32(reader[0]);
                        //product.Name = Convert.ToString(reader[1]);
                        //product.Barcode = Convert.ToString(reader[2]);
                        //product.Price = Convert.ToDecimal(reader[3]);

                        product.Id = Convert.ToInt32(reader[nameof(Product.Id)]);
                        product.Name = Convert.ToString(reader[nameof(Product.Name)]);
                        product.Barcode = Convert.ToString(reader[nameof(Product.Barcode)]);
                        product.Price = Convert.ToDecimal(reader[nameof(Product.Price)]);

                        products.Add(product);
                    }
                    return products;

                }
            }
        }

        public int AddProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string cmdText = $"Insert into Products output inserted.Id values(@Name, @Barcode, @Price)";
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    //cmd.ExecuteNonQuery();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }*/
        public void AddData(Student data)
        {
            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    db.AddCommandToTransaction(cmd);
                }
            }
        }

        public void DeleteData(Student data)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Student GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Student data)
        {
            throw new NotImplementedException();
        }
    }
}
