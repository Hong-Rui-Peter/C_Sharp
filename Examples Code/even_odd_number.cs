// 判斷奇偶數
using System;

class EvenOddNum
{
    public static void even_odd_number()
    {
        Console.Write("請輸入一個數字:");
        int num = Console.Read();

        if (num % 2 == 0)//除2餘數為0
        {
            Console.WriteLine(num + "是偶數\n");
        }
        else
        {
            Console.WriteLine(num + "是奇數\n");
        }

    }
}