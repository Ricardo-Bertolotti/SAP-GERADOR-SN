public class Desenho
{
    private static string ?espaços;

    public static void DesenharLinha(int valor)
    {
        string linha = new ('-', valor);
        Console.WriteLine(linha);
    }

    public static void Desenhar()
    {
        Console.WriteLine();
        DesenharLinha(80);
        Console.WriteLine();
    }

    private static string? PausarTerminal()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"{Espaços(5)}Terminal pausado, pressione alguma tecla para finalizar o programa...");
        return Console.ReadLine();
    }

    public static void PublicPausar()
    {
        PausarTerminal();
    }

    public static string Espaços(int valor)
    {
        espaços = new string(' ', valor);
        return espaços;
    }
}
