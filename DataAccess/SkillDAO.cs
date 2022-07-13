using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BusinessObject;

namespace DataAccess
{
    public class SkillDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static SkillDAO instance;
        public static SkillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SkillDAO();
                }
                return instance;
            }
        }

        public List<Skill> GetSkills()
        {
            List<Skill> ListSkill = new List<Skill>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "SELECT skillID, skillName FROM Skill";
                    commad = new SqlCommand(sql, connect);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListSkill.Add(new Skill
                            {
                                SkillId = reader.GetInt32(0),
                                SkillName = reader.GetString(1),
                                
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
            return ListSkill;
        }

    }
}
