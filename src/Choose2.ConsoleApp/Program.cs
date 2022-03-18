while (true)
{
    var keyInfo = Console.ReadKey();
    if (keyInfo.Key == ConsoleKey.Enter)
    {
        Console.WriteLine();
    }
    else
    {
        Console.Write("\b");
    }
    var random = RandomNumber.Between(0, 1);
    Console.Write(random);
}
