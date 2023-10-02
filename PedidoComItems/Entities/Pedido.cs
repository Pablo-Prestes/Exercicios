using PedidoItems.Entities.Enum;
using PedidoItems.Entities;
using System.Text;
using System.Globalization;

namespace PedidoItems.Entities {
    class Pedido {
        public DateTime MomentoPedido { get;  set; }
        public PedidoStatus PedidoStatus { get; set; }
        public List<PedidoInformacoes> itemPedido { get;  set; } = new List<PedidoInformacoes>();         
        public Cliente Cliente { get; private set; }    
        public Pedido(DateTime momentoPedido, PedidoStatus status, Cliente cliente) {
            MomentoPedido = momentoPedido;
            PedidoStatus = status;
            Cliente = cliente;
        }
        public void AdicionarItem(PedidoInformacoes pedidoItems) {
            itemPedido.Add(pedidoItems);

        }
        public void RemoverItem(PedidoInformacoes pedidoItems) {
            itemPedido.Remove(pedidoItems);
        }

        public double Total() {
            double sum = 0;
            foreach (PedidoInformacoes ITEM in itemPedido) {
                sum += ITEM.SubTotal();                             
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resumo do Pedido !");
            Console.WriteLine();
            sb.AppendLine("Momento do Pedido: " + MomentoPedido.ToString("dd/MM/yyyy HH:mm:ss")); ;
            sb.AppendLine("Status do Pedido: " + PedidoStatus);
            Console.WriteLine();
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine();
            sb.AppendLine("Items do Pedido: ");
            foreach (PedidoInformacoes ITEM in itemPedido) { 
                sb.AppendLine(ITEM.ToString());
            }
            sb.AppendLine("Valor total do Pedido R$" + Total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString(); 

        }
    }
}
