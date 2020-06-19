using System;
namespace ExiFood
{
    public class Pedido
    {
        public string Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        public DateTime Horario { get; set; }
        
        public string EntregarPedido(){

            Horario = DateTime.Now;

            string retorno = "Pedido Entregue com sucesso!"+"\n";
            retorno += Cliente.MostrarDados()+"\n";
            retorno += Restaurante.MostrarDados()+"\n";
            retorno += Horario;

            return retorno;
        }
    }
}