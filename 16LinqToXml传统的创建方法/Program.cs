using System;
using System.Xml.Linq;

namespace _16LinqToXml传统的创建方法
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //传统的Linq方法逻辑上与XML的创建是一样的，只不过是更加方便了许多
            //命名空间System.XML.Linq;
            //XDocument;
            //XElement;
            //XAttribute;

            //创建文档
            XDocument xDoc = new XDocument();
            //文档头已默认带有，不需要我们去创建，默认编码是UTF-8,如需不同的编码可自己创建文档头

            //创建节点元素-----使用new的方法来创建
            XElement xele = new XElement("root");
            xele.Value = "我是节点文本";

            //添加属性-----使用new的方法来创建
            XAttribute xAttri = new XAttribute("id","12345");

            //把节点添加到文档
            xDoc.Add(xele);
            //把属性添加到节点
            xele.Add(xAttri);

            //保存
            xDoc.Save("1.xml");


            //<?xml version="1.0" encoding="utf-8"?>
            // < root id = "12345" > 我是节点文本 </ root >
        }
    }
}
