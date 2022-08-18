using ADOWebApplication.DataRepo;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
//using System.Data.SqlClient;

namespace ADOWebApplication.ADORepositories
{
    public class DbConnectMySql
    {
        MySqlConnection _mySqlCnn;
        public DbConnectMySql(string dbName)
        {
            if (dbName.Equals("MizzaItemDbConnect"))
                _mySqlCnn = new MySqlConnection("Server=127.0.0.1;Database=mizzaitemdb;Uid=root;Pwd=Vishwesh16;");
            else if(dbName.Equals("MizzaToppingDbConnect"))
                _mySqlCnn = new MySqlConnection("Server=127.0.0.1;Database=mizzatoppingdb;Uid=root;Pwd=Vishwesh16;");
            //_mySqlCnn = new MySqlConnection(ConfigurationManager.ConnectionStrings[dbName].ConnectionString);
        }
        public DataTable DataRetrieve(string procedureName, int id = -1)
        {
            MySqlCommand sqlCommand = new MySqlCommand(procedureName, _mySqlCnn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            if (id != -1)
            {
                sqlCommand.Parameters.Add(new MySqlParameter("@Id", id));
            }
            else
            {
                sqlCommand.Parameters.Add(new MySqlParameter("@Id", "NULL"));
            }

            _mySqlCnn.Open();
            da.Fill(dt);
            _mySqlCnn.Close();

            return dt;
        }

        public bool DataInsert<T>(T modelObj, string procedureName)
        {
            MySqlCommand sqlCommand = new MySqlCommand(procedureName, _mySqlCnn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //Attaching properties of models as parameters in sqlCommand
            sqlCommand = modelObj.AttachParameters(sqlCommand);

            _mySqlCnn.Open();
            int i = sqlCommand.ExecuteNonQuery();
            _mySqlCnn.Close();

            return i >= 1 ? true : false;
        }

        public bool DataUpdate<T>(T modelObj, string procedureName, int id)
        {
            MySqlCommand sqlCommand = new MySqlCommand(procedureName, _mySqlCnn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //Attaching properties of models as parameters in sqlCommand
            sqlCommand = modelObj.AttachParameters(sqlCommand);

            sqlCommand.Parameters.Add(new MySqlParameter("@Id", id));

            _mySqlCnn.Open();
            int i = sqlCommand.ExecuteNonQuery();
            _mySqlCnn.Close();

            return i >= 1 ? true : false;
        }

        public bool DataRemove(string procedureName, int id)
        {
            MySqlCommand sqlCommand = new MySqlCommand(procedureName, _mySqlCnn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //Attaching properties of models as parameters in sqlCommand

            //sqlCommand = modelObj.AttachParameters(sqlCommand);

            sqlCommand.Parameters.Add(new MySqlParameter("@Id", id));

            _mySqlCnn.Open();
            int i = sqlCommand.ExecuteNonQuery();
            _mySqlCnn.Close();

            return i >= 1 ? true : false;
        }
    }
}