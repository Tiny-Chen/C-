using System;
using System.Xml;

namespace _15传统写法的XML创建
{
    class Program
    {
        static void Main(string[] args)
        {
            //类名空间：System.xml;
            //类库
            //XmlDocument;  创建文档
            //XmlElement;     文档元素
            //XmlAttribute;   文档属性
            //XmlDeclaration;  文档节点
            //XmlText;      文本节点

            //创建文档
            XmlDocument xdoc = new XmlDocument();
            //创建文档头节点----所有的元素都是在节点之下
            XmlDeclaration xdec = xdoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //追加到文档
            xdoc.AppendChild(xdec);

            //创建元素---创建节点元素
            XmlElement xele = xdoc.CreateElement("root");
            //追加到文档
            xdoc.AppendChild(xele);

            //创建带属性的节点
            XmlAttribute xAttr = xdoc.CreateAttribute("id");
            xAttr.Value = "12345";//给属性赋值

            //给属性添加文本
            XmlText tex = xdoc.CreateTextNode("文本节点内容");
            //添加到节点下
            xele.AppendChild(tex);
            //把属性添加到节点
            xele.Attributes.Append(xAttr);

            //保存
            xdoc.Save("1.xml");
            /*
             * <?xml version="1.0" encoding="UTF-8"?>
                <root id="12345">文本节点内容</root>
                */
        }
    }
}
