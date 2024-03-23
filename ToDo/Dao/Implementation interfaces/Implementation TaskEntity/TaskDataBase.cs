﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Dao.Interfaces;
using ToDo.Entity;

namespace ToDo.Dao.Implementation_interfaces
{
    internal class TaskDataBase : ITaskDao
    {
        SqlConnection sqlConnection = DBConnector.GetInstance().GetSqlConnection();

        public void CreateTask(TaskEntity task)
        {
            sqlConnection.Open();

            string sqlRequest = "INSERT INTO Tasks (user_id, name, description, status, time_start, time_stop)" +
                "VALUES (@user_id, @name, @description, @status, @time_start, @time_stop)";
            SqlCommand sqlCommand = new SqlCommand(sqlRequest, sqlConnection);
            sqlCommand.Parameters.Add("@user_id", System.Data.SqlDbType.BigInt).Value = task.UserId;
            sqlCommand.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = task.Name;
            sqlCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = task.Description;
            sqlCommand.Parameters.Add("@status", System.Data.SqlDbType.VarChar).Value = task.Status;
            sqlCommand.Parameters.Add("@time_start", System.Data.SqlDbType.DateTime).Value = task.TimeStart;
            sqlCommand.Parameters.Add("@time_stop", System.Data.SqlDbType.DateTime).Value = task.TimeStop;

            try 
            {
                sqlCommand.ExecuteNonQuery();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public List<TaskEntity> ReadTask(TaskEntity task)
        {
            sqlConnection.Open();

            string sqlRequest = "SELECT * FROM Tasks WHERE user_id = @user_id";
            SqlCommand sqlCommand = new SqlCommand(sqlRequest, sqlConnection);
            sqlCommand.Parameters.Add("@user_id", System.Data.SqlDbType.VarChar).Value = task.UserId;

            try
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<TaskEntity> tasks = new List<TaskEntity>();

                if (!sqlDataReader.HasRows) {
                    sqlConnection.Close();

                    return tasks;
                }

                while (sqlDataReader.Read()) {
                    tasks.Add(new TaskEntity((long)sqlDataReader.GetValue(0),
                        (long)sqlDataReader.GetValue(1),
                        (string)sqlDataReader.GetValue(1),
                        (string)sqlDataReader.GetValue(2),
                        (string)sqlDataReader.GetValue(3),
                        (DateTime)sqlDataReader.GetValue(4),
                        (DateTime)sqlDataReader.GetValue(5)));
                }

                return tasks;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public void UpdateStatusTask(TaskEntity task)
        {
            throw new NotImplementedException();
        }     

        public void DeleteTask(TaskEntity task)
        {
            sqlConnection.Open();

            string sqlRequest = "SELECT FROM Tasks WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(sqlRequest, sqlConnection);
            sqlCommand.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = task.Id;

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
    }
}