using MonitoraEquipamentos.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Application
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByUserId(string userid);        
    }
}
