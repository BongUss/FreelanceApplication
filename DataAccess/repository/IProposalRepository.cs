using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public interface IProposalRepository
    {
        List<Proposal> getListSubmitedProposal(int seekerid);
        List<Proposal> getListReceivedJob(int seekerid);
    }
}
