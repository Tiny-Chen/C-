using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28自定义排序
{
    class Program
    {
        #region 以前的做法

        /*
        //2、定义委托
        public delegate int GetDelegate(string s1, string s2);
        static void Main(string[] args)
        {
            string[] arr = { "10", "14", "100", "89","5","234"};
            //3、声明委托 
            GetDelegate getDelegate;
            //4、授权方法
            getDelegate = GetResult;
            //5、调用方法
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    //调用方法
                    if (getDelegate(arr[j],arr[j+1])>0)
                    {
                        string t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
        }
        //1、定义比较的方法
        static int GetResult(string s1, string s2)
        {
            return int.Parse(s1) - int.Parse(s2);
        }
    }
    */

        #endregion

        #region 更进一步的方法，把委托调用做成方法，偶合性更低

        /*
       //2、定义委托
       public delegate int GetDelegate(string s1, string s2);
       static void Main(string[] args)
       {
           string[] arr = { "10", "14", "100", "89","5","234"};
           //3、声明委托 
           GetDelegate getDelegate;
           //4、授权方法
           getDelegate = GetResult;
           //getDelegate += string.Compare;
           //5、调用方法
           MySort(arr,getDelegate);
           Console.ReadKey();
       }
       //1、定义比较的方法
       static int GetResult(string s1, string s2)
       {
           return int.Parse(s1) - int.Parse(s2);
       }

        //定义一个方法,用来接收传入的数组，委托，我们可以根据不同的方法进行不同的比较
        static void MySort(string[]arr, GetDelegate getDelegate)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //调用方法
                    if (getDelegate(arr[j], arr[j + 1]) > 0)
                    {
                        string t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
        }
        */

        #endregion

        //最简洁的方法 Lamdba表达式

         //1、定义委托
        public delegate int GetDelegate(string s1, string s2);

        static void Main(string[] args)
        {
            string[] arr = {"10", "14", "100", "89", "5", "234"};

            //3、使用Lamdba表达式
            //通过表达式，更方便的使用各种比较
            MySort(arr, (a, b) => Int32.Parse(a) - Int32.Parse(b));
            //MySort(arr,(a,b)=>string.Compare(a,b));

            Console.ReadKey();
        }

        //2、定义委托调用的方法
        static void MySort(string[] arr, GetDelegate getDelegate)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //调用方法
                    if (getDelegate(arr[j], arr[j + 1]) > 0)
                    {
                        string t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
        }

    }
}
