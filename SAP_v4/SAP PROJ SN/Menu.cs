public class Menu : Desenho
{

    public Menu()
	{
        

    }

    public static void PublicMenuInicial()
    {
        MenuInicial();
    }

    private static void MenuInicial()
    {
        Desenhar();
        Console.WriteLine($"{Espaços(21)}GERADOR DE NÚMERO DE SÉRIE PADRÃO SAP");
        Desenhar();
    }

}
