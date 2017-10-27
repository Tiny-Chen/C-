using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07文件流FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream
            //字节形式写入
            #region writebyte
            //using (FileStream fwrite = new FileStream("txt.txt", FileMode.Create, FileAccess.Write))
            //{
            //    //直接写入一个字节
            //    //fwrite.WriteByte(97);//---a

            //    //输入中读取
            //    string s = Console.ReadLine();

            //    //统一编码
            //    //default编码、unicode编码等等
            //    byte[] bs = Encoding.Default.GetBytes(s);
            //   其他编码的话，需首先写入编码标记，如unicode编码，那么要先写入ff fe
            //   fwrite.WriteByte(255);//----ff
            //   fwrite.WriteByte(254);//----fe
            //    //循环写入文件
            //    for (int i = 0; i < bs.Length; i++)
            //    {
            //        fwrite.WriteByte(bs[i]);
            //    }
            //    Console.WriteLine("写入成功");
            //    Console.ReadKey();
            //} 
            #endregion

            //字节数组（字节块）方式写入
            #region Write
            //using (FileStream fwrite = new FileStream("txt.txt",FileMode.Create,FileAccess.Write))
            //{
            //    //               a    b   c   0   1  2   9   A  B-----十六进制
            //    byte[] bs = {97,98,99,48,49,50,57,65,66 };
            //    fwrite.Write(bs,0,bs.Length);
            //    Console.WriteLine("写入成功");
            //    Console.ReadKey();
            //} 
            #endregion

            //按字节读
            #region readByte
            //using (FileStream fsRead = new FileStream("txt.txt",FileMode.Open,FileAccess.Read))
            //{
            //    //创建一个列表用来保存读取出来字节
            //    List<byte> list = new List<byte>();
            //    int res = -1;//临时变量，用来保存字节和判断是否读取结束了，如果是结尾，那么返回-1
            //    while ((res = fsRead.ReadByte())!=-1)
            //    {
            //        list.Add((byte)res);
            //    }
            //} 
            #endregion

            //按字节数组（字节块）读
            #region read
            //using (FileStream fsRead = new FileStream("txt.txt",FileMode.Open,FileAccess.Read))
            //{
            //    //用数组来存储1个块字节(数组缓存)
            //   // byte[] buffer = new byte[1024*1024];
            //    byte[] bs = new byte[10];//----练习中txt字节少，以只是10个位置读就够了

            //    int cont =fsRead.Read(bs, 0, bs.Length);
            //    Console.WriteLine("读取成功");
            //} 
            #endregion

            //案例:复制文件

            //复制
            Console.WriteLine("请输入要复制的文件及路径");
            string fileSource = Console.ReadLine();

            //判断指定文件是否存在
            if (!File.Exists(fileSource))
            {
                Console.WriteLine("文件有误，按任意键结束");
                Console.ReadKey();
                return;
            }
            //存在文件
            Console.WriteLine("请输入要保存的路径及名称");
            string fileSave = Console.ReadLine();

            //文件流读处理
            using (FileStream fsRead = new FileStream(fileSource, FileMode.Open, FileAccess.Read))
            {
                //写文件流处理
                using (FileStream fsWrite = new FileStream(fileSave,FileMode.Create,FileAccess.Write))
                {
                    //建立读取和写入字节的缓存大小
                    byte[] buffer = new byte[1024*1024*10];
                    //写入的长度
                    int cont = 0;
                    //循环，读一个写一个
                    while ((cont = fsRead.Read(buffer,0,buffer.Length))>0)
                    {
                        fsWrite.Write(buffer,0,cont);
                    }
                }
            }
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
    }
}
