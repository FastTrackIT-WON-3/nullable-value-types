using System;

namespace NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? flag = true;
            PrintNullableTypeDetails(flag, true);

            int? number = null;
            PrintNullableTypeDetails(number, -10);

            int? number2 = 10;

            if (number < number2)
            {
                Console.WriteLine($"{number} is less than {number2}");
            }
            else if (number > number2)
            {
                Console.WriteLine($"{number} is greater than {number2}");
            }
            else if (number == number2)
            {
                Console.WriteLine($"{number} is equal to {number2}");
            }
            else
            {
                Console.WriteLine($"Something else!");
            }

        }

        private static void PrintNullableTypeDetails<T>(T? value, T defaultValue)
            where T: struct
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine($"value={value}");
            Console.WriteLine($"value.HasValue={value.HasValue}");
            bool isNull = value is null;
            if (!isNull)
            {
                Console.WriteLine($"value.Value={value.Value}");
            }

            Console.WriteLine($"value.GetValueOrDefault()={value.GetValueOrDefault()}");
            Console.WriteLine($"value.GetValueOrDefault(defaultValue)={value.GetValueOrDefault(defaultValue)}");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
        }
    }
}
