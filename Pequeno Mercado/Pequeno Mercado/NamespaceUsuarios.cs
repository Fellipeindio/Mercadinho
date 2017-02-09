namespace NamespaceUsuarios
{
    public class Cliente
    {
        public string NomeComprador { get; set; }
        public string ValorCompra { get; set; }

        public Cliente(string nome = "", string valorDaCompra = "")
        {
            NomeComprador = nome;
            ValorCompra = valorDaCompra;
        }
    }
}
