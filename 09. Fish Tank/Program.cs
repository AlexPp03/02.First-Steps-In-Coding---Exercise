int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double procent = double.Parse(Console.ReadLine());

int size = lenght * width * height;
double sizeL = size * 0.001;
double procentR = procent / 100.0;

double liters = sizeL * (1 - procentR);

Console.WriteLine(liters);