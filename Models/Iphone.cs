namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoriaInterna) : base(numero, modelo, imei, memoriaInterna)
        {
        }

        public override void InstalarAplicativo(string app)
        {
            System.Console.WriteLine($"Instalando {app} no iPhone...");
        }
    }
}