﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.repository
{
    public interface ISeekerRepository
    {
        bool createSeeker(Seeker seeker);
        bool createUser(Seeker user);
        int getSeekerId(Seeker seeker);
        bool checkDuplicateuserName(string seeker);

        List<Seeker> GetSeekers();
    }
}
