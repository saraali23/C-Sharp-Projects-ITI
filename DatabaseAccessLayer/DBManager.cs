using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DatabaseAccessLayer
{
    public class DBManager
    {

        SqlConnection sqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDA;
        DataTable Dt;

        public DBManager()
        {
            try
            {
                sqlCN = new SqlConnection(ConfigurationManager.ConnectionStrings["PubCN"].ConnectionString);
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCN;
                sqlDA = new(sqlCmd);
                Dt = new();
            }
            catch
            {
                //Logg Exception
            }
        }

        public int ExecuteNonQuery(string SPName)
        {
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                if (sqlCN.State == ConnectionState.Closed)
                    sqlCN.Open();

                return sqlCmd.ExecuteNonQuery();

            }
            catch
            {
                return -1;
            }
            finally
            {
                sqlCN.Close();
            }
        }

        public int ExecuteNonQuery(string SPName, Dictionary<String, object> ParmLst)
        {
            try
            {
                sqlCmd.Parameters.Clear();

                foreach (var item in ParmLst)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = SPName;

                if (sqlCN.State == ConnectionState.Closed)
                    sqlCN.Open();

                return sqlCmd.ExecuteNonQuery();

            }
            catch
            {
                return -1;
            }
            finally
            {
                sqlCN.Close();
            }
        }

        public object ExecuteScalar(string SPName)
        {
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                if (sqlCN.State == ConnectionState.Closed)
                    sqlCN.Open();

                return sqlCmd.ExecuteScalar();

            }
            catch
            {
                return new();
            }
            finally
            {
                sqlCN.Close();
            }
        }

        public object ExecuteScalar(string SPName, Dictionary<String, object> ParmLst)
        {
            throw new NotImplementedException();
        }
        public DataTable ExecuteDataTable(string SPName)
        {
            try
            {
                Dt.Clear();
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDA);
                sqlDA.InsertCommand = commandBuilder.GetInsertCommand();
                sqlDA.UpdateCommand = commandBuilder.GetUpdateCommand();
                sqlDA.DeleteCommand = commandBuilder.GetDeleteCommand();

                sqlDA.Fill(Dt);

                return Dt;
            }
            catch
            {
                return new();
            }
        }

        public DataTable ExecuteDataTable(string SPName, Dictionary<String, object> ParmLst)
        {
            return Dt;
        }
        public void UpdateAllTable(DataTable D)
        {
            sqlDA.Update(D);
        }




    }

}