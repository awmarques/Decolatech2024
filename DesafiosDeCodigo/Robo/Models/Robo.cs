using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesDesafiosDeCodigo.Robo
{
    public class Robo
    {
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }
    
    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        } else
        {
          Console.WriteLine($"Velocidade maxima atingida: {VelocidadeAtual}");
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        } else
        {
          Console.WriteLine("Velocidade minima atingida: {VelocidadeAtual}");
        }
    }
    }
}