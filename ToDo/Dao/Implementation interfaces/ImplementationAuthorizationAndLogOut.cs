using System;
using System.Data.SqlClient;
using ToDo.Dao.Interfaces;
using ToDo.Entity;

namespace ToDo.Dao.Implementation_interfaces
{
    internal class ImplementationAuthorizationAndLogOut : IAuthorizationAndLogOutDao
    {
        SqlConnection sqlConnection = DBConnector.GetInstance().GetSqlConnection();
        private static User AuthUser;

        public User Authorization(User user)
        {
            try {
                sqlConnection.Open();

                string sqlRequest = "SELECT * FROM Users WHERE login = @login AND password = @password";
                SqlCommand sqlCommand = new SqlCommand(sqlRequest, sqlConnection);
                sqlCommand.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
                sqlCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (!sqlDataReader.HasRows)
                {
                    sqlConnection.Close();
                    throw new Exception();
                }

                while (sqlDataReader.Read())
                {
                    user.Id = (long)sqlDataReader.GetValue(0);
                    user.Name = (string)sqlDataReader.GetValue(1);
                }

                SetUser(user);

                return AuthUser;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { sqlConnection.Close(); }
        }

        public static User GetAuthUser()
        {
            return AuthUser;
        }

        private void SetUser(User user)
        {
            AuthUser = user;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
