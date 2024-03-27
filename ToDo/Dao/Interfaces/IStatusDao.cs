using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;

namespace ToDo.Dao.Interfaces
{
    internal interface IStatusDao
    {
        Status GetStatusById(int id);

        List<Status> GetListStatus ();
    }
}
