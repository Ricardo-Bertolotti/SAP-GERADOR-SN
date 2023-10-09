using System;
using System.Diagnostics;
using System.IO;

public class GeradorSN : Desenho
{

    private int inicio;
    private int final;

    private List<string> ListaSNs = new List<string>();

    public GeradorSN()
	{
        inicio = DefinirInicio();
        final = DefinirFinal();
    }  

    public int DefinirInicio()
	{       
        while (true)
        {
            Console.Write(" DIGITE O VALOR INICIAL : ");
            string inicio = (Console.ReadLine());

            if (!int.TryParse(inicio, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! VALOR INICIAL INVÁLIDO.");
                Console.WriteLine();
                Console.ResetColor();
                continue;
            }
            
            if (int.Parse(inicio) >= 0 && int.Parse(inicio) <= 99998)
            {
                Desenhar();
                return int.Parse(inicio);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERRO!!! VALOR INICIAL FORA DO RANGE.");
            Console.WriteLine();
            Console.ResetColor();
        }            
    }

    public int DefinirFinal()
    {
        while (true)
        {
            Console.Write(" DIGITE O VALOR FINAL : ");
            string final = (Console.ReadLine());


            if (!int.TryParse(final, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! VALOR FINAL INVÁLIDO.");
                Console.WriteLine();
                Console.ResetColor();
                continue;
            }

            if (int.Parse(final) > PublicInicio && int.Parse(final) <= 99999)
            {
                Desenhar();
                return int.Parse(final);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERRO!!! VALOR FINAL FORA DO RANGE.");
            Console.WriteLine();
            Console.ResetColor();
        }
    }

    public void GeradorSAP(int inicio, int final, string centro, string modelo, string ano, string mes, string dia, string hora, int turno)
	{

        while ( inicio <= final )
        {
            string stringInicio = inicio.ToString();
            int quantidaDeZeros = (5 - stringInicio.Length);
            string zeros = new string('0', quantidaDeZeros);

            string sequência = $"{centro}{modelo}{ano}{mes}{dia}{hora}{turno}{zeros}{inicio}";

            ListaSNs.Add(sequência);
            inicio++;
        }      

    }

    /*
    public void GerarTXT(List<string> ListaSNs)
    {

        Console.Clear();
        Desenhar();
        Console.WriteLine($"{Espaços(15)}GERANDO ARQUIVO DE TEXTO COM OS NÚMEROS DE SÉRIE... \n");
        Console.WriteLine($"{Espaços(22)}DE {ListaSNs.First()} A {ListaSNs.Last()}");
        

        string diretorioAtual = Environment.CurrentDirectory;
        string nomeDoArquivo = "NÚMEROS DE SÉRIE ( SAP ).txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(nomeDoArquivo))
            {
                foreach (string SN in ListaSNs)
                {
                    writer.WriteLine(SN);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Desenhar();
            Console.WriteLine($"ARQUIVO GERADO COM SUCESSO!!!     TOTAL DE NÚMEROS DE SÉRIE : ( {ListaSNs.Count()} )\n");
            Console.WriteLine($"CAMINHO DO ARQUIVO : {diretorioAtual}\\{nomeDoArquivo}");
            Desenhar();
        }

        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERRO AO CRIAR O ARQUIVO: {nomeDoArquivo}");
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }

        AbrirTXT(diretorioAtual, nomeDoArquivo);

        Console.ResetColor();
        Console.Write("Pressione alguma tecla para encerrar o programa...   ");
        string pausa = (Console.ReadLine());
        AbrirTXT(diretorioAtual, nomeDoArquivo);
        Console.Write("Pressione alguma tecla para encerrar o programa...   ");
        string pausas = (Console.ReadLine());

    }

    public void AbrirTXT (string diretorioAtual, string nomeDoArquivo)
    {
        if (System.IO.File.Exists($"{diretorioAtual}\\{nomeDoArquivo}"))
        {
            try
            {
                //Process.Start($"{diretorioAtual}\\{nomeDoArquivo}");
                Process.Start($"\"{diretorioAtual}\\{nomeDoArquivo}\"");
                
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERRO AO ABRIR O ARQUIVO: {nomeDoArquivo}");
                Console.WriteLine($"ERRO AO ABRIR O ARQUIVO: {ex.Message}");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"O ARQUIVO {nomeDoArquivo} NÃO EXISTE NO DIRETÓRIO ATUAL.");
            Console.ResetColor();
        }

        Console.WriteLine($"\"{diretorioAtual}\\{nomeDoArquivo}\"");
    }

    */

    public int PublicInicio
    {
        get
        {
            return inicio;
        }

        set
        {
            inicio = value;
        }
    }

    public int PublicFinal
    {
        get
        {
            return final;
        }

        set
        {
            final = value;
        }
    }

    public List<string> PublicListaSNs
    {
        get 
        {
            return ListaSNs;
        }
    }
    
}
