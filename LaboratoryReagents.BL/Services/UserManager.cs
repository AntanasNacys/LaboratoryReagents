using LaboratoryReagents.DL;
using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.BL.Services
{
    class UserManager
    {
        public List<User> GetAll()
        {
            List<User> userList;
            using (var ctx = new ReagentContext())
            {
                userList = ctx.Users.
            }
        }
    }
}
