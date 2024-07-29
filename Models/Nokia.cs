using System.ComponentModel;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        // Método construtor que exige vários parâmetros para permitir a criação da instância
        {
            Console.WriteLine ("O Nokia modelo {0} foi criado com o numero {1}, tendo a IMEI {2} e {3} de memória, ", modelo, numero, imei, memoria);
        }
            // TODO: Sobrescrever o método "InstalarAplicativo"
        
            public override void InstalarAplicativo(string nomeApp)
            {
                Console.WriteLine("Aplicativo {0} instalado no Nokia", nomeApp);
            }
    }
}

