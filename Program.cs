using System;

namespace ExiFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante restaurante = new Restaurante("doguinho do zé", "ali na esquina");
            Console.WriteLine(restaurante.MostrarDados());
            Console.WriteLine("-----------------------------------------------------------");
            
            Cliente cliente = new Cliente("Hitoshi", "rua paulo leite de siqueira, 1188");
            Console.WriteLine(cliente.MostrarDados());
            Console.WriteLine("-----------------------------------------------------------");
            
            Pedido pedido = new Pedido("");
        }
    }
}
