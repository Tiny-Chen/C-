using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryClass;//添加引用后，导入命名空间
using UsbComponentClass;

namespace _04多类简单工厂主程序
{
    class Program
    {
        static void Main(string[] args)
        {
            /*项目分主程序、工厂类库、设备类库、设备父类类库
             * 类库（DLL）的作用就是方便升级维护，增加或删除只需要修改类库即可实现（可查看生成目录下，类库都生成为DLL了）
             * 主程序创建设备父类对象，根据用户选择，工厂进行生产，返回产品给父类，父类调用方法实现
             * 调用方法时，父类对象装的是子类对象，所以方法被子类改写
             * 更新的时候，只需要修改类库（DLL），然后把这个类库替换掉就好了
             */
            Console.WriteLine("请输入插入的设备序号");
            Console.WriteLine("1、U盘；2、鼠标；3、MP3");
            int number = int.Parse(Console.ReadLine());

            //创建设备父类对象给工厂
            UsbComponent Usb = Factory.Usb(number);

            if (Usb != null)
            {
                //实现方法
                Usb.Inseter();
            }
            else
            {
                Console.WriteLine("请选择正确的序号");
            }

            Console.ReadKey();

        }
    }
}
