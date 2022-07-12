using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class UserDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }

        public bool createUser(Seeker user)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "insert into [User](userName, password, fullName, balance, phone, location) " +
                        "values(@userName, @password, @fullName, 0, @phone, @location)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@userName", user.UserName);
                    commad.Parameters.AddWithValue("@password", user.Password);
                    commad.Parameters.AddWithValue("@fullName", user.FullName);
                    commad.Parameters.AddWithValue("@phone", user.Phone);
                    commad.Parameters.AddWithValue("@location", user.Location);
                    check = commad.ExecuteNonQuery() > 0 ? true:false;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return check;
        }

        public bool createUser1(Hirer user)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "insert into [User](userName, password, fullName, balance, phone, location) " +
                        "values(@userName, @password, @fullName, 0, @phone, @location)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@userName", user.UserName);
                    commad.Parameters.AddWithValue("@password", user.Password);
                    commad.Parameters.AddWithValue("@fullName", user.FullName);
                    commad.Parameters.AddWithValue("@phone", user.Phone);
                    commad.Parameters.AddWithValue("@location", user.Location);
                    check = commad.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return check;
        }

        public bool createSeeker(Seeker seeker)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "insert into Seeker(seekerID, overview, school, major) " +
                        "values(@seekerID, @overview, @school, @major)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@seekerID", seeker.UserId);
                    commad.Parameters.AddWithValue("@overview", seeker.Overview);
                    commad.Parameters.AddWithValue("@school", seeker.School);
                    commad.Parameters.AddWithValue("@major", seeker.Major);
                    check = commad.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return check;
        }

        public bool createHirer(Hirer Hirer)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "insert into Hirer(hirerID, companyName) " +
                        "values(@hirerID, @companyName)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@hirerID", Hirer.UserId);
                    commad.Parameters.AddWithValue("@companyName", Hirer.CompanyName);             
                    check = commad.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return check;
        }



        public bool checkDuplicateuserName(string username)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select userID from[User] " +
                        "where userName = @userName";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@userName", username);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        check = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return check;
        }

        public int getHirerId(Hirer Hirer)
        {
            int id = 0;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select userID from[User] " +
                        "where userName = @username " +
                        "and password = @pwd";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@username", Hirer.UserName);
                    commad.Parameters.AddWithValue("@pwd", Hirer.Password);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return id;
        }

        public int getSeekerId(Seeker seeker)
        {
            int id = 0;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select userID from[User] " +
                        "where userName = @username " +
                        "and password = @pwd";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@username", seeker.UserName);
                    commad.Parameters.AddWithValue("@pwd", seeker.Password);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return id;
        }
    }
}
