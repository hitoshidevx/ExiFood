namespace ExiFood
{
    public class Pedido
    {
        public string Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }

        public Pedido(string _itens)
        {
            this.Itens = _itens;
        }
        public Pedido(string _itens, string _cliente, string _restaurante, string _formadepgto, bool _pedidopago)
        {
            this.Itens = _itens;
            this.Cliente = _cliente;
            this.Restaurante = _restaurante;
            this.FormaDePGTO = _formadepgto;
            this.PedidoPago = _pedidopago;
        }
        public string EntregarPedido()
        {
            if(PedidoPago == true){
                return "Pedido entregue com sucesso.";
            }else{
                return "Pedido não entregue. Ocorreu um erro durante o processo.";
            }
        }
    }
}