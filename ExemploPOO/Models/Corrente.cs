using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void CreditarConta(decimal valor)
        {
            saldo += valor;
        }
    }
}