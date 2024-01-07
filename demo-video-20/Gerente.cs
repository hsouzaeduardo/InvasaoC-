public class Gerente : Empregado
{
    public decimal Bonus { get; set; }
    public Gerente(string nome, string sobrenome, string cpf, decimal salario, decimal bonus)
    :base(nome, sobrenome, cpf, salario)
    {
        this.Bonus = bonus;
    }    

   override public decimal GetBonificacao()
   {
       return (base.Salario * this.Bonus) * 0.1m;
   }

     override public  string ToString()
   {
        string result = base.ToString();
        
        Console.WriteLine(result);
        Console.WriteLine($"Bonus: {this.GetBonificacao()}");
        return "";
   }

   public void AumentarSalario()
   {
       base.Salario += base.Salario * 0.1m;
   }    
}
