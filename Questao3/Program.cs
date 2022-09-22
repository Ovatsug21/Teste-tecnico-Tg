using Newtonsoft.Json;

public class Questao3
{
    public static void Main()
    {
        double vMenor = 0, vMaior = 0, soma = 0, media;
        int dMenor = 0, dMaior = 0, diasFat = 0, dCont = 0;

        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dados.json");
        var dados = JsonConvert.DeserializeObject<List<Dia>>(json);

        List<Dia> dias = new List<Dia>(dados);

        //Percorrendo os valores
        foreach (Dia dia in dias)
        {
            // Inicializando os valores das variáveis no dia 1, para poder comparar com os dias seguintes.
            if (dia.Num == 1 && dia.Valor != 0)
            {
                dMaior = dia.Num;
                dMenor = dia.Num;
                vMenor = dia.Valor;
                vMaior = dia.Valor;
            }

            //Ignorando os dias sem faturamento - Obtendo os valores para calculo da média, e obtendo o maior e menor valor.
            if (dia.Valor != 0)
            {

                diasFat++;
                soma = soma + dia.Valor;

                if (dia.Valor < vMenor)
                {
                    vMenor = dia.Valor;
                    dMenor = dia.Num;
                }

                if (dia.Valor > vMaior)
                {
                    vMaior = dia.Valor;
                    dMaior = dia.Num;
                }
            }

        }

        //Calculo da média
        media = soma / diasFat;

        //Com a média total calculada, percorrendo novamente os valores para obter o número de dias em que o faturamento superou a média mensal
        foreach (Dia dia in dias)
        {
            if (dia.Valor > media)
            {
                dCont++;
            }
        }

        Console.WriteLine($"O menor valor de faturamento foi de R$ {vMenor}, e ocorreu no dia {dMenor}");
        Console.WriteLine($"\nO maior valor de faturamento foi de R$ {vMaior}, e ocorreu no dia {dMaior}");
        Console.WriteLine($"\nO valor de faturamento foi superior a média mensal de R$ {media}, em {dCont} dia(s) do mês.");

    }

    public class Dia
    {
        [JsonProperty("dia")]
        public int Num { get; set; }

        [JsonProperty("valor")]
        public double Valor { get; set; }

        public Dia(int num, double valor)
        {
            this.Num = num;
            this.Valor = valor;
        }
    }
}