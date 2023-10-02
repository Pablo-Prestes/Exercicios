using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PedidoComItems.Entities {
     class Cliente {

        public string Nome{ get;  set; }
        public string Email{ get; set; }
        public DateTime DataDeNascimento{ get; set; }

        public Cliente() { }
        public Cliente(string nome, string email, DateTime dataDeNascimento) {
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;   
        }

        public override string ToString() {
            return Nome
                + ", ("
                + DataDeNascimento.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
