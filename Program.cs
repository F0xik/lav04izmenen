
double x1; double x2;
Console.WriteLine("введите коэффициент a"); double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите коэффициент b ");
    double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("введите коэффициент c");
    double c = Convert.ToDouble(Console.ReadLine()); double x0 = -b / (2 * a);
    double y0 = a * Math.Pow(x0, 2) + b * x0 + c; double D = Math.Pow(b, 2) - 4 * a * c;
    if (D <= 0) Console.WriteLine(a > 0 ? $"функиция всегда положетельна" : $"функиция всегда отрицательна");
    else
    {
        x1 = (-b + Math.Pow(D, 0.5)) / 2 * a; x2 = (-b - Math.Pow(D, 0.5)) / 2 * a;
        Console.WriteLine(a > 0 ? $"функция положительна при (-беск,{x1})({x2} беск+) функция отрицательна при ({x1},{x2})" : $"функция отрицательна при (-беск,{x1})({x2} беск+) функция положительна при ({x1},{x2})");
    }
    Console.WriteLine($"кординаты вершины парабалы ({x0};{y0})");
    Console.WriteLine(a > 0 ? $"направленна вверх" : $"направленна ввниз"); Console.WriteLine(a > 0 ? $"y мин = {y0}" : $"y макс = {y0}");
    Console.WriteLine(a > 0 ? $"функция убывает  (- беск, {x0}) функция возрастает  ({x0} , беск+) " : $"функция убывает ({x0} , -беск) функция возрастает  (беск+ , {x0})");