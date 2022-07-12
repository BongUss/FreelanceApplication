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
        IProjectRepository ProjectRepository = new ProjectRepository();
        public FormHirerdashboard()
        {
            InitializeComponent();
        }

        private void buttonViewPostedJob_Click(object sender, EventArgs e)
        {
            dataGridViewListPostedJob.DataSource = ProjectRepository.getListProject();
        }
    }
}
