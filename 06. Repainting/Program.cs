double nylon = double.Parse(Console.ReadLine());
double paint = double.Parse(Console.ReadLine());
double thinner = double.Parse(Console.ReadLine());
double hours = double.Parse(Console.ReadLine());

paint = paint + paint * 0.10;
nylon = nylon + 2;
double paintP = paint * 14.50;
double nylonP = nylon * 1.50;
double thinnerP = thinner * 5.00;

double sum = paintP + nylonP + thinnerP + 0.40;

double priceW = (sum * 0.3) * hours;

double finalPrice = sum + priceW;


Console.WriteLine(finalPrice);