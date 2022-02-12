int GetRandomNumber ()
{ 
    int randomNumber = new Random().Next(0,10000);
    return randomNumber;
}
int randomValue = GetRandomNumber();
Console.WriteLine($"Дано число: {randomValue}");

while (randomValue > 999)
{
    randomValue = randomValue / 10;
}

Console.WriteLine($"Необходимый диапазон: {randomValue}");
int secondNumber = (randomValue % 100 - randomValue % 10) / 10;
Console.WriteLine(secondNumber);
if (randomValue >= 100)
{
    Console.WriteLine($"Второе число: {secondNumber}");
}
else
{
    Console.WriteLine($"Второе число: {randomValue % 10}");
}
