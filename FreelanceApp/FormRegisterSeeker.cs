﻿using System;
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
        public Seeker seeker1;
        public FormRegisterSeeker()
        {
            InitializeComponent();
            seekerRepository = new SeekerRepository();
        }

        private void FormRegisterSeeker_Load(object sender, EventArgs e)
        {
            seekerRepository = new SeekerRepository();
            if(seeker1 != null)
            {
                txtFullname.Text = seeker1.FullName;
                txtLocation.Text = seeker1.Location;
                txtMajor.Text = seeker1.Major;
                txtOverview.Text = seeker1.Overview;
                txtPhone.Text = seeker1.Phone;
                txtPwd.Text = seeker1.Password;
                txtSchool.Text = seeker1.School;
                txtUserName.Text = seeker1.UserName;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public dynamic checkFormat()
        {
            //check duplicate username
            if (seekerRepository.checkDuplicateuserName(txtUserName.Text))
            {
                return new
                {
                    check = false,
                    msg = "duplicate username",
                };
            };

            //check format phone
            if (txtPhone.Text.Length != 10)
            {
                return new
                {
                    check = false,
                    msg = "phone number not correct",
                };
            }


            //no error
            return new
            {
                check = true,
                msg = "no error",
            };
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
                var checkf = checkFormat();
                if(checkf.check == false)
                {
                    MessageBox.Show(checkf.msg, "register seeker");
                    FormRegisterSeeker formRegisterSeeker = new FormRegisterSeeker
                    {
                        seeker1 = seeker
                    };
                    if(formRegisterSeeker.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                else
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "register seeker");
            }
        }
    }
}
