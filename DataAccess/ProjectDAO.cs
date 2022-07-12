using System;
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
