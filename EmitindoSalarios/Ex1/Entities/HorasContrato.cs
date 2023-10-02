using System;

namespace EmitindoNotas.Entities {
     class HorasContrato {
        public DateTime Data { get; set; }
        public double ValorPorHoras { get;  set; }

        public int HorasTrabalhadas { get;  set; }

        public HorasContrato() { 
        
        }

        public HorasContrato(DateTime data, double valorPorhoras, int horasTrabalhadas) {
            Data = data;
            ValorPorHoras = valorPorhoras;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public double TotalHoras() {
            return HorasTrabalhadas * ValorPorHoras;            
        }

    }
}
