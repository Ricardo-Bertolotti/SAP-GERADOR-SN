public class Turno : Desenho
{

	private int turno;

	public Turno()
	{
		turno = Definirturno();
	}

	public static int Definirturno()
	{
        while (true)
        {
            Console.Write(" DIGITE O TURNO : ");
            string input = (Console.ReadLine());

            if ((input != "1" && input != "2"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! O TURNO DEVE SER 1 OU 2.");
                Console.WriteLine();
                Console.ResetColor();
                continue;
            }

            Desenhar();
            return int.Parse(input);
        }           
    }

    public int PublicTurno
    {
        get
        {
            return turno;
        }

        set
        {
            turno = value;
        }
    }
}
