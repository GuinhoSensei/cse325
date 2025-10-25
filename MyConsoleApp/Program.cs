var date = DateTime.Now;
var daysUntilChristmas = (new DateTime(date.Year, 12, 25) - date).Days;
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is:{date}");
Console.WriteLine($"Days until Chsitmas: {daysUntilChristmas}");