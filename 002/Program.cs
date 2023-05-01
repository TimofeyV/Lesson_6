// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int coef_K = 0;
const int const_B = 1;
const int  coord_x = 0;
const int  coord_y = 1;
const int  line1 = 1;
const int  line2 = 2;

double[] line_1 = InputLine(line1);
double[] line_2 = InputLine(line2);

if(CheckLine(line_1, line_2))
{
    double[] coord = FindCoords(line_1, line_2);
    Console.Write($"Точка пересения прямых имеет координаты ({coord[coord_x]}, {coord[coord_y]})");
}

double[] InputLine(int numberOfLine)
{
    double[] Line = new double[2];
    Line[coef_K] = Prompt($"Введите коэффициент k для {numberOfLine} прямой - ");
    Line[const_B] = Prompt($"Введите константу b для {numberOfLine} прямой - ");
    return Line;
}

double[] FindCoords(double[] Line_1, double[] Line_2)
{
    double[] coord = new double[2];
    coord[coord_x] = (Line_1[const_B] - Line_2[const_B]) / (Line_2[coef_K] - Line_1[coef_K]); // x = (b2-b1)/(k2-k1);
    coord[coord_y] = Line_2[coef_K] * coord[coord_x] + Line_2[const_B]; //y = k2*x+b2;
    return coord;
}

double Prompt(string message)
{
    Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

bool CheckLine(double[] Line_1, double[] Line_2)
{
    if(Line_1[coef_K] == Line_2[coef_K])
    {
        if(Line_1[const_B] == Line_2[const_B])
        {
            Console.WriteLine("Две прямые совпадают");
            return false;
        }
        
        else
        {
            Console.WriteLine("Данные прямые являются параллельными");
            return false;
        }
    }
    return true;
}



