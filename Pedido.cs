namespace ExiFood
{
    public class Pedido
    {
        public string Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago = true;
        public string EntregarPedido(string _itens, string _formadepgto)
        {
            if(PedidoPago == true){
                return $"{Restaurante} está trazendo {Itens} para {Cliente}";
            }
            return $"{_itens} não entregue. Ocorreu um erro durante o pagamento.";
        }
    }
}