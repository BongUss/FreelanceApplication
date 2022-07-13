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
    public partial class FormApplyJob : Form
    {
        public Project project;
        ProposalRepository proposalRepository;
        public int seekerid;

        public FormApplyJob()
        {
            InitializeComponent();
        }

        private void FormApplyJob_Load(object sender, EventArgs e)
        {
            proposalRepository = new ProposalRepository();
        }

        private void btApplying_Click(object sender, EventArgs e)
        {
            try
            {
                Proposal proposal = new Proposal
                {
                    ProjectId = project.ProjectId,
                    SeekerId = seekerid,
                    PaymentAmount = decimal.Parse(txtPaymentAmount.Text),
                    Status = "proposal sent",
                    Message = txtMessage.Text,
                };
                if (proposalRepository.createProposal(proposal))
                {
                    MessageBox.Show("sent success", "applying job");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("sent fail", "applying job");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("payment amount must be a number", "applying job");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "applying job");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
