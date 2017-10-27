using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace _12序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //二进制序列化---------------------------------
            //创建1个类，标记可以序列化--Addres
            //创建序列化对象
            BinaryFormatter bf = new BinaryFormatter();
            //创建流---文件不需要后缀名，因为不知道是什么格式
            //using (FileStream fs = new FileStream("date",FileMode.Create,FileAccess.Write))
            //{
            //    //调用Serialize方法进行序列化
            //    bf.Serialize(fs,new Address(){Name = "张三",Id = 12345});
            //}

            //反序列化
            //using (FileStream fs = new FileStream("date", FileMode.Open, FileAccess.Read))
            //{
            //    Address a = bf.Deserialize(fs) as Address;
            //    Console.WriteLine(a.Name);
            //    Console.WriteLine(a.Id);
            //}
            //Console.ReadKey();

            //XML序列化------------------------------
            //给需要序列化的类赋值,只是方便我们练习查看数值
            //Address a = new Address(){Name = "李四",Id = 123};
            //创建XML序列化对象
            //XmlSerializer xf = new XmlSerializer(typeof(Address));//固定语法
            //创建流
            //using (FileStream fs = new FileStream("xmls",FileMode.Create,FileAccess.Write))
            //{
                //调用方法进行序列化
           //     xf.Serialize(fs,a);
            //}

            //反序列化
            //XmlSerializer xf = new XmlSerializer(typeof(Address));
            //using (FileStream fs = new FileStream("xmls",FileMode.Open,FileAccess.Read))
            //{
            //    Address address = xf.Deserialize(fs) as Address;
            //    Console.WriteLine(address.Id);
            //    Console.WriteLine(address.Name);
            //}
            //Console.ReadKey();

            //JavaScriptSerialize序列化-------------------------------------------
            //1、添加web.Extension引用----引用---程序集中
            //2、创建需要序列化的对象
            Address a = new Address(){Name = "王五",Id = 4567};
           //3、创建JSON序列化对象
           JavaScriptSerializer jf = new JavaScriptSerializer();
            //4、序列化，并返回字符串接收（JSON格式）
            string js = jf.Serialize(a);
            Console.WriteLine(js);
            Console.ReadKey();
        }
    }
}
