using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.repository;

namespace FreelanceApp
{
    public partial class FormRegisterSeeker : Form
    {
        SeekerRepository seekerRepository;
        public FormRegisterSeeker()
        {
            InitializeComponent();
            seekerRepository = new SeekerRepository();
        }

        private void FormRegisterSeeker_Load(object sender, EventArgs e)
        {
            seekerRepository = new SeekerRepository();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //get inf seeker
                Seeker seeker = new Seeker
                {
                    UserName = txtUserName.Text,
                    Password = txtPwd.Text,
                    FullName = txtFullname.Text,
                    Balance = 0,
                    Phone = txtPhone.Text,
                    Location = txtLocation.Text,
                    Overview = txtOverview.Text,
                    School = txtSchool.Text,
                    Major = txtMajor.Text
                };
                //check duplicate username
                if (!seekerRepository.checkDuplicateuserName(seeker.UserName))
                {
                    if (seekerRepository.createUser(seeker))
                    {
                        seeker.UserId = seekerRepository.getSeekerId(seeker);
                        if (seekerRepository.createSeeker(seeker))
                        {
                            MessageBox.Show("create seeker success", "register seeker");
                        }
                        else
                        {
                            MessageBox.Show("create seeker fail", "register seeker");
                        }
                    }
                    else
                    {
                        MessageBox.Show("can't create user", "register seeker");
                    }
                }
                else
                {
                    MessageBox.Show("duplicate user name", "register seeker");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "register seeker");
            }
        }
    }
}
