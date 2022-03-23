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
        }

        private static void PrintNullableTypeDetails<T>(T? value, T defaultValue)
            where T: struct
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine($"value={value}");
            Console.WriteLine($"value.HasValue={value.HasValue}");
            if (value.HasValue)
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
