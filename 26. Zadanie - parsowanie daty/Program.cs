namespace Parsowanie.Daty
{
    class Program
    {

        static void Main(string[] args)
        {
            bool Done = false;
            do
            {
                DateTime DateNow = DateTime.Now;
                Console.WriteLine("Podaj date urodzin(yyyy-mm-dd):");
                string Dateofbirth_s = Console.ReadLine();
                try
                {
                    DateTime Dateofbirth = Convert.ToDateTime(Dateofbirth_s);
                    double TotalDays = (DateNow - Dateofbirth).TotalDays;
                    Console.WriteLine(TotalDays.ToString("F"));
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Data urodzin musi być w formacie yyyy-mm-dd");
                }
            } while (true);


        }
    }
}