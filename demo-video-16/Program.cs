using System.Text;

string nome = "Henrique";
string sobrenome = "Souza";
nome += " Eduardo";
nome += " " + sobrenome;
Console.WriteLine(nome);

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Henrique");  
stringBuilder.Append(" Eduardo");
stringBuilder.Append(" ");
stringBuilder.Append("Souza");
console.WriteLine(stringBuilder.ToString());