using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class ProposalRepository : IProposalRepository
    {
        public bool createProposal(Proposal proposal) => ProposalDAO.Instance.createProposal(proposal);
        public List<Proposal> getListReceivedJob(int seekerid) => ProposalDAO.Instance.getListReceivedJob(seekerid);

        public List<Proposal> getListSubmitedProposal(int seekerid) => ProposalDAO.Instance.getListSubmitedProposal(seekerid);
    }
}
