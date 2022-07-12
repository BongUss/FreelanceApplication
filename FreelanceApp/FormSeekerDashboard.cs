using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.repository;
using BusinessObject;

namespace FreelanceApp
{
    public partial class FormSeekerDashboard : Form
    {
        ProjectRepository projectRepository;
        public FormSeekerDashboard()
        {
            InitializeComponent();
            projectRepository = new ProjectRepository();
        }

        private void FormSeekerDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btViewListJob_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewListJob.Visible = true;
                dataGridViewListProposal.Visible = false;
                dataGridViewReceivedJobList.Visible = false;
                //get list project
                List<Project> listP = projectRepository.getListProject();
                if(listP != null)
                {
                    //get list job not started
                    List<Project> listPNotStarted = new List<Project>();    //list này đc nhưng mà nó dư 3 att là hirer, needskill, proposal nên xài list dưới
                    List<dynamic> listPNotStarted1 = new List<dynamic>();
                    foreach (var item in listP)
                    {
                        if (projectRepository.checkProjectStarted(item.ProjectId) == false)
                        {
                            listPNotStarted.Add(item);
                            listPNotStarted1.Add(new 
                            {
                                ProjectId = item.ProjectId,
                                ProjectName = item.ProjectName,
                                Description = item.Description,
                                HirerId = item.HirerId,
                                Location = item.Location,
                                PaymentAmount = item.PaymentAmount,
                                Major = item.Major,
                                Complexity = item.Complexity,
                                ExpectedDuration = item.ExpectedDuration,
                                CreatedDate = item.CreatedDate
                            });
                        }
                    }
                    dataGridViewListJob.DataSource = null;
                    dataGridViewListJob.DataSource = listPNotStarted1;
                }
                else
                {
                    MessageBox.Show("no job not started", "View list job");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "View list job");
            }
        }
        public void clearField()
        {
            txtComplexity.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtMajor.Text = string.Empty;
            txtPaymentAmount.Text = string.Empty;
            txtProjectName.Text = string.Empty;
        }
        private void dataGridViewListJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clearField();
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dataGridViewListJob.Rows[e.RowIndex];
                
                txtProjectName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                txtLocation.Text = row.Cells[4].Value.ToString();
                txtPaymentAmount.Text = row.Cells[5].Value.ToString();
                txtMajor.Text = row.Cells[6].Value.ToString();
                txtComplexity.Text = row.Cells[7].Value.ToString();
                dtpCreateday.Value = DateTime.Parse(row.Cells[9].Value.ToString());
                dtpExpedtedDay.Value = DateTime.Parse(row.Cells[8].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " click row of list job");
            }
        }
    }
}
