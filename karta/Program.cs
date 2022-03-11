// See https://aka.ms/new-console-template for more information
string cardName(int cardValue)
{
    switch (cardValue)
    {
        case 11:
            return "walet";
        case 12:
            return "dama";
        case 13:
            return "król";
        case 14:
            return "as";
        default:
            return cardValue.ToString();
    }
}

Random k = new Random();
char karta;
do
{
    int card1 = k.Next(2, 14);
    int card2;
    Console.WriteLine("wylosowana karta to " + cardName(card1));
    Console.WriteLine("następna karta będzie (w)yższa czy (n)iższa");

    karta = Console.ReadKey(true).KeyChar;
    switch (karta)
    {
        case 'w':
            card2 = k.Next(2, 14);
            Console.WriteLine("Wylosowana karta to " + cardName(card2));
            if (card2 > card1)
                Console.WriteLine("Gratulacje - wygrał*ś!");
            else
                Console.WriteLine("Niestety - przegrał*ś");
            break;
        case 'n':
            card2 = k.Next(2, 14);
            Console.WriteLine("Wylosowana karta to " + cardName(card2));
            if (card2 < card1)
                Console.WriteLine("Gratulacje - wygrał*ś!");
            else
                Console.WriteLine("Niestety - przegrał*ś");
            break;
        default:
            Console.WriteLine("Podał*ś nieobsługiwaną odpowiedź - spróbuj ponownie");
            Console.WriteLine("Naciśnij (q) aby wyjść z gry");
            break;

    }
    Console.WriteLine();
} while (karta != 'q');