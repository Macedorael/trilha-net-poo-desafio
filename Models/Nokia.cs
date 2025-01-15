using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
            // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria) 
        {
            
        }

        public string nomeApp { get; set; }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na Nokia...");
        }
    }
    
}