﻿using Calculadora.Services;

CalculadoraImplementacao c = new CalculadoraImplementacao();

// int num1 = 5;
// int num2 = 10;

// Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
int num = 10;
Console.WriteLine($"O número é par? {c.EhPar(num)}");