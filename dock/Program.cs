

using System;

namespace airforce {

    class Program {

        static void Main(string[] args) {

            Docks dados = new Docks();

            Console.WriteLine("TELA DE LOGIN");
            Console.WriteLine();
            Console.Write("Digite o usuário: ");
            dados.User = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite a senha: ");
            dados.Password = int.Parse(Console.ReadLine());
            Console.Write("Digite o ip: ");
            dados.Ip = int.Parse(Console.ReadLine());
            Console.Write("Digite o host: ");
            dados.HostUser = Console.ReadLine();

        }
        
    }

}
