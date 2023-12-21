using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void CreditarConta(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é: {saldo}");
        }

    }
}