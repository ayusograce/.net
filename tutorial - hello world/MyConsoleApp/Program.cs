var time = DateTime.Now;
var christmas = new DateTime(time.Year, 12, 25);
var days = (christmas - time).Days;

Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {time}.");
Console.WriteLine($"There are {days} days until the next Christmas.");