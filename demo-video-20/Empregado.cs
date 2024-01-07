public class Empregado
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string CPF { get; set; }
    public decimal Salario { get; set; }

    public Empregado(string nome, string sobrenome, string cpf, decimal salario)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        CPF = cpf;
        Salario = salario;
    }
    public override string ToString()
    {
        return $"Nome: {Nome} {Sobrenome} - CPF: {CPF} - Salário: {Salario}";
    }   

    public virtual decimal GetBonificacao(){
        return Salario * 0.1m;
    }

}