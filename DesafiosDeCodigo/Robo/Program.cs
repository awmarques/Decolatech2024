﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection.Metadata;
using TestesDesafiosDeCodigo.Robo;

      Console.WriteLine("Digite a velocidade minima");
      int vmin = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Digite a velocidade maxima");
      int vmax = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Digite uma sequencia de comandos");
      string comandos = Console.ReadLine();
      
      Robo robo = new Robo (vmin,vmax);
      
      foreach (char comando in comandos)
      {
        if (comando == 'A')
        {
          robo.Acelerar();  
        } 
        else if (comando == 'D')
        {
          robo.Desacelerar();
        } else
        {
          Console.WriteLine($"Comando invalido: {comando}");
        }
      }
      Console.WriteLine(robo.VelocidadeAtual);