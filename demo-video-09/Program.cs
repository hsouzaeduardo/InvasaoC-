
float f = float.NaN;

switch (f)
{
    case 1.0f:
        Console.WriteLine("Hello World!");
        break;
    case float.NaN:
        Console.WriteLine("Isso não é número!");
        break;
    default :
        Console.WriteLine("Float!");
        break;
}

Console.WriteLine(Temperatura(13));  // output: Muito Frio
Console.WriteLine(Temperatura(double.NaN));  // output: Não é um número
Console.WriteLine(Temperatura(2.4));  // output: Aceitavel para o ambiente

static string Temperatura(double graus) => graus switch
{
    < -4.0 => "Muito Frio",
    > 30.0 => "Muito Quente",
    double.NaN => "Não é um número",
    _ => "Aceitavel para o ambiente",
};

Console.WriteLine(RetornarEstacaoDoAno(new DateTime(2021, 3, 14)));  // output: Outono
Console.WriteLine(RetornarEstacaoDoAno(new DateTime(2021, 7, 19)));  // output: Inverno
Console.WriteLine(RetornarEstacaoDoAno(new DateTime(2021, 2, 17)));  // output: Verão

static string RetornarEstacaoDoAno(DateTime date) => date.Month switch
{
    >= 3 and < 6 => "Outono",
    >= 6 and < 9 => "Inverno",
    >= 9 and < 12 => "Primavera",
    12 or (>= 1 and < 3) => "Verão",
    _ => throw new ArgumentOutOfRangeException(nameof(date), $"Data com mês inesperado: {date.Month}."),
};
