public class Hora : Desenho
{

    private string hora;

    public Hora()
    {
        hora = DefinirHora();
    }

    public static string DefinirHora()
    {
        while (true)
        {
            Console.Write(" DIGITE O HORÁRIO : ");
            string input = Console.ReadLine();

            if (input.Length != 2 || !int.TryParse(input, out int privateData))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! O HORÁRIO DEVE CONTER 2 NÚMEROS.");
                Console.WriteLine();
                Console.ResetColor();
                continue;
            }

            if (!"012".Contains(input.Substring(0, 1)) || int.Parse(input) > 24)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! DIGITE UM HORÁRIO VÁLIDO.");
                Console.WriteLine();
                Console.ResetColor();
                continue;
            }

            string prefixoHora = input.ToString();
            Desenhar();
            return prefixoHora;
        }         
    }

    public string PublicHora
    {
        get
        {
            return hora;
        }

        set
        {
            hora = value;
        }
    }
}