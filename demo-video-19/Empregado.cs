public class Empregado
{
    public int Matricula { get; private set; }
    public string Nome { get; private set; }
    public decimal Salario { get; private set; }
    public DateTime DataNascimento { get; set; }
    public int Idade
    {
        get
        {
            return CalculateAge();
        }
    }

    private int CalculateAge()
    {
        int totalYears = DateTime.Now.Year - DataNascimento.Year;

        if (DataNascimento == null)
            throw new Exception("Data de nascimento não informada");
        if (DataNascimento.Month > DateTime.Now.Month)
            totalYears--;
        else if (DataNascimento.Month == DateTime.Now.Month && DataNascimento.Day > DateTime.Now.Day)
            totalYears--;

        return totalYears;

    }

    public Empregado(string nome, decimal salario, int matricula, DateTime dataNascimento)
    {
        Nome = nome;
        Salario = salario;
        Matricula = matricula;
        DataNascimento = dataNascimento;
    }
   
}
