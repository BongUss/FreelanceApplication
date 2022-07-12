using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProposalDAO
    {
        string connectionString = "Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm";

        SqlConnection connect;

        SqlCommand commad;

        SqlDataReader reader;

        private static ProposalDAO instance;
        public static ProposalDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProposalDAO();
                }
                return instance;
            }
        }
        public List<Proposal> getListSubmitedProposal(int seekerid)
        {
            List<Proposal> listP = new List<Proposal>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select proposalID, projectID, seekerID,  " +
                        "paymentAmount, status, createdDate, message " +
                        "from Proposal " +
                        "where seekerID = @id and status = 'job sent'";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", seekerid);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listP.Add(new Proposal
                            {
                                ProjectId = reader.GetInt32(0),
                                ProposalId = reader.GetInt32(1),
                                SeekerId = reader.GetInt32(2),
                                PaymentAmount = reader.GetDecimal(3),
                                Status = reader.GetString(4),
                                CreatedDate = reader.GetDateTime(5),
                                Message = reader.GetString(6)
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

        public List<Proposal> getListReceivedJob(int seekerid)
        {
            List<Proposal> listP = new List<Proposal>();
            try
            {
                connect = new SqlConnection(connectionString);
                if (connect != null)
                {
                    connect.Open();
                    string sql = "select proposalID, projectID, seekerID,  " +
                        "paymentAmount, status, createdDate, message " +
                        "from Proposal " +
                        "where seekerID = @id and status = 'job started'";
                    commad = new SqlCommand(sql, connect);
                    commad.Parameters.AddWithValue("@id", seekerid);
                    reader = commad.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listP.Add(new Proposal
                            {
                                ProjectId = reader.GetInt32(0),
                                ProposalId = reader.GetInt32(1),
                                SeekerId = reader.GetInt32(2),
                                PaymentAmount = reader.GetDecimal(3),
                                Status = reader.GetString(4),
                                CreatedDate = reader.GetDateTime(5),
                                Message = reader.GetString(6)
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
    }
}
