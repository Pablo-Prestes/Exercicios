using EmitindoNotas.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace EmitindoNotas.Entities {
    class Trabalhador {
        public string MesEAno { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public NivelTrabalhador NiveTrabalhador { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContrato> Contrato { get; set; } = new List<HorasContrato>();

        public Trabalhador() {
        }
        public Trabalhador(string nome, string email, NivelTrabalhador nivelTrabalhador, double salarioBase, Departamento departamento) {
            Nome = nome;
            Email = email;
            NiveTrabalhador = nivelTrabalhador;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(HorasContrato contrato) {
            Contrato.Add(contrato);

        }
        public void RemoverContract(HorasContrato contrato) {
            Contrato.Remove(contrato);
        }

        public double SalarioTotal(int ano, int mes) {
            double sum = SalarioBase;
            foreach (HorasContrato contrato in Contrato) {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes) {//Verifica se o contrato vai estar nos parâmetros desejados
                    sum += contrato.TotalHoras();
                }
            }
            return sum;
        }

    }
}
