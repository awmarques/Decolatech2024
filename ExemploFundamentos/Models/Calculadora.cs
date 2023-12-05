using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar (int x, int y)
        {
            int soma = x+y;
            Console.WriteLine($"{x}+{y}:{soma}");
        }
        public void Subtrair (int x, int y)
        {
            int sutracao = x-y;
            Console.WriteLine($"{x}-{y}:{sutracao}");
        }
        public void Dividir (int x, int y)
        {
            int divisao = x/y;
            Console.WriteLine($"{x}/{y}:{divisao}");
        }
        public void Multiplicar (int x, int y)
        {
            int multriplicacao = x*y;
            Console.WriteLine($"{x}*{y}:{multriplicacao}");
        }

        public void Potencia (int x, int y)
        {
            double resultado = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y}:{resultado}");
        }
        public void Raiz (int numero)
        {
            double resultado = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} é:{resultado}");
        }

        public void Seno (double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno,4)}");
        }
        
        public void Coseno  (double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno,4)}");
        }

        public void Tangente  (double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente,4)}");
        }
    }
}