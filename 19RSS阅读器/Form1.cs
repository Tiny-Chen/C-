using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _19RSS阅读器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载RSS
            XDocument xdoc = XDocument.Load("RSS.xml");
            //添加treeview根节点
            TreeNode tn = treeView1.Nodes.Add("百度新闻");
            //调用方法，把节点元素添加到树状表中
            LoadDate(xdoc.Root,tn);
        }

        private static void LoadDate(XElement ele, TreeNode tn)
        {
            //通过循环把XML里的节点元素添加到treeview中
            foreach (XElement item in ele.Elements())
            {
                //把带命名空间的每个节点名称添加到treeview里
                TreeNode tn1 = tn.Nodes.Add(item.Name.ToString());
                //判断是否只有1个元素,只有1个元素，那么说明是最后的节点元素，就把文本内容保存下来，在treeview点击时，显示在右边
                if (!item.HasElements)
                {
                    //如果只有1个元素，那么把值保存到标签中
                    tn1.Tag = item.Value;
                }
                //通过递归把所有节点添加进来
                LoadDate(item,tn1);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //把保存在TAG标签中的值，转换为字符串
            string html = e.Node.Tag as string;
            //判断这个值是否为空
            if (html != null)
            {
                //显示HTML页内容
                webBrowser1.DocumentText = html;
                //textBox1.Text = html;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
