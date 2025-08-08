namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           
            if (true)
            {
                Hospedes = hospedes;
            }
            else
            {
              
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
          
            return 0;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor = 0;

            
            if (true)
            {
                valor = 0;
            }

            return valor;
        }
    }
}