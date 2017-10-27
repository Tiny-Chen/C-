using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20Linq查询语法
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("1.xml");
            //第一种：查询语法（类似SQL语句）
            //var query = from s in xdoc.Descendants()
            //    where s.Name.LocalName == "name" && s.Value == "张三"
            //    select s.Parent;
            //foreach (XElement item in query)
            //{
            //    Console.WriteLine("{0}----{1}",item.Name.LocalName,item.Value);
            //}
            //Console.ReadKey();

            //第二种查询方法（lambda表达式）
            foreach (XElement i in xdoc.Descendants().Where(e =>
            {
                if (e.Name.LocalName == "name")
                {
                    if(e.Value=="张三")
                    {
                        return true;
                    }
                }
                return false;
            }))
            {
                XElement obj = i.Parent;
            }
        }
    }
}
