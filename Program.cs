// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 0;
int userInput = 0;
int remainder = 0;
bool isValidInput = false;

Console.WriteLine("Skriv inn et tall");

do
{
    isValidInput = int.TryParse(Console.ReadLine(), out userInput);
    if (!isValidInput)
    {
        Console.WriteLine("Du må skrive inn et tall");
        isValidInput = false;
        i++;
        if (i >= 4)
        {
            Console.WriteLine("Du har brukt for mange forsøk");
            break;
        }
    }

} while (!isValidInput);


if (isValidInput)
{

    remainder = userInput % 2;
    Console.WriteLine($"Remainder:  {remainder}");
    Console.WriteLine($"Du skrev inn {userInput}");
    if (remainder == 0)
    {
        Console.WriteLine($"{userInput} er et partall");
    }
    else
    {
        Console.WriteLine($"{userInput} er et oddetall");
    }
    Console.WriteLine(userInput.GetType());
}



