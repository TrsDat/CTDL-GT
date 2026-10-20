using System;
using System.Collections.Generic;
using System.Text;

namespace CTDL_GT.Stacks_Queues
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            int[] m = new int[] { 45, 215, 4, 78, 13, 9, 48, 176 };
            Stack<int> kq = new Stack<int>(m);
            List<Stack<int>> san = new List<Stack<int>>();
            for (int i = 0; i <= 9; i++)
                san.Add( new Stack<int>());
            int n = 3;
            for (int j = 0; j < n; j++)
            {
                while (kq.Count > 0)
                {
                    int so = kq.Pop();
                    int gtss = so / (int)Math.Pow(10, j) % 10;
                    san[gtss].Push(so);
                }
                for (int i=0;i<=9;i++)
                    while (san[i].Count > 0)
                    {
                        kq.Push(san[i].Pop());
                    }    
            }
            while (kq.Count > 0)
            {
                Console.WriteLine(kq.Pop());
            }
        }
    }
}
