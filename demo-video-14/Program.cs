int valor = 10;

Console.WriteLine(valor);

int copiaValor = valor;
copiaValor = 20;
Console.WriteLine(copiaValor);

demo_video_14.Pessoa pessoa = new demo_video_14.Pessoa();
pessoa.Name = "João";
Console.WriteLine(pessoa.Name);//Joao

demo_video_14.Pessoa copiaPessoa = pessoa;
copiaPessoa.Name = "Maria";
Console.WriteLine(pessoa.Name); //Maria




