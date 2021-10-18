using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    class EquationSolver
    {
        // Решение линейного уравнения 0=kx+b.
        static void Main(string[] args)
        {
            double coefK = 0;
            double coefB = 0;
            sbyte flag1 = 0;
            sbyte flag2 = 0;
            Console.WriteLine("Для решения уравнения 0=kx+b введите значения коэффициентов k и b");
            Console.Write("Введите значение коэффициента k: ");

            try
            {
                coefK = Convert.ToDouble(Console.ReadLine());
                if (coefK == 0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Формат введенных данных не соответствует допустимым значениям");
                flag1 = -1;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль запрещено");
            }

            if ((coefK != 0) && (flag1 != -1))
            {
                Console.Write("Ввведите значения коэффициента b: ");
                try
                {
                    coefB = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Формат введенных данных не соответствует допустимым значениям");
                    flag2 = -1;
                }
            }

            EquationInput input = new EquationInput();
            input.Root(coefK, coefB, flag1, flag2);

            Console.ReadKey();
        }
    }
    public struct EquationInput
    {

        public void Root(double k, double b, sbyte flag1, sbyte flag2, double x = 0)
        {
            if (k != 0 && flag1 !=-1 && flag2 != -1)
            {
                x = -(b / k);

                Console.WriteLine("Значение неизвестной переменной x = {0:f2}", x);
            }
            else
            {
                Console.WriteLine("Для решения уравнения запустите программу повторно");
            }
        }

    }
}
