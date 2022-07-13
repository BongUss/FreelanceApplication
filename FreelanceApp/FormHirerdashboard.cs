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
using DataAccess.repository;

namespace FreelanceApp
{
    public partial class FormHirerdashboard : Form
    {
        public int HirerId; //id cua nguoi hirer dang nhap vao
        IProjectRepository ProjectRepository = new ProjectRepository();
        public FormHirerdashboard()
        {
            InitializeComponent();
        }

        private void buttonViewPostedJob_Click(object sender, EventArgs e)
        {
            List<Project> listP = ProjectRepository.getListProject();

            List<Project> listPNotStarted = new List<Project>();    //list này đc nhưng mà nó dư 3 att là hirer, needskill, proposal nên xài list dưới
            List<dynamic> listPNotStarted1 = new List<dynamic>();
            foreach (var item in listP)
            {
                if (ProjectRepository.checkProjectStarted(item.ProjectId) == false)
                {
                    if (item.HirerId == this.HirerId)
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
            }

            if (listPNotStarted1.Count != 0)
            {
                dataGridViewListPostedJob.DataSource = listPNotStarted1;

            }
            else
            {
                MessageBox.Show("No item in the list");

            }






        }

        private void buttonPostAJob_Click(object sender, EventArgs e)
        {
            FormPostedJobDetail FormPostedJobDetail = new FormPostedJobDetail()
            {
                InsertOrUpdate = false,
                HirerId = this.HirerId,
            };
            FormPostedJobDetail.ShowDialog();
        }

        private void FormHirerdashboard_Load(object sender, EventArgs e)
        {
            dataGridViewAcceptedJob.Visible = false;
            dataGridViewListPostedJob.Visible = true;
        }
    }
}
