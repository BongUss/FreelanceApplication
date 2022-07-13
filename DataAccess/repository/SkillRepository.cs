﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class SkillRepository : ISkillRepository
    {
        public List<Skill> GetSkills() => SkillDAO.Instance.GetSkills();
        
    }
}
