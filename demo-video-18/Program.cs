using demo_video_18;

List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(new Pessoa { Id = 1, Nome = "João", Idade = 18 });
pessoas.Add(new Pessoa { Id = 2, Nome = "Maria", Idade = 20 });
pessoas.Add(new Pessoa { Id = 3, Nome = "José", Idade = 25 });
pessoas.Add(new Pessoa { Id = 4, Nome = "Henrique", Idade = 30 });
pessoas.Add(new Pessoa { Id = 5, Nome = "Joana", Idade = 35 });

// foreach(Pessoa p in pessoas)
// {
//     Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);
// }

pessoas.Insert(2, new Pessoa { Id = 6, Nome = "Sara", Idade = 40 });
pessoas.Insert(0, new Pessoa { Id = 7, Nome = "Pam", Idade = 45 });
pessoas.Insert(4, new Pessoa { Id = 8, Nome = "James", Idade = 50 });

// foreach(Pessoa p in pessoas.OrderByDescending(x => x.Id))
// {
//     Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);
// }
pessoas.TrimExcess();
Console.WriteLine("Capacidade {0}", pessoas.Capacity);
Console.WriteLine("Total {0}", pessoas.Count);

IEnumerable<Pessoa> pessoas2 = pessoas.Where(x => x.Idade > 30).OrderByDescending(x => x.Idade);

int totalIdade = pessoas2.Sum(x => x.Idade);
Console.WriteLine("Total de Idade: {0}", totalIdade);
foreach(Pessoa p in pessoas2)
{
    Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);
}

Pessoa pessoaJames = pessoas.FirstOrDefault(x => x.Nome == "James");
Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", pessoaJames.Id, pessoaJames.Nome, pessoaJames.Idade);

List<int> numeros = pessoas2.Select(x => x.Id).ToList();
