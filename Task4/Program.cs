int GetRandomNumber ()
{ 
    int randomNumber = new Random().Next(1, 8);
    return randomNumber;
}
int randomValue = GetRandomNumber();
Console.WriteLine($"Дано число: {randomValue}");
string[] weekDayName = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
if (randomValue < 6)
{
    Console.WriteLine($"{weekDayName[randomValue-1]} будний день");
}
else
{
    Console.WriteLine($"{weekDayName[randomValue-1]} выходной день");
}