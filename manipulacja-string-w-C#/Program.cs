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

            string wpisUzytkownikaBezSpacji = wpisUzytkownika.Trim();
            int dlugoscWpisuUzytkownika = wpisUzytkownika.Length;
            string pierwszaLiteraWpisu = wpisUzytkownika.Substring(0, 1);
            string ostatniaLiteraWpisu = wpisUzytkownika.Substring(wpisUzytkownika.Length -1, 1);

            Console.WriteLine("Wpisałes: " + wpisUzytkownikaBezSpacji);
            Console.WriteLine("Długość " + dlugoscWpisuUzytkownika);
            Console.WriteLine("Pierwsza litera: " + pierwszaLiteraWpisu);
            Console.WriteLine("Ostatnia litera: " + ostatniaLiteraWpisu);



                Console.WriteLine("3. Liczenie wystąpień znaku");
            Console.WriteLine("Napisz cos");
            string wpis3 = Console.ReadLine();
            Console.WriteLine("Napisz jakiego znaku szukasz w swoim wpisie:");
            char szukanyZnak = Console.ReadKey().KeyChar;
            int licznik = 0;
            for (int i = 0; i < wpis3.Length; i++)
            {
                if (wpis3[i] == szukanyZnak)
                {
                    licznik++;
                }
            }

            Console.WriteLine("\ntekst: " + wpis3);
            Console.WriteLine("znak: " + szukanyZnak);
            Console.WriteLine("Znak '" + szukanyZnak + "' wystepuje " + licznik + " razy.");



                Console.WriteLine("4. Zamiana spacji na podkreślniki");
            Console.WriteLine("Napisz coś: ");
            string wpisUzytkownika4 = Console.ReadLine();
            Console.WriteLine("Co chcesz zastąpić?");
            string wpis4_2 = Console.ReadLine();
            Console.WriteLine("Co ma zastąpić " + wpis4_2 + "?");
            string wpis4_1 = Console.ReadLine();
            string zmieniony = wpisUzytkownika4.Replace(wpis4_2, wpis4_1);
            Console.WriteLine(zmieniony);



                Console.WriteLine("5. Odwracanie tekstu");
            Console.WriteLine("Napisz coś: ");
            string wpisUzytkownika5 = Console.ReadLine();

            for (int i = wpisUzytkownika5.Length - 1; i >= 0; i--)
            {
                Console.Write(wpisUzytkownika5[i]);
            }



            Console.WriteLine("6. Czy palindrom?");
            Console.WriteLine("Wpisz coś a ja sprawdze czy tulipan");
            string palindrom = Console.ReadLine();
            bool czyPalindrom = true;

            for (int i = (palindrom.Length - 1) / 2; i >= 0; i--)
            {
                if (palindrom[i] != palindrom[palindrom.Length - 1 - i])
                {
                    czyPalindrom = false;
                    break;
                }
            }

            if (czyPalindrom)
            {
                Console.WriteLine(palindrom + " jest palindromem");
            }
            else
            {
                Console.WriteLine("To nie bedzie palindrom");

            }
            Console.WriteLine();
            Console.WriteLine("Wpisz słowa a ja ci policze");
            string podaneSlowa = Console.ReadLine();
            string[] ileSlowa = podaneSlowa.Split(" ");



            Console.WriteLine("\n7. Licznik słów");
            Console.WriteLine("Napisz coś: ");
            string wpis7 = Console.ReadLine();
            string wpisBezSpacji7 = wpis7.Trim();
            string[] podzielonyWpis7 = wpisBezSpacji7.Split(" ");
            int ileMaSlow = podzielonyWpis7.Length;
            Console.WriteLine("Wejście: " + wpis7);
            Console.WriteLine("Wyjście: " + ileMaSlow);


                Console.WriteLine("8. Generator akronimów");
            string wpis8 = Console.ReadLine();
            string[] podzielonyWpis8 = wpis8.Split(' ');

            foreach (int i = 0; i >= 0; i++)
            {
                ggg
            }
        }
    }
}
