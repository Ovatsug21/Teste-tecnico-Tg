﻿// Resp: 91
class Questao1
{
    public static void Main()
    {
        int indice = 13, soma = 0, k = 0;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        Console.WriteLine("O Valor da variável soma é: " + soma);
    }
}

