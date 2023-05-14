int[] arr1 = new int[5];
arr1[0] = 10;
arr1[1] = 20;
arr1[2] = 30;
arr1[3] = 40;
arr1[4] = 50;

// for (int i = 0; i < arr1.Length; i++)
// {
//     Console.WriteLine("Primeiro Array: {0}", arr1[i]);
// }

int[] arr2 = new int[5];
Array.Copy(arr1, arr2, arr1.Length);
Array.Reverse(arr2);

// foreach(int i in arr2)
// {
//     Console.WriteLine("Segundo Array: {0}", i);
// }

string[] arr3 = new string[5] { "John", "James", "Sara", "Pam", "Henrique" };

Array.Sort(arr3);

foreach(string i in arr3)
{
    Console.WriteLine("Nomes no Array: {0}", i);
}

string nomeBuscar = Console.ReadLine();
int indexFind = Array.IndexOf(arr3, nomeBuscar);

if(indexFind == -1)
    Console.WriteLine("Nome não encontrado");
else
    Console.WriteLine("Nome procurado: {0} - Posição: {1}", nomeBuscar, indexFind);



// int arrIndex = int.Parse(Console.ReadLine());
// int[] arr4 = new int[arrIndex];

// for (int i = 0; i < arrIndex; i++)
// {
//     arr4[i] = int.Parse(Console.ReadLine());
// }

// foreach(int i in arr4)
// {
//     Console.WriteLine("Array: {0}", i);
// }