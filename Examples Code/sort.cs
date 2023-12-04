// 氣泡排序法
using System;

class Sort
{
    public static void sort(int[] n)
    {
        for (int i = 0; i < n.Length; i++)
        {
            for (int j = 0; j < n.Length - 1; j++)
            {
                if (n[j] > n[j + 1])//如果後者大於前者
                {
                    int temp = n[j + 1];//前後交換
                    n[j + 1] = n[j];
                    n[j] = temp;
                }
            }
        }

        for (int i = 0; i < n.Length; i++)
        {
            Console.Write(n[i]);
        }
        Console.WriteLine();
    }
}