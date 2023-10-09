public class Data : Desenho
{

    private string data;
    private string ano;
    private string mes;
    private string dia;

    public static string listaAlfabeto = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public Data()
	{
        data = DefinirData();
        ano = DefinirAno(PublicData);
        mes = DefinirMes(PublicData);
        dia = DefinirDia(PublicData);
    } 

    public static string ConverterAlpnum(int valor)
    {
        return listaAlfabeto.Substring(valor,1);      
    }

    private string DefinirData()
    {
        while (true)
        {
            Console.Write(" DIGITE UMA DATA ( DD/MM/AA ) : ");
            string input = Console.ReadLine();

                if (input.Length != 6 || !int.TryParse(input, out int privateData))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("ERRO!!! A DATA DEVE CONTER UMA SEQUÊNCIA DE 6 NÚMEROS.");
                Console.ResetColor();
                continue;
            }

            if (int.Parse(input.Substring(0,2)) > 31 || int.Parse(input.Substring(0, 2)) == 00)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("ERRO!!! O DIA DA DATA É INVÁLIDO.");
                Console.ResetColor();
                continue;
            }

            if (int.Parse(input.Substring(2, 2)) > 12 || input.Substring(2, 2) == "00")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("ERRO!!! O MÊS DA DATA É INVÁLIDO.");
                Console.ResetColor();
                continue;
            }

            string data = privateData.ToString("D6");
            Desenhar();
            return data;
        }
    }

    private string DefinirAno(string data)
    {
        string ano = data.Substring(4, 2).ToString();
        return ano;
    }

    private string DefinirMes(string data)
    {
        string mes = data.Substring(2, 2).ToString();
        if (int.Parse(mes) > 9)
        {
            string prefixoMes = ConverterAlpnum((int.Parse(mes) - 9));
            return prefixoMes;
        }
        else
        {
            return mes.Substring(1, 1);
        }    
    }

    private string DefinirDia(string data)
    {
        string dia = data.Substring(0, 2).ToString();
        if (int.Parse(dia) > 9)
        {
            string prefixoDia = ConverterAlpnum((int.Parse(dia) - 9));
            return prefixoDia;
        }
        else
        {
            return dia.Substring(1, 1);
        }
    }

    public string PublicData
    {
        get
        {
            return data;
        }

        set
        {
            ano = value;
        }
    }

    public string PublicAno
    {
        get
        {
            return ano;
        }

        set
        {
            ano = value;
        }
    }

    public string PublicMes
    {
        get
        {
            return mes;
        }

        set
        {
            ano = value;
        }
    }

    public string PublicDia
    {
        get
        {
            return dia;
        }

        set
        {
            ano = value;
        }
    }

}
