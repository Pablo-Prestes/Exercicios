using System;
using System.Globalization;
using System.Threading.Channels;
using PedidoComItems.Entities;
using PedidoComItems.Entities.Enum;

namespace Teste {
    public class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informações do cliente !");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write(" Data de nascimento (DD/MM/YYYY): ");
            DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine());

            PedidoStatus status = PedidoStatus.Processando;//Atribuindo diretamente a um valor do Enum
                                                           //Não existe tratamento de erros então só será válido um status do Enum PedidoStatus
            Console.Write("Status do pedido: " + status);
            Console.WriteLine(" ");
         
            Cliente cliente = new Cliente(nome, email, dataDeNascimento);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.WriteLine(" ");
            Console.WriteLine("Informações do pedido: ");
            Console.WriteLine("Status do pedido: " + status);

            Console.Write("Quantos items o pedido irá conter ? ");
            int qtdData = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");  
            for (int i = 1; i <= qtdData; i++) {
                Console.WriteLine($"Insira os dados do {i}° item !");
                Console.Write("Nome do Produto: ");
                string prdName = Console.ReadLine();
                Console.Write("Preço do Produto R$ ");
                double prdPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto product = new Produto(prdName, prdPrice);
                Console.Write("Quantidade de produtos: ");
                int prdQuant = int.Parse(Console.ReadLine());
                PedidoInformacoes ItemsDoPedido = new PedidoInformacoes(prdQuant, prdPrice, product);
                pedido.AdicionarItem(ItemsDoPedido);
            }
            Console.WriteLine(pedido);
        }
    }
}

