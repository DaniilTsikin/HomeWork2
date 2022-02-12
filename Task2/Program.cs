int GetRandomNumber ()
{ 
    int randomNumber = new Random().Next(0,1000);
    return randomNumber;
}
int randomValue = GetRandomNumber();
Console.WriteLine($"Дано число: {randomValue}");
if (randomValue > 99)
{
int firstDigit = randomValue / 100;
int secondDigit = randomValue % 10;
Console.WriteLine($"{firstDigit}{secondDigit}");
}
else
{
    Console.WriteLine($"Число не трёхзначное: {randomValue}");
}