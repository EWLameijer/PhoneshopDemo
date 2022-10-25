using PhoneShop.Business;
using PhoneShop.Domain;
using PhoneShop.Domain.Interfaces;

IPhoneService phoneService = new PhoneService();
Dictionary<char, Action> choices = new();

do
{
    Console.Clear();
    ShowMenu();
    char userInput = Console.ReadKey(true).KeyChar;
    if (choices.ContainsKey(userInput)) choices[userInput]();
    else ShowErrorMessage(userInput);

    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
} while (true);

void ShowMenu()
{
    List<Phone> sortedPhones = phoneService.Get().OrderBy(p => p.Id).ToList();
    foreach (Phone phone in sortedPhones)
    {
        createMenuOption($"{phone.Brand} {phone.Type}", phone.Id, () => ShowPhone(phone));
    }
    int quitId = sortedPhones.Last().Id + 1;
    createMenuOption($"Exit", quitId, () => Environment.Exit(0));
}

void ShowErrorMessage(char ch) => Console.WriteLine($"'{ch}' is not a valid choice.");

void ShowPhone(Phone phone) =>
    Console.WriteLine($"The {phone.Brand} {phone.Type} is a great phone!");

void createMenuOption(string message, int id, Action action)
{
    Console.WriteLine($"{id}. {message}");
    choices[(char)(id + '0')] = action;
}