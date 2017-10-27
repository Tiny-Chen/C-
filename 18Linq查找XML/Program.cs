using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18Linq查找XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //加载XML文件
            XDocument xdoc = XDocument.Load("1.xml");
            //把查找到的元素保存到集合中
            List<XElement> list = new List<XElement>();
            SearchElement(xdoc.Root,list,"name","田七");
            foreach (var item in list)
            {
                Console.WriteLine("{0}----{1}",item.Name.LocalName,item.Value);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 递归查找元素
        /// </summary>
        /// <param name="ele">根节点</param>
        /// <param name="list">保存的集合</param>
        /// <param name="name">查找的元素名</param>
        /// <param name="value">查找的元素文本</param>
        private static void SearchElement(XElement ele, List<XElement>list,string name,string value)
        {
            //通过循环来查找这个元素---xelement是个ienum<>接口集合，所以可以用foreach
            foreach (XElement item in ele.Elements())
            {
                //判断是否有这个元素
                if (item.Name.LocalName == name)
                {
                    //有这个元素，那么值是不是要查找的
                    if (item.Value == value)
                    {
                        //如果是，那么把节点添加到集合中，这里是添加父节点
                        list.Add(item.Parent);
                    }
                }
                //递归查找所有子节点
                SearchElement(item,list,name,value);
            }

        }
    }
}
