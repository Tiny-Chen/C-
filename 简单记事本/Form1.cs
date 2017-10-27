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

namespace 简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //写在using中，这样在后面不需要手动销毁弹出的窗体
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //创建通用对话框,带返回值的---show是不带返回值的
                DialogResult res = ofd.ShowDialog();
                //判断用户是否按下确定键
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    //读取用户选择的文件，显示在文本框内
                    textBox1.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                    
                }
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                //定义文件后缀名
                sfd.Filter = "文本文件|*.txt";
                //判断用户是否按下确定
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName,textBox1.Text);
                }
            }
        }

        private void 字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.ForeColor = cd.Color;
                }
            }
        }

        private void 字体格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Font = fd.Font;
                   
                }
            }
        }
    }
}
