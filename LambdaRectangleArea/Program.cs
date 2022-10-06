// See https://aka.ms/new-console-template for more information

// User input for the length and width of the rectangle
Console.WriteLine("Please enter width of rectangle");
int w = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pleae enter lenght of rectangle");
int l = Convert.ToInt32(Console.ReadLine());

// Lambda expression 
Func<int, int> recArea = (area) => w * l;

// Console output
int area = recArea(l * w);
Console.WriteLine("Area of rectangle", area);