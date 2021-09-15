using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void task1aTypes()
        {
            bool Bool = true;
            byte Byte = 3;
            sbyte Sbyte = -100;
            char Char = 'd';
            decimal Decimal = 2.1m;
            double Double = 12.3;
            float Float = 1.03f;
            int Int = 5;
            uint Uint = 345;
            long Long = 324523235;
            ulong Ulong = 2112412;
            short Short = 34;
            ushort Ushort = 232;
            object[] Object = { "Max", "BSTU"}; //Универсальный тип
            string String = "Maksim";
            dynamic Dynamic = "BELSTU";
            Console.WriteLine($"{Bool}\n{Byte}\n{Sbyte}\n{Char}\n{Decimal}\n" +
                $"{Double}\n{Float}\n{Int}\n{Uint}\n{Long}\n{Ulong}\n{Short}\n" +
                $"{Ushort}\n{Object[0]}\n{String}\n{Dynamic}");

        }

        static void task1bTypes()
        {
            //Неявные
            //1
            sbyte Imsbyte = 2;
            short Imshort = Imsbyte;

            //2
            int Imint = 123;
            long Imlong = Imint;

            //3
            byte Imbyte = 2;
            ushort Imushort = Imbyte;

            //4
            char Imchar = 'a';
            int Imchartoint = Imchar;

            //5
            float Imfloat = 10f;
            double Imdouble = Imfloat;

            //Явные
            //1
            double Exdouble = 4.0;
            decimal Exdecimal = (decimal)Exdouble;

            //2
            ulong Exulong = 56;
            int Exint = (int)Exulong;

            //3
            float Exfloat = 4545f;
            char Exchar = (char)Exfloat;

            //4
            double Exdoubletofloat = 2;
            float Exfloatfromdouble = (float)Exdoubletofloat;

            //5
            char Exchartoshort = 'a';
            short Exshort = (short)Exchartoshort;

            bool tryConvertToBool = Convert.ToBoolean(3543535);

        }

        static void taskcTypes()
        {
            //1
            int a = 5;
            object box = a;
            int b = (int)box;

            //2
            bool Bool = true;
            object boxBool = Bool;
            bool Unbox = (bool)boxBool;
        }

        static void taskdTypes()
        {
            var ImVar = "Hello";
            Console.WriteLine(ImVar.GetType().ToString());
        }

        static void taskeTypes()
        {
            int? NullableLit = 5;
            Nullable<char> NullableClass = 'a';

            Console.WriteLine($"Значение переменной созданной как литерал: {NullableLit.Value}");
            Console.WriteLine($"Значение переменной созданной через спец класс: {NullableClass.Value}");
            Console.WriteLine($"Проверка на наличие Value в переменной: {NullableClass.HasValue}");
        }

        static void taskfTypes()
        {
            //var a = true;
            //a = 5;
            //Ключевое слово var выводит тип из правой части и получается у a тип bool, но не int
        }

        static void taskaStrings()
        {
            string val1 = "val1";
            string val2 = "azbuka";
            int result = String.Compare(val1, val2);
            if (result < 0)
            {
                Console.WriteLine("Строка val1 выше строки val2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка val1 стоит после строки val2");
            }
            else
            {
                Console.WriteLine("Строки val1 и val2 идентичны");
            }
        }

        static void taskbStrings()
        {
            string str1 = "BSTU";
            string str2 = "Maksim";
            string str3 = "Hello Max!";

            //Конкатенация
            string str12 = String.Concat(str1, str2);
            //Копирование
            string copyStr = String.Copy(str3);
            //Выделение подстроки
            int Index = str2.IndexOf("ksim");
            string sisStr2 = str2.Substring(Index);
            //Разделение строки
            string[] wordArr = str3.Split(new char[] { ' ' });
            foreach (string s in wordArr)
            {
                Console.WriteLine($"Разделение строки: {s}");
            }
            //Вставка подстроки
            string insertStr = str1.Insert(1, str3);
            //Удаление подстроки
            string removeStr = str3.Remove(2, 4); //1-индекс 2-сколько удалить
            //Интерполирование
            string interStr = $"{str1} some text {str3}";

            Console.WriteLine($"Кокатенация: {str12}");
            Console.WriteLine($"Копирование: {copyStr}");
            Console.WriteLine($"Выделение подстроки: {sisStr2}");
            Console.WriteLine($"Вставка подстроки: {insertStr}");
            Console.WriteLine($"Удаление подстроки: {removeStr}");
            Console.WriteLine($"Интерполирование: {interStr}");
        }

        static void taskcStrings()
        {
            string nullStr = null;
            string emptyStr = "";
            string goodStr = "Hello!";

            String Check(string str)
            {
                if (String.IsNullOrEmpty(str))
                {
                    return "is null or empty";
                }
                else
                {
                    return "good str";
                }
            }

            Console.WriteLine(Check(nullStr));
            Console.WriteLine(Check(emptyStr));
            Console.WriteLine(Check(goodStr));
        }

        static void taskdStrings()
        {
            StringBuilder str = new StringBuilder("Hello");
            str.Remove(0, 2);
            str.Insert(0, "Me");
            str.Append(", Max!");
            Console.WriteLine(str);
        }
        static void taskaArrays()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 66, 12, 0 } };

            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static void taskbArrays()
        {
            string[] arrayStr = new string[] { "Max", "Maksim", "Maksik"};


            Console.WriteLine("Массив: ");
            foreach (string str in arrayStr)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine("");
            Console.WriteLine(arrayStr.Length);

            Console.WriteLine("Введите позицию элемента:");
            int pos;
            if (int.TryParse(Console.ReadLine(), out pos) && arrayStr.Length - 1 >= pos)
            {
                Console.WriteLine("Введите новое значение:");
                string newStr = Console.ReadLine();

                arrayStr[pos] = newStr;
                foreach (string str in arrayStr)
                {
                    Console.Write(str + " ");
                }
            }
            else
            {
                Console.WriteLine("Такого элемента нет, попробуйте еще раз");
                taskbArrays();
            }
            
        }

        static void taskcArrays()
        {
            float[][] arrayFloat = new float[3][];
            arrayFloat[0] = new float[2]{ 2.2f, 2.7f };
            arrayFloat[1] = new float[3] { 4.5f, 0.1f, 2.0f };
            arrayFloat[2] = new float[4] { 7.7f, 12.99f, 13.1f, 2.1f};

            for(int i = 0; i < arrayFloat.Length; i++)
            {
                for(int j = 0; j < arrayFloat[i].Length; j++)
                {
                    Console.Write(arrayFloat[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void taskdArrays()
        {
            var imArray = new[] { true, false, false, true};
            var imStr = "Hello!";
        }

        static void taskaTuple()
        {
            (int, string, char, string, ulong) tuple = (5, "Hello", 'A', "Rocket", 101);

            Console.WriteLine($"Кортеж целиком: {tuple.ToString()}");

            Console.Write(tuple.Item1 + " " + tuple.Item5 + " " + tuple.Item4 + "\n") ;

            (int one, string two, short three) = (5, "Maksim", 55);
            Console.WriteLine($"Распаковка 1 способ: {two}");

            (int, string, char, string, ulong) tupleUnpacking2 = (5, "Hello", 'A', "Rocket", 101);
            var (count, str, ch1, ch2, ch3) = tupleUnpacking2;
            Console.WriteLine($"Распаковка 2 способ: {ch1}");

            Console.WriteLine(tuple == tupleUnpacking2);

        }

        static (int, int, int, string) staticFunc(int [] arrInt, string str)
        {
            int max = arrInt.Max();
            int min = arrInt.Min();
            int sum = arrInt.Sum();
            string firstLetter = str.Substring(0, 1);
            return (max, min, sum, firstLetter);
        }

        static void task6()
        {
            void func1()
            {
                try
                {
                    checked
                    {
                        int maxVal = int.MaxValue + 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Произошло переполнение!");
                }
                

            }

            void func2()
            {
                try
                {
                    unchecked
                    {
                        int maxVal = int.MaxValue;
                    }
                }
                catch
                {
                    Console.WriteLine("Произошло переполнение!");
                }
                
            }
        }
        static void Main(string[] args)
        {
            //Типы
            //task1aTypes();
            //task1bTypes();
            //taskcTypes();
            //taskdTypes();
            //taskeTypes();
            //taskfTypes();

            //Строки
            //taskaStrings();
            //taskbStrings();
            //taskcStrings();
            //taskdStrings();

            //Массивы
            //taskaArrays();
            //taskbArrays();
            //taskcArrays();


            //Кортежи
            //taskaTuple();
            //(int, int, int, string) tuple = staticFunc(new int[] { 1, 2, 3 }, "Hello");
            //Console.WriteLine(tuple);

            task6();
        }
    }
}
