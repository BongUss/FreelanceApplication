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
    public partial class FormLogin : Form
    {
        IUserRepository UserRepository = new UserRepository();
        IHirerRepository HirerRepository = new HirerRepository();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormDirection FormDirection = new FormDirection();
            FormDirection.ShowDialog();
           
        }

       
       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var Hirers = HirerRepository.GetHirers();
            //var Hirer = HirerRepository.GetHirers();
            //var Seeker = SeekerRepository.GetSeekers();

            foreach (var Hirer in Hirers)
            {
                if (Hirer.UserName == textBoxUserName.Text && Hirer.Password == textBoxPassword.Text)
                {
                   
                    FormHirerdashboard FormHirerdashboard = new FormHirerdashboard();

                    FormHirerdashboard.ShowDialog();
                    this.Close();
                 
                    
                }
            }
        }
    }
}
