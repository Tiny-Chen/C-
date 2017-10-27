using System;
using System.Xml.Linq;

namespace _17Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //F# 函数式编程
            //语法
            //XDocument xDoc = new XDocument(
            //    new XElement("root",
            //    new XAttribute("id","12345"),"节点文本"
            //    ).Save("1.xml")
            //    );

            //示例
            XDocument xdoc = new XDocument(new XElement("root"));//创建根节点root
            string[] str = "张三，李四，王五，赵六，田七".Split('，');
            Random r = new Random();
            for (int i = 0; i < str.Length; i++)
            {
                xdoc.Root.Add(new XElement("Preson",       //创建元素节点
                    new XAttribute("id",i+1),                          //属性1
                    new XAttribute("测试属性","测试数据"),       //属性2
                    new XElement("name",str[i]),                    //元素子节点
                    new XElement("sex","男女"[r.Next(2)]),        //元素子节点
                    new XElement("age",r.Next(18,30))           //元素子节点
                    ));
            }
            xdoc.Save("1.xml");

            /*
                <? xml version = "1.0" encoding = "utf-8" ?>
                < root >   
                        < Preson id = "1" 测试属性 = "测试数据" >      
                            < name > 张三 </ name >      
                            < sex > 男 </ sex >      
                            < age > 25 </ age >      
                        </ Preson >      
                        < Preson id = "2" 测试属性 = "测试数据" >         
                            < name > 李四 </ name >         
                            < sex > 男 </ sex >         
                            < age > 24 </ age >         
                        </ Preson >         
                        < Preson id = "3" 测试属性 = "测试数据" >            
                            < name > 王五 </ name >            
                            < sex > 女 </ sex >            
                            < age > 23 </ age >            
                        </ Preson >            
                < Preson id = "4" 测试属性 = "测试数据" >               
                < name > 赵六 </ name >               
                < sex > 女 </ sex >               
                < age > 22 </ age >               
                </ Preson >               
                < Preson id = "5" 测试属性 = "测试数据" >                  
                < name > 田七 </ name >                  
                < sex > 女 </ sex >                  
                < age > 29 </ age >                  
                </ Preson >
                </ root >
                */

        }
    }
}
