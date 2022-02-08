int GetRandomNumber ()
{ 
    int randomNumber = new Random().Next(0,1000);
    return randomNumber;
}
int randomValue = GetRandomNumber();
Console.WriteLine($"Дано число: {randomValue}");

int firstDigit = randomValue / 100;
int secondDigit = randomValue % 10;
Console.WriteLine($"{firstDigit}{secondDigit}");