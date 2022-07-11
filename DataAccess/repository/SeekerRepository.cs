﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class SeekerRepository : ISeekerRepository
    {
        public bool checkDuplicateuserName(string username) => UserDAO.Instance.checkDuplicateuserName(username);

        public bool createSeeker(Seeker seeker) => UserDAO.Instance.createSeeker(seeker);

        public bool createUser(Seeker seeker) => UserDAO.Instance.createUser(seeker);

        public int getSeekerId(Seeker seeker) => UserDAO.Instance.getSeekerId(seeker);
    }
}
