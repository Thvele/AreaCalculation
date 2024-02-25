using AreaCalcualtion;

public class MainClass
{
    static void Main()
    {
        bool selected = false;

        while (!selected)
        {
            A:
            int figureType = -1;
            Console.Write("Выберите тип фигуры: \n\t1. Треугольник \n\t2. Круг \n\n\t0. Выход \n\nВыбор: ");
            try
            {
                figureType = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.Clear();
                Console.WriteLine("Нужно ввести число!\n");
                goto A;
            }

            switch (figureType)
            {
                case 0:
                    selected = true; 
                    break;

                case 1:
                    Console.Clear();
                    Triangle triangle = new Triangle();

                    C:
                    Console.WriteLine("Введите 3 стороны\n");

                    try
                    {
                        Console.Write("Сторона a: ");
                        triangle.a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Сторона b: ");
                        triangle.b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Сторона c: ");
                        triangle.c = Convert.ToInt32(Console.ReadLine());

                        if (triangle.a < 0 || triangle.b < 0 || triangle.c < 0) throw new Exception();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Введите число, которое больше 0\n");
                        goto C;
                    }

                    if(!triangle.isExist())
                    {
                        Console.Clear();
                        Console.WriteLine("Такого треугольника не существует\n");
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.Read();
                        goto A;
                    }

                    if(triangle.isRectangular())
                        Console.WriteLine("\nТреугольник - Прямоугольный");
                    else
                        Console.WriteLine("\nТреугольник - Непрямоугольный");

                    Console.WriteLine("Площадь трегольника = " + triangle.calculateArea());

                    Console.WriteLine("\nНажмите Enter для продолжения");
                    Console.Read();

                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Circle circle = new Circle();

                    B:
                    Console.Write("Введите радиус: ");

                    try
                    {
                        circle.r = Convert.ToInt32(Console.ReadLine());
                        if (circle.r < -1) throw new Exception();
                    }
                    catch
                    {
                        Console.WriteLine("Введите число, которое больше 0\n");
                        goto B;
                    }

                    Console.WriteLine("\nПлощадь круга равна = " + circle.calculateArea());
                    Console.WriteLine("\nНажмите Enter для продолжения");
                    Console.Read();

                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Такого варианта нет");
                    Console.WriteLine("\nНажмите Enter для продолжения");
                    Console.Read();
                    break;
            }
        }
    }
}