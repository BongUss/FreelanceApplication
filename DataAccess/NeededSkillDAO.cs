using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BusinessObject;

namespace DataAccess
{
    public class NeededSkillDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static NeededSkillDAO instance;
        public static NeededSkillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NeededSkillDAO();
                }
                return instance;
            }
        }

        public bool Create(NeededSkill NeededSkill)
        {
            bool check = false;
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "INSERT INTO NeededSkills (projectID, skillID) VALUES (@projectID, @skillID)";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@projectID", NeededSkill.ProjectId);
                    commad.Parameters.AddWithValue("@skillID", NeededSkill.SkillId);
                    


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
    }
}
