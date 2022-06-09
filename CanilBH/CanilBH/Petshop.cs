using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanilBH
{
    public class Petshop
    {
        public string nome = "";
        public decimal DistanciaCanil;

        public decimal ValorBanhoDiaSemanaPortePequeno;
        public decimal ValorBanhoFdsPortePequeno;
        public decimal ValorBanhoDiaSemanaPorteGrande;
        public decimal ValorBanhoFdsPorteGrande;
    }

    public class MeuCaninoFeliz : Petshop
    {
        public MeuCaninoFeliz()
        {
            nome = "Meu Canino Feliz";
            DistanciaCanil = 2;

            ValorBanhoDiaSemanaPortePequeno = 20;
            ValorBanhoDiaSemanaPorteGrande = 40;

            ValorBanhoFdsPortePequeno = ValorBanhoDiaSemanaPortePequeno * 1.2m;
            ValorBanhoFdsPorteGrande = ValorBanhoDiaSemanaPorteGrande * 1.2m;

        }
    }

    public class VaiRex : Petshop
    {
        public VaiRex()
        {
            nome = "Vai Rex";
            DistanciaCanil = 1.7m;

            ValorBanhoDiaSemanaPortePequeno = 15;
            ValorBanhoDiaSemanaPorteGrande = 50;

            ValorBanhoFdsPortePequeno = 20;
            ValorBanhoFdsPorteGrande = 55;
        }

    }

    public class ChowChawgas : Petshop
    {

        public ChowChawgas()
        {

            nome = "ChowChawgas";
            DistanciaCanil = 0.8m;

            ValorBanhoDiaSemanaPortePequeno = 30;
            ValorBanhoDiaSemanaPorteGrande = 45;
            ValorBanhoFdsPortePequeno = 30;
            ValorBanhoFdsPorteGrande = 45;

        }
    }

}
