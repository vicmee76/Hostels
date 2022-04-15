using Hostels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostels.Interfaces
{
    public interface IRoles
    {
        IEnumerable<Roles> GetRoles();
        Task<string> PostRoles(Roles roles);
        Task<string> PutRoles(int roleId, Roles roles);
        Task<string> DeleteRole(int roleId);
        IList<Roles> GetRoleById(int roleId);
    }
}
