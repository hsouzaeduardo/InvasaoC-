using demo_video_11;


Console.WriteLine("Digite o primeiro número:");
int numeroUsuario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
int numeroUsuario2 = Convert.ToInt32(Console.ReadLine());

int soma = Calculadora.CalcularSoma(numeroUsuario, numeroUsuario2, 30);
int subtracao = Calculadora.CalcularSubtracao(numeroUsuario, numeroUsuario2);
int multiplicacao = Calculadora.CalcularMultiplicacao(numeroUsuario, numeroUsuario2);
int divisao = Calculadora.CalcularDivisao(numeroUsuario, numeroUsuario2);

Console.WriteLine($"A soma total é: {soma}");
Console.WriteLine($"A subtração total é: {subtracao}");
Console.WriteLine($"A multiplicação total é: {multiplicacao}");
Console.WriteLine($"A divisão total é: {divisao}");


