using HospedagemHotelBootcampDIO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Emanuel", "Dos Santos Paz");
        Pessoa p2 = new Pessoa("Fabiana", "Costa dos Santos");
        Pessoa p3 = new Pessoa("Emerson", "Cidade Paz");

        List<Pessoa> listaPessoa = new List<Pessoa>();
        listaPessoa.Add(p1);
        listaPessoa.Add(p2);
        listaPessoa.Add(p3);

        Suite suite = new Suite("Luxo", 2, 10.00M);
        Reserva reserva = new Reserva(11);

        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(listaPessoa);

        int quantidadeHospede = reserva.obterQuantidadeHospede();
        decimal valorAPagar = reserva.CalcularValorDiaria();
    
        Console.WriteLine($"Quantidade de Hospede: {quantidadeHospede}, Valor Total: {valorAPagar}");
    }
}