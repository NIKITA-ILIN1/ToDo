using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Dao.Interfaces
{
    internal interface IStatusDao
    {
        Status GetStatusById(int id);

        List<Status> GetStatus ();
    }
}
