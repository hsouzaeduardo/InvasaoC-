//Passando valores para métodos 
int numero1 = 10;
int numero2 = 20;
//Passando valores para métodos
SomarNumero(numero1, numero2);

int numero1Ref = 10;
int numero2Ref = 20;
//Passando valores para métodos por referencia 
Console.WriteLine("Resultado da Soma no retorno do metódo: {0}", SomarNumeroComRef(numero1Ref, ref numero2Ref));
Console.WriteLine($"Resultado do valor atribuido por referencia {numero2Ref}");

////Usando a palavra-chave out
int numero1Out = 10;
int numero2Out = 20;
Console.WriteLine($"Resultado do calculo do metodo {SomarNumeroComOut(numero1Out, out numero2Out)}");
Console.WriteLine($"Resultado atribuido a variavel de output {numero2Out}");

int numero2In = 20;
ParametroComIn(numero2In);

//Passando objetos para métodos
static void SomarNumero(int numero1, int numero2)
{
    int resultado = numero1 + numero2;
    Console.WriteLine($"Resultado da soma {numero1} + {numero2}: " + resultado);
}

//Passando Parâmetros por Referência
static int SomarNumeroComRef(int numero1, ref int numero2)
{
    int resultado = numero1 + numero2;
    numero2 = 10000;
    return resultado;
}

//Usando a palavra-chave out
static int SomarNumeroComOut(int numero1, out int numero2)
{
    int resultado = numero1 * 10;
    numero2 = 30;
    return resultado;
}

static void ParametroComIn(in int numero2)
{
    //numero2 = 30;
    int resultado = numero2 * 30;
    Console.WriteLine($"Resultado do calculo do metodo {resultado}");
}



