// See https://aka.ms/new-console-template for more information

//Desafio Resolvido !!!
// string message = "Hello World!!";
// string resultado = message.Substring(0, message.Length - 1);
// Console.WriteLine(resultado);
//OperadoresAritimeticos();
OperadoresAritimeticosAtribuicaoReduzida();

static void OperadoresAritimeticos()
{
    int a = 5, b = 10, c = 15, d = 20;
    Console.WriteLine("a + b = " + (a + b)); //operador de adição
    Console.WriteLine("a - b = " + (a - b)); //operador de subtração    
    Console.WriteLine("a * b = " + (a * b)); //operador de multiplicação
    Console.WriteLine("a / b = " + (a / b)); //operador de divisão
    Console.WriteLine("a % b = " + (a % b)); //operador de módulo

    Console.WriteLine("a + b * c = " + (a + b * c)); //Expressão Matematica
    Console.WriteLine("(a + b) * c = " + ((a + b) * c));//Expressão Matematica
}



static void OperadoresAritimeticosAtribuicaoReduzida()
{


    int mes = 5;
    mes += 1;
    Console.WriteLine("Mês: " + mes);
    Console.WriteLine("Mês: " + ++mes);
    //-=, *=, /=, %=
    //Console.WriteLine("Mês: " + ++mes);

    


}

