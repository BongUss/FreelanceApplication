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
                    List<Project> listPNotStarted = new List<Project>();
                    foreach (var item in listP)
                    {
                        if (projectRepository.checkProjectStarted(item.ProjectId) == false)
                        {
                            listPNotStarted.Add(item);
                        }
                    }
                    dataGridViewListJob.DataSource = null;
                    dataGridViewListJob.DataSource = listPNotStarted;
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
    }
}
