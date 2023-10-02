using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidoItems.Entities.Enum;
using PedidoItems.Entities;
using System.Globalization;

namespace PedidoItems.Entities {
    class PedidoInformacoes {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public PedidoInformacoes() { }

        public PedidoInformacoes(int quantidade, double preco, Produto product) {
            Quantidade = quantidade;
            Preco = preco;
            Produto = product;
        }

        public double SubTotal(){
            return Quantidade* Produto.Preco;                    
        }

        public override string ToString() {
            return Produto.Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
