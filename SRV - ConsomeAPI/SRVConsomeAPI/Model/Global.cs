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
    }
}
