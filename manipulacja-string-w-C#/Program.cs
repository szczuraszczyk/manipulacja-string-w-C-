namespace manipulacja_string_w_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Zamiana wielkości liter");
            Console.WriteLine("\nNapisz dowolne zdanie: ");
            string zdanieUzytownika = Console.ReadLine();
            int iloscLiterWZdaniuUzytkownika = zdanieUzytownika.Length;
            string zdanieUzytkownikaWWielkichLiterach = zdanieUzytownika.ToUpper();
            string zdanieUzytkownikaWMalychLiterach = zdanieUzytownika.ToLower();
            Console.WriteLine("Długość tekstu: " + iloscLiterWZdaniuUzytkownika + ".\n" +
                "Twoje zdanie w Wiekich Literach: " + zdanieUzytkownikaWWielkichLiterach + ".\n" +
                "Twoje zdanie w małych literach: " + zdanieUzytkownikaWMalychLiterach + ".");

            Console.WriteLine("1.1");
            Console.WriteLine("1. Zamiana wielkości liter");
            Console.WriteLine("\nNapisz dowolne zdanie: ");
            string zdanieUzytownika2 = Console.ReadLine();
            Console.WriteLine("Wybierz zmiane zdania: up, low, 1-up");
            string operacja = Console.ReadLine();
            int iloscLiterWZdaniuUzytkownika2 = zdanieUzytownika2.Length;
            string zdanieUzytkownikaWWielkichLiterach2 = zdanieUzytownika2.ToUpper();
            string zdanieUzytkownikaWMalychLiterach2 = zdanieUzytownika2.ToLower();
            Console.WriteLine("Długość tekstu: " + iloscLiterWZdaniuUzytkownika2);
            if (operacja == "up")
            {
                Console.WriteLine("Twoje zdanie w wielkich literach: " + zdanieUzytkownikaWWielkichLiterach2);
            } else if (operacja == "low")
            {
                Console.WriteLine("Twoje zdanie w malych literach: " + zdanieUzytkownikaWMalychLiterach2);
            } else if (operacja == "1-up")
            {
                Console.WriteLine("Twoje zdanie z jedynie 1. literą jako wielką: brak danych");
            }
            else
            {
                Console.WriteLine("Podano nieprawidłową zmiane.");
            }


            Console.WriteLine("2. Długość tekstu i pierwsza/ostatnia litera");
            Console.WriteLine("Napisz coś: ");
            string wpisUzytkownika = Console.ReadLine();

            int dlugoscWpisuUzytkownika = wpisUzytkownika.Length;
            string pierwszaLiteraWpisu = wpisUzytkownika.Substring(0, 1);
            string ostatniaLiteraWpisu = wpisUzytkownika.Substring( 1);

            Console.WriteLine("Wpisałes: " + wpisUzytkownika);
            Console.WriteLine("Długość " + dlugoscWpisuUzytkownika);
            Console.WriteLine("Pierwsza litera: " + pierwszaLiteraWpisu);
            Console.WriteLine("Ostatnia litera: " + ostatniaLiteraWpisu);



        }
    }
}
