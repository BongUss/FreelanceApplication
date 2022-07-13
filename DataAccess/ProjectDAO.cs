﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class ProjectDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static ProjectDAO instance;
        public static ProjectDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectDAO();
                }
                return instance;
            }
        }

        //--lấy skill của project đó cần ra
        //select projectID, skillName
        //from NeededSkills nk, Skill s
        //where projectID = 3 and nk.skillID = s.skillID

        public List<Project> getListProject()
        {
            List<Project> listP = new List<Project>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select projectID, projectName, description, hirerID, location, paymentAmount, major, complexity, expectedDuration, createdDate " +
                        "from Project";
                    commad = new SqlCommand(sql, connect);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listP.Add(new Project
                            {
                                ProjectId = reader.GetInt32(0),
                                ProjectName = reader.GetString(1),
                                Description = reader.GetString(2),
                                HirerId = reader.GetInt32(3),
                                Location = reader.GetString(4),
                                PaymentAmount = reader.GetDecimal(5),
                                Major = reader.GetString(6),
                                Complexity = reader.GetString(7),
                                ExpectedDuration = reader.GetString(8),
                                CreatedDate = reader.GetDateTime(9)
                            });
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
            return listP;
        }

      
        public int getProjectIDByProject (Project Project)
        {
            int id = -1;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "SELECT projectID FROM Project WHERE projectName = @projectName AND hirerID = @hirerID AND location = @location AND paymentAmount = @paymentAmount AND major = @major AND complexity = @complexity AND expectedDuration = @expectedDuration";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@projectName", Project.ProjectName);
                    
                    commad.Parameters.AddWithValue("@hirerID", Project.HirerId);
                    commad.Parameters.AddWithValue("@location", Project.Location);
                    commad.Parameters.AddWithValue("@paymentAmount", Project.PaymentAmount);
                    commad.Parameters.AddWithValue("@major", Project.Major);
                    commad.Parameters.AddWithValue("@complexity", Project.Complexity);
                    commad.Parameters.AddWithValue("@expectedDuration", Project.ExpectedDuration);
                    



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
                throw new Exception(ex.Message + "loi o day");
            }
            finally
            {
                connect.Close();
            }
            return id;
        }

        public bool Create(Project Project)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "INSERT INTO Project (projectName, description, hirerID, location, paymentAmount, major, complexity, expectedDuration, createdDate) VALUES (@projectName, @description, @hirerID, @location, @paymentAmount, @major, @complexity, @expectedDuration, @createdDate)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@projectName", Project.ProjectName);
                    commad.Parameters.AddWithValue("@description", Project.Description);
                    commad.Parameters.AddWithValue("@hirerID", Project.HirerId);
                    commad.Parameters.AddWithValue("@location", Project.Location);
                    commad.Parameters.AddWithValue("@paymentAmount", Project.PaymentAmount);
                    commad.Parameters.AddWithValue("@major", Project.Major);
                    commad.Parameters.AddWithValue("@complexity", Project.Complexity);
                    commad.Parameters.AddWithValue("@expectedDuration", Project.ExpectedDuration);
                    commad.Parameters.AddWithValue("@createdDate", Project.CreatedDate);


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



        public bool checkProjectStarted(int projectid)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select * from Proposal where status = 'job started' and projectID = @id";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", projectid);
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
    }
}
