using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Linq查询Lambda实现
{
    class Program
    {
        public delegate bool ChackDelegate(int num);
        static void Main(string[] args)
        {
            //求所有偶数
            int[] nums = {1, 12, 34, 56, 57, 89, 101, 103, 100};

          int[] n =  GetResult(nums,e=>e%2==0); //把需要的数组传进去，然后通过Lambda把这个方法体传进去，进行判断----ck(num[i])
        }

        //1、准备方法(需要1个判断是否符合一定要求的方法，所以要定义布尔委托)
        static int[] GetResult(int[]num, ChackDelegate ck)
        {
            List<int> n = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                //委托一个的方法,判断这个数是否符合要求
                if (ck(num[i]))//------------------------根据传入的方法，代入运算中,e%2==0
                {
                    n.Add(num[i]);
                }
            }
            return n.ToArray();
        }
    }
}
