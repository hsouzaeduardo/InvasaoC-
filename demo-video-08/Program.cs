// See https://aka.ms/new-console-template for more information

DateTime startTime =new DateTime(1981,3,3);
//int idade = DateTime.Now.Year - startTime.Year;
int idade = Convert.ToInt32(Console.ReadLine());

//Quando não tiver chaves no IF só a primeira linha que vale.
// if(idade >= 18)
//     Console.WriteLine("Maior de idade");

// if(idade >= 18)
//     Console.WriteLine("Maior de idade");
// else
//     Console.WriteLine("Menor de idade");

if(idade < 18)
    Console.WriteLine("Menor de idade não pode trabalhar no BAR");
else if(idade >= 65){
    Console.WriteLine("Não pode trabalhar no BAR");
}
else
    Console.WriteLine("Opa pode ir para o RH");

Console.WriteLine($"A idade é: {idade.ToString()}");


    
