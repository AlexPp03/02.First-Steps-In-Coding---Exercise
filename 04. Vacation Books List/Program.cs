int pagesC = int.Parse(Console.ReadLine());
int pages = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int totalTime = pagesC / pages;
int hoursPerDay = totalTime / days;

Console.WriteLine(hoursPerDay);
