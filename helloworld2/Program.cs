// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string firstFriend = "Maria";
string secondFriend = "Sage";
string friends =    $"My friends are {firstFriend} and {secondFriend}";
Console.WriteLine(friends);
Console.WriteLine(friends.Replace("Maria", "Rahul"));
Console.WriteLine(friends.Contains("Maria"));
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.ToLower());
Console.WriteLine(friends.StartsWith("Sco"));
Console.WriteLine(friends.StartsWith("My  "));//significant white space(space inside string matter out doesn't matter)
Console.WriteLine(friends.Length);
Console.WriteLine(friends);


