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
            dataGridViewListPostedJob.DataSource = ProjectRepository.getListProject();
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
