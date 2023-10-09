public class Centro : Desenho
{

    private string centro;

    public Centro()
    {      
        centro = DefinirCentro();
    }

    private static string DefinirCentro()
    {        
        while (true)
        {       
            Console.Write(" DIGITE O CENTRO PRODUTIVO : ");
            string input = Console.ReadLine();
            if (input.Length != 4 || !int.TryParse(input, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! O CENTRO DEVE CONTER UMA SEQUÊNCIA DE 4 NÚMEROS.");
                Console.WriteLine();
                Console.ResetColor();
                continue;
            }

            string prefixoCentro = input.ToString()[0].ToString();
            Desenhar();
            return prefixoCentro;          
        }             
    }

    public string PublicCentro
    {
        get
        {
            return centro;
        }
        private set
        {
            centro = value;
        }
    }
}
