
using CanilBH;

namespace CamilBH;


public class Program
{
  

    public static void Main()
    {

        Console.WriteLine("Informe os dados: <data> <quantidades de caes pequenos> <quantidade de caes grandes> ");
        Console.Write("> ");
        string? inputStr = Console.ReadLine();

        if (string.IsNullOrEmpty(inputStr))
        {
            Console.WriteLine("Dados invalidos");
            return;
        }

        var inputs = inputStr.Split(' ');

        if (inputs.Length != 3)
        {
            Console.WriteLine("Dados invalido");
            return;
        }

        DateTime data;
        int qtdCaesPequeno;
        int qtdCaesGrandes;

        bool dataValida = DateTime.TryParse(inputs[0], out data);

        if (dataValida == false)
        {
            Console.WriteLine("Data informda invalida");
            return ;
        }

        bool caesPequenosValidos = int.TryParse(inputs[1], out qtdCaesPequeno);
        if (caesPequenosValidos == false)
        {
            Console.WriteLine("Quantidade de cães pequenos informado invalida");
            return;
        }

        bool caesGrandesValidos = int.TryParse(inputs[2], out qtdCaesGrandes);
        if (caesGrandesValidos == false)
        {
            Console.WriteLine("Quantidade de cães grande informado invalido");
            return;
        }

        Petshop[] petshops = new Petshop[]
        {
            new MeuCaninoFeliz(),
            new VaiRex(),
            new ChowChawgas()
        };


        string nomeMenorPetshop = "";
        decimal menorTotalBanho = decimal.MaxValue;
        decimal menorDistancia = 0;
        decimal valorTotalBanho = 0;

        foreach (Petshop petshop in petshops)
        {
            bool finalDeSenana = FinalDeSemana(data.DayOfWeek);

            decimal totalPortePequeno = 0;
            if (finalDeSenana)            
                totalPortePequeno = qtdCaesPequeno * petshop.ValorBanhoFdsPortePequeno;
            
            else            
                totalPortePequeno = qtdCaesPequeno * petshop.ValorBanhoDiaSemanaPortePequeno;
            
            decimal totalPorteGrande = 0;
            if (finalDeSenana)            
                totalPorteGrande = qtdCaesGrandes * petshop.ValorBanhoFdsPorteGrande;
            
            else            
                totalPorteGrande = qtdCaesGrandes * petshop.ValorBanhoDiaSemanaPorteGrande;
            

            valorTotalBanho = totalPorteGrande + totalPortePequeno;

            if (valorTotalBanho == menorTotalBanho)
            {
                if (petshop.DistanciaCanil < menorDistancia)
                {
                    nomeMenorPetshop = petshop.nome;
                    menorTotalBanho = valorTotalBanho;
                    menorDistancia = petshop.DistanciaCanil;
                }
            }
            else if (valorTotalBanho < menorTotalBanho)
            {
                menorTotalBanho = valorTotalBanho;
                nomeMenorPetshop = petshop.nome;
                menorDistancia = petshop.DistanciaCanil;
            }
        }

        string output = $"O petshop com maneor valor é: {nomeMenorPetshop} - O valor é:  {menorTotalBanho} ";
        Console.WriteLine(output);
    
    }
    public static bool FinalDeSemana(DayOfWeek day)
    {
        return day == DayOfWeek.Sunday || day == DayOfWeek.Saturday;
    }


}