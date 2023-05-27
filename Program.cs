Console.WriteLine("--- Esperto Contra Sabido ---\n");

Console.Write("Quantos alimentos serão distribuídos? ");

int totalAlimentos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int restantes = totalAlimentos;
int picapau = 0, raposinha = 0;
int contadorParaMim = 0, contadorParaVoce = 0;

while(restantes > 0)
{
    contadorParaVoce = contadorParaVoce + 1;
    picapau = picapau + 1;
    restantes = restantes - 1;

    Console.Write($"{picapau} para voce. ");

    contadorParaMim = 0;

    while(restantes > 0 && contadorParaMim < contadorParaVoce)
    {
        contadorParaMim = contadorParaMim + 1;
        raposinha = raposinha + 1;
        restantes = restantes - 1;

        Console.Write($"{contadorParaMim} para mim, ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Pica-pau recebeu {picapau} alimento(s)");
Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s)");