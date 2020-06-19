using System;

namespace ExiFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante doguinho = new Restaurante("doguinho do zé", "ali na esquina");
            Console.WriteLine(doguinho.MostrarDados());
            Console.WriteLine("-----------------------------------------------------------");
            
            Cliente hitoshi = new Cliente("Hitoshi", "rua paulo leite de siqueira, 1188");
            Console.WriteLine(hitoshi.MostrarDados());
            Console.WriteLine("-----------------------------------------------------------");
            
            Pedido strogonoff = new Pedido();
            strogonoff.Cliente = hitoshi.Nome;
            strogonoff.Restaurante = doguinho.NomeFantasia;
            Console.WriteLine(strogonoff.EntregarPedido("Fejuca", "Crédito"));
            
        }
    }
}
