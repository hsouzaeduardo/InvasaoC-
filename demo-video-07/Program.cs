int idade = 17;

bool a = (idade == 41);

Console.WriteLine("A idade é igual a 41? " + a);  

bool b = (idade != 41);
Console.WriteLine("A idade é diferente de 41? " + b);

bool c  = (idade > 41); 
Console.WriteLine("A idade é maior que 41? " + c);

bool d = (idade < 41);
Console.WriteLine("A idade é menor que 41? " + d);

bool e = (idade >= 18) && (idade <= 50);
Console.WriteLine("A idade é maior que 18 e menor que 50? " + e);

bool f = (idade >= 18) || (idade <= 50);
Console.WriteLine("A idade é maior que 18 ou menor que 50? " + f);