namespace FiapFood.Models
{
    public class LojaResponse
    {

        public int LojaId { get; set; }

        public string LojaName { get; set; }

        public string Logotipo { get; set; }

        public string Tipo { get; set; }

        public string Endereço { get; set; }

        public double ValorFrete { get; set; }

        public LojaResponse()
        {
        }

        public LojaResponse(int lojaId, string lojaName, string logotipo, string tipo, string endereço, double valorFrete)
        {
            LojaId = lojaId;
            LojaName = lojaName;
            Logotipo = logotipo;
            Tipo = tipo;
            Endereço = endereço;
            ValorFrete = valorFrete;
        }
    }
}
