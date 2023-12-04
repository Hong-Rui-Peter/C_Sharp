// 九九乘法表
using System;

class NineToNine
{
    public static void nine_to_nine()
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write(i + "*" + j + "=" + i * j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}