using System;

namespace task_2
{
    class Program
    {
        delegate double MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое числ: ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе числ: ");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите операцию: + , - , / , * ");
            string str = Convert.ToString(Console.ReadLine());

            MyDelegate myDel = null;

            switch (str)
            {
                case "+":
                    myDel = (a, b) => { return a + b; };
                    break;
                case "-":
                    myDel = (x, y) => { return x - y; };
                    break;
                case "*":
                    myDel = (f, r) => { return f * r; };
                    break;
                case "/":
                    myDel = (s, k) =>
                    {
                        if (k != 0)
                        {
                            return s / (double)k;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить незя");
                            return 0;
                        }
                    };//завершаем лямбда оператор
                    break;
                default:
                    Console.WriteLine("Введен несуществующии оператор");
                    break;
            }

            //!!!!!!!!!еслиделегат не равен null то выполняется соответствующий метод, кот сообщен с делегатом
            if (myDel != null)
                Console.WriteLine("{0:##.###}",myDel(i, j));

            Console.ReadLine();
        }
    }
}
