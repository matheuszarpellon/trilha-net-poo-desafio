namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int MemoriaInterna { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoriaInterna)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            MemoriaInterna = memoriaInterna;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}