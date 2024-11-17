using AutoMapper;
using MonitoraEquipamentos.Application.Contract;
using MonitoraEquipamentos.Domain;
using MonitoraEquipamentos.Repo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Application
{

    public class EquipamentoService : IEquipamentoService
    {
        private readonly IEquipamentoRepo _equipRepo;
        private readonly IMapper _mapper;

        public EquipamentoService(IEquipamentoRepo equipRepo, IMapper mapper)
        {
            _equipRepo = equipRepo;
            _mapper = mapper;
        }

        public async Task<List<Equipamento>> GetAllEquipamentos()
        {
            var arrayEquipamentos = new List<Equipamento>();

            try
            {
                var equipamentos = await _equipRepo.SelectAllEquipamentos();
                if (equipamentos == null) return null;

                foreach (var equipamento in equipamentos)
                {
                    var equip = new Equipamento()
                    {
                        IDEquipamento = equipamento.IDEquipamento,
                        Descricao = equipamento.Descricao,
                        Status = equipamento.Status
                    };
                    arrayEquipamentos.Add(equip);
                }

                return arrayEquipamentos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
