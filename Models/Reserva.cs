using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotelBootcampDIO.Models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes { get; set; }
        private Suite Suite { get; set; }
        private int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospede)
        {

            if (hospede.Count > Suite.Capacidade)
            {
                throw new Exception("Erro, não pode cadastrar mais doque a capacidade da suite oferece");
            }
            else
            {
                Hospedes = hospede;
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int obterQuantidadeHospede()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados > 10)
            {
                decimal desconto = (valorDiaria * 10) / 100;
                return valorDiaria - desconto;
            }
            return valorDiaria;
        }
    }
}