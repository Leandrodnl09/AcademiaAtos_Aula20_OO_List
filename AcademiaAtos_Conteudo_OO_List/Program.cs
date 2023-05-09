namespace AcademiaAtos_Conteudo_OO_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Leandro Di Nardo";
            p1.Email = "leandro@gmail.com";
            Console.WriteLine($"Nome {p1.Nome}");
            Console.WriteLine($"E-mail {p1.Email}");
            p1.Endereco = new Endereco();
            p1.Endereco.Rua = "Av. Libra";
            p1.Endereco.Numero = 10;
            p1.Endereco.Complemento = "Jardim do Sol";
            Console.WriteLine($"{p1.Nome} morador da rua {p1.Endereco.Rua}, nº {p1.Endereco.Numero}, complemento {p1.Endereco.Complemento}.");
            Pessoa p2 = new Pessoa();
            p2.Nome = "Leandro Di Nardo";
            p2.Email = "leandro@gmail.com";
            Console.WriteLine($"Nome {p2.Nome}");
            Console.WriteLine($"E-mail {p2.Email}");
            p2.Endereco = new Endereco();
            p2.Endereco.Rua = "Av. Libra";
            p2.Endereco.Numero = 10;
            p2.Endereco.Complemento = "Jardim do Sol";
            Console.WriteLine($"{2.Nome} morador da rua {p2.Endereco.Rua}, nº {p2.Endereco.Numero}, complemento {p2.Endereco.Complemento}.");

            Pessoa p3 = new Pessoa();
            p3.Nome = "Leandro Di Nardo";
            p3.Email = "leandro@gmail.com";
            Console.WriteLine($"Nome {p3.Nome}");
            Console.WriteLine($"E-mail {p3.Email}");
            p3.Endereco = new Endereco();
            p3.Endereco.Rua = "Av. Libra";
            p3.Endereco.Numero = 10;
            p3.Endereco.Complemento = "Jardim do Sol";

            List<Pessoa> list = new List<Pessoa>();
            
            list.Add( p1 );
            list.Add( p2 );
            list.Add( p3 );

            foreach ( var item in list )
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"E-Mail: {item.Email}");
                Console.WriteLine($"Rua: {item.Endereco.Rua}");
                Console.WriteLine($"Numero da Rua: {item.Endereco.Numero}");
                Console.WriteLine($"Complemento: {item.Endereco.Complemento}");
            }
        }
    }
}