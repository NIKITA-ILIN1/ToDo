using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            sqlConnection.Open();

            string sqlRequest = "SELECT * FROM users WHERE login = @login AND password = @password";
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

            sqlConnection.Close();

            SetUser(user);


            return user;
        }

        private void SetUser(User user)
        {
            AuthUser = user;
        }

        public static User GetAuthUser()
        {
            return AuthUser;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
