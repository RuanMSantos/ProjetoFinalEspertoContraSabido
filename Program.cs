Console.Clear();

int alimentosDistribuidos = 0;

Console.WriteLine("--- Esperto Contra Sabido ---\n");

Console.Write("Quantos alimentos serão distribuídos? ");
string AlimentosTexto = Console.ReadLine()!;

if (!int.TryParse(AlimentosTexto, out alimentosDistribuidos))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Impossível converter em número.");
    Console.ResetColor();
    return;
}

if (alimentosDistribuidos <= 0) 
{
    return;
}

Console.WriteLine();

int alimentosRestantes = alimentosDistribuidos;
int raposinha = 0, picaPau = 0;

int AlimentoParaVoce = 0, AlimentoParaMim = 0;

while (alimentosRestantes > 0)
{
    AlimentoParaVoce++;
    picaPau += 1;
    alimentosRestantes -= 1;

    Console.Write($"{picaPau} para você. ");

    AlimentoParaMim = 0;

    while (alimentosRestantes > 0 && AlimentoParaMim < AlimentoParaVoce)
    {
        AlimentoParaMim++;
        raposinha += 1;
        alimentosRestantes -= 1;

        Console.Write($"{AlimentoParaMim}");

        if (alimentosRestantes > 0 && AlimentoParaMim < AlimentoParaVoce)
        {
            Console.Write(",");
        }

        Console.Write(" ");
    }

    if (AlimentoParaMim > 0)
    {
        Console.WriteLine("para mim.");
    }
}

if (AlimentoParaMim == 0)
{
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Pica-pau recebeu ");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"{picaPau} alimento(s).");
Console.ResetColor();

Console.Write("Raposinha recebeu ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"{raposinha} alimento(s).");
Console.ResetColor();