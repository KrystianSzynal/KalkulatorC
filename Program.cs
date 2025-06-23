namespace KalkulatorC
{
    internal class Program
    {
        static void Main(string[] args)



        {
            Console.WriteLine("--- Prosty Kalkulator w C# ---");
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1. Dodawanie (+)");
            Console.WriteLine("2. Odejmowanie (-)");
            Console.WriteLine("3. Mnożenie (*)");
            Console.WriteLine("4. Dzielenie (/)");
            Console.WriteLine("5. Modulo (%)");
            Console.Write("Wpisz numer działania (1-5): ");
           
            string wybor = Console.ReadLine();
            double liczba1, liczba2, wynik;

            Console.Write("Podaj pierwszą liczbę: ");
            // Próba konwersji tekstu na liczbę. Jeśli się nie powiedzie, program zakończy działanie.
            if (!double.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.WriteLine("Błąd: Nieprawidłowa liczba. Uruchom program ponownie.");
                return;
            }

            Console.Write("Podaj drugą liczbę: ");
            if (!double.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.WriteLine("Błąd: Nieprawidłowa liczba. Uruchom program ponownie.");
                return;
            }

            switch (wybor)
            {
                case "1": // Dodawanie
                    wynik = liczba1 + liczba2;
                    Console.WriteLine($"Wynik dodawania: {liczba1} + {liczba2} = {wynik}");
                    break;
                case "2": // Odejmowanie
                    wynik = liczba1 - liczba2;
                    Console.WriteLine($"Wynik odejmowania: {liczba1} - {liczba2} = {wynik}");
                    break;
                case "3": // Mnożenie
                    wynik = liczba1 * liczba2;
                    Console.WriteLine($"Wynik mnożenia: {liczba1} * {liczba2} = {wynik}");
                    break;
                case "4": // Dzielenie
                    if (liczba2 == 0)
                    {
                        Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                    }
                    else
                    {
                        wynik = liczba1 / liczba2;
                        Console.WriteLine($"Wynik dzielenia: {liczba1} / {liczba2} = {wynik}");
                    }
                    break;
                case "5": // Modulo
                    wynik = liczba1 % liczba2;
                    Console.WriteLine($"Wynik modulo: {liczba1} % {liczba2} = {wynik}");
                    break;
                default:
                    Console.WriteLine("Błąd: Nieprawidłowy wybór działania.");
                    break;
            }


            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey(); // Czeka na naciśnięcie klawisza przed zamknięciem konsoli
        }
    }
}



