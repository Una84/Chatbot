using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CybersecurityAwarenessBot
{
    public class TaskManager
    {
        private DatabaseManager database = new DatabaseManager();

        public void AddTask(TaskItem task)
        {
            using (MySqlConnection conn = database.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Tasks
                               (Title, Description, ReminderDate, Completed)
                               VALUES
                               (@title,@description,@reminder,@completed)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", task.Title);
                cmd.Parameters.AddWithValue("@description", task.Description);
                cmd.Parameters.AddWithValue("@reminder", task.ReminderDate);
                cmd.Parameters.AddWithValue("@completed", task.Completed);

                cmd.ExecuteNonQuery();
            }
        }

        public List<TaskItem> GetTasks()
        {
            List<TaskItem> tasks = new List<TaskItem>();

            using (MySqlConnection conn = database.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM Tasks";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TaskItem task = new TaskItem();

                    task.TaskID = Convert.ToInt32(reader["TaskID"]);
                    task.Title = reader["Title"].ToString();
                    task.Description = reader["Description"].ToString();
                    task.ReminderDate = Convert.ToDateTime(reader["ReminderDate"]);
                    task.Completed = Convert.ToBoolean(reader["Completed"]);

                    tasks.Add(task);
                }
            }

            return tasks;
        }

        public void DeleteTask(int id)
        {
            using (MySqlConnection conn = database.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM Tasks WHERE TaskID=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void CompleteTask(int id)
        {
            using (MySqlConnection conn = database.GetConnection())
            {
                conn.Open();

                string sql =
                    "UPDATE Tasks SET Completed=true WHERE TaskID=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
