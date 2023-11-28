using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCDB.Servicos
{
    public class CalcCDBServico : ICalcCDBServico
    {
        public double CalcularValorPagoSobreCDI(double valorTB, double valorCDI)
        {
            double valorMultiplicaPercentual = (valorTB * valorCDI) / 10000;
            return valorMultiplicaPercentual;
        }

        public double RetornarTabelaIR(int qtdMeses)
        {
            if (qtdMeses <= 6)
            {
                return 22.5;
            }

            if (qtdMeses > 6 && qtdMeses <= 12)
            {
                return 20;
            }

            if (qtdMeses > 12 && qtdMeses <= 24)
            {
                return 17.5;
            }

            return 15;

        }

        public double CalcularValorInicial(int qtdMeses, double percentualPagar, double valorInicial)
        {
            double valorMesAcumulado = valorInicial;

            for (int i = 0; i < qtdMeses; i++)
            {
                valorMesAcumulado = (Math.Round(valorMesAcumulado * (1 + percentualPagar), 2, MidpointRounding.ToEven));
            }

            return valorMesAcumulado;
        }

        public double CalcularValorFinal(double valorBruto, double valorImpostoRenda)
        {
            return Math.Round(valorBruto - valorImpostoRenda, 2, MidpointRounding.ToEven);
        }

        public double CalcularValorDescontadoIR(double valorFinal, double percentualImpostoDeRenda)
        {
            return Math.Round(valorFinal * percentualImpostoDeRenda / 100, 2, MidpointRounding.ToEven);
        }

    }

}
