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
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    //Salario anual para descobrir o mensal basta dividir por 13.3
    public decimal Salario { get; set; }
    public string Cargo { get; set; }
    public string Departamento { get; set; }
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
