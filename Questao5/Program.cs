using System.Text;

public class Questao5
{

    public static void Main()
    {
        Console.WriteLine("Digite quaisquer caracteres para terem a ordem invertida: ");
        string s = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        for (int i = s.Length - 1; i >= 0;)
        {
            sb.Append(s[i]);
            i--;
        }
        Console.WriteLine($"\nO texto com os caracteres invertidos ficou assim: {sb}");
    }
}
