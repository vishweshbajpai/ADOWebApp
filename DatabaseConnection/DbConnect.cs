using ADOWebApplication.DataRepo;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace ADOWebApplication.ADORepositories
{
    public class DbConnect
    {
        SqlConnection _cnn;
        public DbConnect(string dbName)
        {
            _cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[dbName].ToString());
        }

        //using MySql.Data.MySqlClient;
        //string cs = @"server=localhost;userid=dbuser;password=s$cret;database=mydb";
        //using var con = new MySqlConnection(cs);

    public DataTable DataRetrieve(string procedureName, int id = -1)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, _cnn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            if (id != -1)
            {
                sqlCommand.Parameters.Add(new SqlParameter("@Id", id));
            }

            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();

            return dt;
        }

        public bool DataInsert<T>(T modelObj, string procedureName)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, _cnn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //Attaching properties of models as parameters in sqlCommand

            //sqlCommand = modelObj.AttachParameters(sqlCommand);

            _cnn.Open();
            int i = sqlCommand.ExecuteNonQuery();
            _cnn.Close();

            return i >= 1 ? true : false;
        }

        public bool DataUpdate<T>(T modelObj, string procedureName, int id)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, _cnn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //Attaching properties of models as parameters in sqlCommand

            //sqlCommand = modelObj.AttachParameters(sqlCommand);

            sqlCommand.Parameters.Add(new SqlParameter("@Id", id));

            _cnn.Open();
            int i = sqlCommand.ExecuteNonQuery();
            _cnn.Close();

            return i >= 1 ? true : false;
        }
    }
}
