using System;

namespace ExiFood
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Restaurante mc = new Restaurante("McDonalds");
            mc.Endereco = "Av. Paulista, 1821";
            Console.WriteLine(mc.MostrarDados());

            Cliente hitoshi = new Cliente("Hitoshi");
            hitoshi.EnderecoAtual = "hell, 666";
            Console.WriteLine(hitoshi.MostrarDados());

            Pedido strogonoff = new Pedido();

            strogonoff.Restaurante = mc;
            strogonoff.Cliente = hitoshi;

            Console.WriteLine(strogonoff.EntregarPedido());
        }
    }
}
