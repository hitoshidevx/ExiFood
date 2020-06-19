namespace ExiFood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }

        public Restaurante(string _nomefantasia){
            this.NomeFantasia = _nomefantasia;
        }

        public string MostrarDados()
        {
            return $"Restaurante: {NomeFantasia}\nEndereço: {Endereco}.\n";
        }
    }
}