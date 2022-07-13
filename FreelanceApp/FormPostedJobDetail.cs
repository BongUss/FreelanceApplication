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
    public partial class FormPostedJobDetail : Form
    {
        public bool InsertOrUpdate; //true co nghia la update
        public int HirerId; // id cua nguoi hirer dang nhap vao
        ISkillRepository SkillRepository = new SkillRepository();
        IProjectRepository ProjectRepository = new ProjectRepository();

        public FormPostedJobDetail()
        {
            InitializeComponent();
        }

        private void FormPostedJobDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == false)
            {
                buttonWithDraw.Visible = false;
            }

            //code cho insert
            dateTimePickerCreatedDate.Value = DateTime.UtcNow.Date;
            dateTimePickerCreatedDate.Enabled = false;


            //hien thi list skill len
            List<Skill> ListSkill = SkillRepository.GetSkills();
            string[] StringListSkill = new string[ListSkill.Count];

            int i = 0; //coi chung co loi phan nay
            foreach (Skill skill in ListSkill)
            {
                StringListSkill[i] = skill.SkillName;
                i++;
            }
            checkedListBoxSkill.Items.AddRange(StringListSkill);
            checkedListBoxSkill.CheckOnClick = true;
            
            
            
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                //get inf seeker
                Project Project = new Project
                {
                    ProjectName = textBoxProjectName.Text,
                    Description = textBoxDescription.Text,
                    HirerId = this.HirerId,
                    Location = textBoxLocation.Text,
                    PaymentAmount = Decimal.Parse(textBoxPaymentAmount.Text),
                    Major = textBoxMajor.Text,
                    Complexity = textBoxComplexity.Text,
                    ExpectedDuration = textBoxExpectedDuration.Text,
                    CreatedDate = DateTime.UtcNow.Date,
                };
                bool check = ProjectRepository.CreateProject(Project);

                List<Skill> ListSkill = SkillRepository.GetSkills(); // lay duoc tat cac skill

                var selectedSkills = new List<string>();
                foreach (var skill in checkedListBoxSkill.CheckedItems)
                {
                    selectedSkills.Add(skill.ToString());
                }






                if (check)
                {
                    MessageBox.Show("Post a job successfully");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "post a job - hirer");
            }
        }
    }
}
