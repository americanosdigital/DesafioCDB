using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioCDB.Domain;

namespace DesafioCDB.Servicos
{
    public interface IDesafioCDBServico
    {
        DesafioCDBEntidades RetornarEstimativaCalculoCDB(double valorInicial, int qtdMeses);
    }
}
