using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public interface IProjectRepository
    {
        List<Project> getListProject();
        bool checkProjectStarted(int projectid);
    }
}
