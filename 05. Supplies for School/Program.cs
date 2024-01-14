int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int preparations = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine()) / 100;

double sum = (pens * 5.80) + (markers * 7.20) + (preparations * 1.20);
double finalPrice = sum - (sum * discount);
Console.WriteLine(finalPrice);
   




