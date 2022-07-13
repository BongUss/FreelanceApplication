using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.repository
{
    public class NeededSkillRepository : INeededSkillRepository
    {
        public bool Create(NeededSkill NeededSkill) => NeededSkillDAO.Instance.Create(NeededSkill);
    }
}
