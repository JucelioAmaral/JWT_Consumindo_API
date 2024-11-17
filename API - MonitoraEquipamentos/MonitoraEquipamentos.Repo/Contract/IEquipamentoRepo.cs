using MonitoraEquipamentos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Repo.Contract
{
    public interface IEquipamentoRepo
    {
        Task<IEnumerable<Equipamento>> SelectAllEquipamentos();
    }
}
