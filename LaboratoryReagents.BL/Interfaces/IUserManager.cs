using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.BL.Services
{
    public interface IUserManager
    {
        List<User> GetAll();
    }
}