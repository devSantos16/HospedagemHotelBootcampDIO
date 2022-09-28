using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotelBootcampDIO.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospede)
        {
            if (Suite == null)
            {
                throw new Exception("Erro, a suite não foi cadastrada ainda");
            }
            else if (hospede.Count > Suite.Capacidade)
            {
                throw new Exception("Erro, não pode cadastrar doq a capacidade da suite oferece");
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
            return DiasReservados * Suite.ValorDiaria;
        }
    }
}