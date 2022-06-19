DateTimeExemplo();

static void DateTimeExemplo()
{
    DateTime dataInicio = new DateTime(2019, 10, 01, 14,25,32);
//    Console.WriteLine("Data de inicio: " + dataInicio.ToString("dd/MM/yyyy HH:mm:ss"));
    DateTime hoje = DateTime.Today;
//    Console.WriteLine("Hoje: " + hoje);
    DateTime agora = DateTime.Now;
//    Console.WriteLine("Agora: " + agora);
    DayOfWeek diaDaSemana = hoje.DayOfWeek;
//    Console.WriteLine("Dia da semana: " + diaDaSemana);
    DateTime dataFim = hoje.AddDays(10);
//    Console.WriteLine("Data de fim: " + dataFim.ToString("dd/MM/yyyy HH:mm:ss"));
    bool ehorarioVerao = agora.IsDaylightSavingTime();
//    Console.WriteLine("Horário de verão: " + ehorarioVerao);

    DateOnly dateOnly = new DateOnly(2019, 10, 01);
    //Console.WriteLine("Data: " + dateOnly);
    DateOnly dateOnlyFromDateNow = DateOnly.FromDateTime(DateTime.Now);
    //Console.WriteLine("Data: " + dateOnlyFromDateNow);

    DateTime horaEntrada = DateTime.Now;
    Console.WriteLine("Hora de entrada: " + horaEntrada);
    TimeSpan horarioTrabalho = new TimeSpan(8, 0, 0);
    DateTime horaSaida = horaEntrada.Add(horarioTrabalho);
    Console.WriteLine("Hora de Saída: " + horaSaida);
    TimeOnly horaEntradaTimeOnly = new TimeOnly(22, 19,24);
    Console.WriteLine("Hora de entrada: " + horaEntradaTimeOnly);

}
