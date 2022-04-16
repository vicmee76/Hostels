using Hostels.Interfaces;
using Hostels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostels.Services
{
    public class IRolesService : IRoles
    {
        private readonly HostelContext _context;
        public IRolesService(HostelContext context)
        {
            _context = context;
        }

        public async Task<string> DeleteRole(int roleId)
        {
            var get = GetRoleById(roleId);

            if (get.Any())
            {
                _context.Roles.Remove(get.FirstOrDefault());
                if (await _context.SaveChangesAsync() > 0)
                    return "Role removed";
                return "Something went wrong, role was not removed";
            }
            else
            {
                return "Role was not found";
            }
        }



        public IList<Roles> GetRoleById(int roleId)
        {
            var get = _context.Roles.Where(x => x.RoleId.Equals(roleId)).ToList();
            return get;
        }



        public IEnumerable<Roles> GetRoles()
        {
            return _context.Roles;
        }



        public async Task<string> PostRoles(Roles roles)
        {
            if (roles.Equals(null))
                return "Role model cannot be null";
            _context.Roles.Add(roles);
            if (await _context.SaveChangesAsync() > 0)
                return "Role added successfully";
            return "Something went wrong trying to add this role, please try again later";
        }



        public async Task<string> PutRoles(int roleId, Roles roles)
        {
            if (roleId.Equals(null) || roleId.Equals(0) || roles.Equals(null))
                return "Role model and role Id must not be empty";
            var get = GetRoleById(roleId);
            if (!get.Any())
                return "This role cannot be found";
            get.FirstOrDefault().RoleName = roles.RoleName;

            if (await _context.SaveChangesAsync() > 0)
                return "Role updated successfully";
            return "Something went wrong trying to perform this operation, please try again later";
           
        }
    }
}
