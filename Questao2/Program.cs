public class Questao2
{
    public static void Main()
    {
        //Variávies n1 e n2 recebendo os primeiros números da sequência de fibonacci
        int n1 = 0, n2 = 1, soma = 0, num;

        Console.WriteLine("Digite o número a ser conferido: ");
        try
        {
            num = int.Parse(Console.ReadLine());
            Console.Write($"{n1}, {n2}");

            //Calculo da sequência de fibonacci até chegar ou passar pelo número digitado.
            while (soma < num && soma != num)
            {
                soma = n1 + n2;
                n1 = n2;
                n2 = soma;

                Console.Write(", " + soma);
            }

            if (soma == num)
            {
                Console.WriteLine($"\n\n O número {num} pertence a sequência de fibonacci.");
            }
            else
            {
                Console.WriteLine($"\n\n O número {num} NÃO pertence a sequência de fibonacci.");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();

    }
}