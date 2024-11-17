using MonitoraEquipamentos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Application.Contract
{
    public interface IEquipamentoService
    {
        Task<List<Equipamento>> GetAllEquipamentos();
    }
}
