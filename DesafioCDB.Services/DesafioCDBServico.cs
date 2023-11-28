using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioCDB.Domain;

namespace DesafioCDB.Servicos
{
    public class DesafioCDBServico : IDesafioCDBServico
    {
        private readonly ICalcCDBServico _calcCDBServico;

        private double ValorTB { get; set; }

        private double ValorCDI { get; set; }

        public DesafioCDBServico(ICalcCDBServico calcCDBServico)
        {
            ValorTB = 108;
            ValorCDI = 0.9;
            this._calcCDBServico = calcCDBServico;
        }

        public DesafioCDBEntidades RetornarEstimativaCalculoCDB(double valorInicial, int qtdMeses)
        {
            var percentualPago = _calcCDBServico.CalcularValorPagoSobreCDI(ValorTB, ValorCDI);

            var percentualImpostoDeRenda = _calcCDBServico.RetornarTabelaIR(qtdMeses);

            var valorFinal = _calcCDBServico.CalcularValorInicial(qtdMeses, percentualPago, valorInicial);

            var valorImpostoPagar = _calcCDBServico.CalcularValorDescontadoIR(valorFinal, percentualImpostoDeRenda);

            var valorLiquido = _calcCDBServico.CalcularValorFinal(valorFinal, valorImpostoPagar);

            return new DesafioCDBEntidades { ValorFinal = valorFinal, ValorInicial = valorInicial };
        }

    }

}
