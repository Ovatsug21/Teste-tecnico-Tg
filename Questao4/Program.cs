public class Questao4
{
    public static void Main()
    {
        double
            SP = 67836.43, //37,52
            RJ = 36678.66,
            MG = 29229.88,
            ES = 27165.48,
            Outros = 19849.53,
            total = SP + RJ + MG + ES + Outros;

        Console.WriteLine("Faturamento no estado de SP: " + (100 / total) * SP);
        Console.WriteLine("Faturamento no estado do RJ: " + (100 / total) * RJ);
        Console.WriteLine("Faturamento no estado de MG: " + (100 / total) * MG);
        Console.WriteLine("Faturamento no estado do ES: " + (100 / total) * ES);
        Console.WriteLine("Faturamento nos Outros estados: " + (100 / total) * Outros);
    }
}