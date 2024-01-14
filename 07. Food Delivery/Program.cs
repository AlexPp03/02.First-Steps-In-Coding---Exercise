int chiken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegetarian = int.Parse(Console.ReadLine());

double chikenP = chiken * 10.35;
double fishP = fish * 12.40;
double vegetarianP = vegetarian * 8.15;
double sum = chikenP + fishP + vegetarianP;

double desert = sum * 0.20;

double finalPrice = sum + desert + 2.50;

Console.WriteLine(finalPrice);


