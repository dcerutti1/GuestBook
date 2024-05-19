List<Tuple<int, string>> Parties = new List<Tuple<int, string>>();
bool shutOff = false;

  Console.WriteLine("Welcome to your personal guest book!");
do
{
    Console.ReadLine();
    Console.WriteLine("Type out what actions you want to take, for example 'ADD' to add a party, or 'SHOW' to show your whole list!'");


    bool? IsTrue = null;
    string? userInput = null;
    string[] validSelction = { "ADD", "SHOW" };

    do
    {
        userInput = Console.ReadLine();

        if (Array.Exists(validSelction, element => element.Equals(userInput, StringComparison.OrdinalIgnoreCase)))

        { IsTrue = true; }

        else
        {
            IsTrue = false;
            Console.WriteLine("sorry, that is invalid. please try again ");
        }


    } while (IsTrue == false);

    

    if (userInput == "ADD")
    {

        Console.Write("OK, what is the name for the party? ");
        string? nameOfParty = Console.ReadLine();


        Console.Write("OK, how many guests? ");
        string Guests = Console.ReadLine();

        int intValue = 0;

        try
        {
            intValue = int.Parse(Guests);
        }
        catch (Exception e)
        {

            Console.WriteLine("invalid number of guests, try again.");

        }
       
        Parties.Add(new Tuple<int, string>(intValue, nameOfParty));
    }
    else if (userInput == "SHOW")
    {
        foreach (var party in Parties)
        {
            Console.WriteLine($"{party.Item1}, {party.Item2}");
        }


    }
    

    Console.WriteLine("are you done? if so, YES if not, NO.");

    string shutDown = Console.ReadLine();

    if (shutDown == "NO")
    {
        shutOff = false; 

    } else if (shutDown == "YES")
    {
        shutOff = true;
    }

} while (shutOff == false);