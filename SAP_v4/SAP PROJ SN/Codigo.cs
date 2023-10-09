public class Código : Desenho
{

    private string modelo;

	public Código()
	{
		modelo = DefinirModelo();
	}

    private static string DefinirModelo()
    {   
        while(true)
        {
            Console.Write(" DIGITE O CÓDIGO DO PRODUTO : ");
            string input = Console.ReadLine();

            if (input.Length < 2 || input.Contains(" "))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! O CÓDIGO DO PRODUTO DEVE CONTER NO MÍNIMO 2 CARACTERES.");
                Console.WriteLine();
                Console.ResetColor();
                continue;
            }

            string prefixoCodigo = (input.ToUpper().Substring(0, 2).ToString());
            Desenhar();
            return prefixoCodigo;
        }
        
    }

    public string PublicModelo
    {
        get
        {
            return modelo;
        }
        private set
        {
            modelo = value;
        }
    }
}
