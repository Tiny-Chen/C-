using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14阅读器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">事件</param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //把TAG中存储的路径转为字符串路径
            string path = e.Node.Tag as string;
            if (path != null && File.Exists(path))
            {
                //如果文件不为空且存在,就把文本读出来
                textBox1.Text = File.ReadAllText(path,Encoding.Default);
            }
        }
        /// <summary>
        /// 窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //添加根
            TreeNode tn = treeView1.Nodes.Add("神探小说");
            //添加子节点及文件节点
            LodaDate(tn,"txt");
        }

        /// <summary>
        /// 递归添加文件夹及文件到根节点
        /// </summary>
        /// <param name="tn">根节点</param>
        /// <param name="path">路径</param>
        private void LodaDate(TreeNode tn, string path)
        {
            //获取子目录及路径
            string[ ]dir = Directory.GetDirectories(path);
            //获取文件名称及路径
            string[] file = Directory.GetFiles(path);

            //循环添加子目录到节点上
            for (int i = 0; i < dir.Length; i++)
            {
                //把名称添加到子目录上，使用path，因为只要名称
                TreeNode tn1 = tn.Nodes.Add(Path.GetFileName(dir[i]));
                //递归实现添加所有子目录
                LodaDate(tn1,dir[i]);
            }
            for (int i = 0; i < file.Length; i++)
            {
                //把文件名添加到节点下
                TreeNode tn2 = tn.Nodes.Add(Path.GetFileName(file[i]));
                //使用TAG来存储文件的路径及文件名，方便的开时调用
                tn2.Tag = file[i];
            }
        }
    }
}
