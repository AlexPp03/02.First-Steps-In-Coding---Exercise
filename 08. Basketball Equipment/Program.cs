int tax = int.Parse(Console.ReadLine());

double shoes = tax - tax * 0.4;
double outfit = shoes - shoes * 0.2;
double ball = outfit * 0.25;
double acc = ball / 5;

double finalPrice =  tax + shoes + outfit + ball + acc;

Console.WriteLine(finalPrice);
