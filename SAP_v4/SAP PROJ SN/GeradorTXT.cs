using System;
using System.Diagnostics;
using System.IO;

public class ManipularArquivoDeTexto : Desenho
{
	public ManipularArquivoDeTexto()
	{

	}

	public static void PublicGerarTXT(List<string> PublicListaSNs)
    {
        GerarTXT(PublicListaSNs);
    }

    public static void PublicAbrirTXT()
    {
        ManipularArquivoDeTexto.AbrirTXT();
    }

    private static void GerarTXT(List<string> PublicListaSNs)
	{

        Console.Clear();
        Desenhar();
        Console.WriteLine($"{Espaços(15)}GERANDO ARQUIVO DE TEXTO COM OS NÚMEROS DE SÉRIE... \n");
        Console.WriteLine($"{Espaços(22)}DE {PublicListaSNs.First()} A {PublicListaSNs.Last()}");
        Desenhar();

        string caminhoDoArquivo = Environment.CurrentDirectory;
        string nomeDoArquivo = "NÚMEROS DE SÉRIE ( SAP ).txt";
        string caminhoCompleto = @$"{caminhoDoArquivo}\{nomeDoArquivo}";

        try
        {

            if (File.Exists(caminhoCompleto))
            {
                File.WriteAllText(caminhoCompleto, string.Empty);
            }

            using (StreamWriter writer = new StreamWriter(caminhoCompleto))
            {
                foreach (string SN in PublicListaSNs)
                {
                    writer.WriteLine(SN);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" ARQUIVO GERADO COM SUCESSO!!!     TOTAL DE NÚMEROS DE SÉRIE : ( {PublicListaSNs.Count()} )\n");
            Console.ResetColor();
            Console.WriteLine(@$" CAMINHO DO ARQUIVO : {caminhoCompleto}");
        }

        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"OCORREU UM ERRO: {ex.Message}");
            Console.ResetColor();
        }
    }

    private static void AbrirTXT()
    {
        string caminhoDoArquivo = Environment.CurrentDirectory;
        string nomeDoArquivo = "NÚMEROS DE SÉRIE ( SAP ).txt";
        string caminhoCompleto = @$"{caminhoDoArquivo}\{nomeDoArquivo}";

        if (System.IO.File.Exists(caminhoCompleto))
        {
            try
            {
                Process.Start("notepad.exe", caminhoCompleto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OCORREU UM ERRO AO ABRIR O ARQUIVO : {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"O ARQUIVO NÃO FOI ENCONTRADO EM : {caminhoCompleto}");
        }

        Desenhar();
        PublicPausar();
    }

}
