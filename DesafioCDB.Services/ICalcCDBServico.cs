using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCDB.Servicos
{
    public interface ICalcCDBServico
    {
        double CalcularValorPagoSobreCDI(double ValorTB, double ValorCDI);

        double RetornarTabelaIR(int qtdMeses);

        double CalcularValorInicial(int quantidadeMeses, double percentualPagar, double valorInicial);

        double CalcularValorFinal(double valorBruto, double valorImpostoRenda);

        double CalcularValorDescontadoIR(double valorFinal, double percentualImpostoDeRenda);

    }

}
