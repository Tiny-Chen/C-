using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13treeview树状节点
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int index = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //首先判断选择的节点是哪里，然后在其下添加子节点
           TreeNode tn = tvTree.SelectedNode;
            tn.Nodes.Add("子节点"+index++).BackColor=Color.CadetBlue;
        }

        /// <summary>
        /// 添加根节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNodeRoot_Click(object sender, EventArgs e)
        {
            //添加根节点，并设置背景色
            tvTree.Nodes.Add("节点" + index++).BackColor=Color.Bisque;
        }

        /// <summary>
        /// 显示选定的节点名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = tvTree.SelectedNode;
            tvName.Text = tn.Text;
        }

        /// <summary>
        /// 名称修改后保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvTree.SelectedNode;
            tn.Text = tvName.Text;
        }
    }
}
