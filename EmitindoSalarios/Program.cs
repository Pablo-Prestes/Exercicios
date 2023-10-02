using EmitindoNotas.Entities.Enum;
using EmitindoNotas.Entities;
using System.Globalization;

namespace ExerciciosEnum {

    class Program {

        static void Main(string[] args) {

            Console.Write("Insira o nome do Departamento Ex(Design,Programdor, etc....): ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Insira os dados do trabalhador:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Insira o email do trabalhador: ");
            string email = Console.ReadLine();    
            Console.Write("Nivel (Junior/Pleno/Senior): ");
            NivelTrabalhador nivelTrabalhador = Enum.Parse<NivelTrabalhador>(Console.ReadLine());//Atribuindo diretamente a um valor do Enum
            Console.Write("Salario Base R$ ");                                                   //Não existe tratamento de erros então só será válido um status do Enum PedidoStatus
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(  );

            Departamento dept = new Departamento(deptName);
            Trabalhador trabalhador = new Trabalhador(nome, email, nivelTrabalhador, baseSalary, dept);

            Console.Write("Quantos contratos o trabalhador irá ter ? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Insira os dados do {i}° contrato !");
                Console.Write("Data (MM/YY/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora R$ ");
                double valorPorHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração em horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine();
                HorasContrato contrato = new HorasContrato(data, valorPorHoras, horas);
                trabalhador.AdicionarContrato(contrato);
            }
            Console.WriteLine(" "); 
            Console.Write("Digite o mês e o ano do contrato a ser buscado (MM/YYYY): ");
            string MesEAno = Console.ReadLine();
            int Mes = int.Parse(MesEAno.Substring(0, 2));
            int Ano = int.Parse(MesEAno.Substring(3));
            Console.WriteLine("Informações do trabalhador: " + trabalhador.Nome + " - " + trabalhador.Email);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.NomeDepartamento);
            Console.WriteLine("Salário total no mês " + Mes + " e ano "+ Ano + " R$ " +trabalhador.SalarioTotal(Ano,Mes));
        }

    }
}

