using System;
using System.Data;
using System.Data.SqlClient;

namespace Final_Project_Pemrograman_Lanjut.model
{
    public class ModelTemplate
    {
        private static SqlConnection _conn;
        private SqlCommand _command;
        private bool _result;

        private static SqlConnection GetConnection()
        {
            _conn = new SqlConnection();
            _conn.ConnectionString = @"Data Source = LAPTOP-28QIKURK\SQLEXPRESS;" +
                                     "Initial Catalog = ternak;" +
                                     "Integrated Security = True";
            return _conn;
        }

        public ModelTemplate()
        {
            GetConnection();
        }

        public DataSet SelectData(string table, string query)
        {
            var ds = new DataSet();

            try
            {
                _conn.Open();
                _command = new SqlCommand();
                _command.Connection = _conn;
                _command.CommandType = CommandType.Text;
                _command.CommandText = query;
                var sda = new SqlDataAdapter(_command);
                sda.Fill(ds, table);
            }
            catch (SqlException)
            {
                ds = null;
            }

            _conn.Close();
            return ds;
        }

        public DataSet Select(string table, string condition)
        {
            var ds = new DataSet();

            try
            {
                _conn.Open();
                _command = new SqlCommand();
                _command.Connection = _conn;
                _command.CommandType = CommandType.Text;

                if (condition == null)
                {
                    _command.CommandText = "SELECT * FROM " + table;
                }
                else
                {
                    _command.CommandText = "SELECT * FROM " + table + " WHERE " + condition;
                }

                var sda = new SqlDataAdapter(_command);
                sda.Fill(ds, table);
            }

            catch (SqlException)
            {
                ds = null;
            }

            _conn.Close();
            return ds;
        }

        public bool Insert(string table, string data)
        {
            _result = false;

            try
            {
                var query = "INSERT INTO " + table + " VALUES (" + data + ")";
                _conn.Open();
                _command = new SqlCommand();
                _command.Connection = _conn;
                _command.CommandText = query;
                _command.ExecuteNonQuery();
                _result = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                _result = false;
            }

            _conn.Close();
            return _result;
        }

        public bool Update(string table, string data, string condition)
        {
            _result = false;

            try
            {
                var query = "UPADETE " + table + " SET " + data + " WHERE " + condition;
                _conn.Open();
                _command = new SqlCommand();
                _command.Connection = _conn;
                _command.CommandText = query;
                _command.ExecuteNonQuery();
                _result = true;
            }
            catch (SqlException)
            {
                _result = false;
            }

            _conn.Close();
            return _result;
        }

        public bool Delete(string table, string condition)
        {
            _result = false;

            try
            {
                var query = "DELETE FROM " + table + " WHERE " + condition;
                _conn.Open();
                _command = new SqlCommand();
                _command.Connection = _conn;
                _command.CommandText = query;
                _command.ExecuteNonQuery();
                _result = true;
            }
            catch (SqlException)
            {
                _result = false;
            }

            _conn.Close();
            return _result;
        }

        // public void CheckConn()
        // {
        //     GetConnection();
        //     try
        //     {
        //         _conn.Open();
        //         MessageBox.Show("Connected");
        //     }
        //     catch (Exception e)
        //     {
        //         MessageBox.Show("Not Connected " + e);
        //     }LUIwU
        // }
    }
}