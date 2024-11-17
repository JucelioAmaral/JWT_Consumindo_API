using MonitoraEquipamentos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Repo.Contract
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> SelectAllUsers();
        Task<User> SelectUserByUserID(string user);
    }
}
