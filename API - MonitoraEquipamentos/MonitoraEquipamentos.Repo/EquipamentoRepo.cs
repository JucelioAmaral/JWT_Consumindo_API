using Dapper;
using MonitoraEquipamentos.Domain;
using MonitoraEquipamentos.Repo.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Repo.Contract
{
    public class EquipamentoRepo : IEquipamentoRepo
    {
        private readonly MonitoraEquipamentosContext _context;

        public EquipamentoRepo(MonitoraEquipamentosContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Equipamento>> SelectAllEquipamentos()
        {
            IDbConnection conn = _context.GetConnection();

            using (conn)
            {
                conn.Open();
                string query = @"SELECT * FROM Equipamento";

                return await conn.QueryAsync<Equipamento>(sql: query);      
                
            }
        }
    }
}
