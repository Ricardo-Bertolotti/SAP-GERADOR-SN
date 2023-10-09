class Program : Menu
{

    static void Main(string[] args)
    {

        PublicMenuInicial();

        Centro Centro = new();

        Código Modelo = new();

        Data Data = new();

        Hora Hora = new();

        Turno Turno = new();

        GeradorSN GerarSN = new();

        GerarSN.GeradorSAP
            (
                GerarSN.PublicInicio,
                GerarSN.PublicFinal,
                Centro.PublicCentro,
                Modelo.PublicModelo,
                Data.PublicAno,
                Data.PublicMes,
                Data.PublicDia,
                Hora.PublicHora,
                Turno.PublicTurno
            );

        ManipularArquivoDeTexto.PublicGerarTXT(GerarSN.PublicListaSNs);

        ManipularArquivoDeTexto.PublicAbrirTXT();

    }
}
