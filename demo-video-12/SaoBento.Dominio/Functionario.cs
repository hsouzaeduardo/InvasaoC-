namespace SaoBento.Dominio;
public class Functionario : EntidadeBase
{
    public Functionario(string nome, DateTime dataNascimento, string cargo, decimal salario, string departamento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Cargo = cargo;
        Salario = salario;
        Departamento = departamento;
    }
    public string Nome { get; private set; }
    public DateTime DataNascimento { get; private  set; }
    //Salario anual para descobrir o mensal basta dividir por 13.3
    public decimal Salario { get; private  set; }
    public string Cargo { get; private set; }
    public string Departamento { get; private set; }
    public int Idade
    {
        get
        {
            DateTime agora = DateTime.Now;
            int idade = agora.Year - DataNascimento.Year;
            if (agora.DayOfYear < DataNascimento.DayOfYear)
            {
                idade--;
            }
            return idade;

        }
    }
    public decimal SalarioAnual { get => Salario * 13.3m; }   
    
}
