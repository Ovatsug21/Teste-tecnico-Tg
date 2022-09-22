public class Questao4
{
    public static void Main()
    {
        List<Estado> estados = new List<Estado>();

        estados.Add(new Estado("SP", 67836.43));
        estados.Add(new Estado("RJ", 36678.66));
        estados.Add(new Estado("MG", 29229.88));
        estados.Add(new Estado("ES", 27165.48));
        estados.Add(new Estado("Outros", 19849.53));

        double total = 0;

        // Soma dos valores por estado, para obter o faturamento total
        foreach (Estado est in estados)
        {
            total = total + est.Valor;
        }

        Console.WriteLine("Percentual de faturamento por estado:\n");

        // Calculo e Exibição dos percentuais de cada estado
        foreach (Estado est in estados)
        {
            Console.WriteLine(est.Nome + ": " + Math.Round((100 / total) * est.Valor, 2) + "%");
        }
    }

    public class Estado
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Estado(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}