using LaboratoryReagents.DL;
using LaboratoryReagents.DL.Models;
using System.Collections.Generic;
using System.Linq;

namespace LaboratoryReagents.BL.Services
{
    public class UserManager : IUserManager
    {
        public List<User> GetAll()
        {
            List<User> userList;
            using (var ctx = new ReagentContext())
            {
                userList = ctx.Users.ToList();
            }
            return userList;
        }
    }
}
