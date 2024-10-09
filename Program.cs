// var data = new DateTime();
//var data = DateTime.Now; //Pegando a data e hora atual
//Console.Clear();
//var data = DateTime.Now; //Criando uma data atual com esse método


//Console.WriteLine(data.Day);
//Console.WriteLine(data.Year);
//Console.WriteLine(data.Second);

// Formatando data
//var dataFormatada = string.Format("{0:r}", data); // Formatando a data

//Metádos no DateTime
//var date = DateTime.Now;

//Adicionando mais um dia 
//Console.WriteLine(date.AddDays(1));
//Console.WriteLine(date.AddHours(1));

//comparando data
//var date = DateTime.Now;
//if(date.Date == DateTime.Now.Date){
//    Console.WriteLine("É igual");
//}
using System.Globalization;
namespace DateData
{

    class Program
    {
        static void Main(string[] args)
        {

            DateTime dataAtual = DateTime.Now;

            DateTime dataFutura = dataAtual.AddDays(10); // Adiciona 10 dias
            DateTime proximoMes = dataAtual.AddMonths(1); // Adiciona 1 mês
            DateTime proximoAno = dataAtual.AddYears(1); // Adiciona 1 ano

            Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy"));
            Console.WriteLine("Data futura: " + dataFutura.ToString("dd/MM/yyyy"));
            Console.WriteLine("Próximo mês: " + proximoMes.ToString("dd/MM/yyyy"));
            Console.WriteLine("Próximo ano: " + proximoAno.ToString("dd/MM/yyyy"));

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("FORMATAÇÃO DE DATA");

            DateTime agora = DateTime.Now;
            string formato = agora.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("Data formatada: " + formato);

            Console.WriteLine("----------------------------------------------------");
            DateTime utcAgora = DateTime.UtcNow;
            TimeZoneInfo fusoHorario = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            DateTime horaLocal = TimeZoneInfo.ConvertTimeFromUtc(utcAgora, fusoHorario);
            Console.WriteLine("Hora local: " + horaLocal);



        }
    }
}




