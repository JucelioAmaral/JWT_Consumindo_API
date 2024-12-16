using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV_ConsomeAPI.Model
{
    public static class Global
    {
        private static List<Equipamento> _equipamentos;
        public static List<Equipamento> equipamentos  // read-write instance property
        {
            get => _equipamentos;
            set => _equipamentos = value;
        }

        private static string _statusConexaoAPI;
        public static string statusConexaoAPI  // read-write instance property
        {
            get => _statusConexaoAPI;
            set => _statusConexaoAPI = value;
        }

        private static bool _autenticado;
        public static bool autenticado  // read-write instance property
        {
            get => _autenticado;
            set => _autenticado = value;
        }
        
    }
}
