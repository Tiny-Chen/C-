namespace _13treeview树状节点
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tvTree = new System.Windows.Forms.TreeView();
            this.btnNodeRoot = new System.Windows.Forms.Button();
            this.btnSubNode = new System.Windows.Forms.Button();
            this.tvName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvTree
            // 
            this.tvTree.HideSelection = false;
            this.tvTree.Location = new System.Drawing.Point(-1, -1);
            this.tvTree.Name = "tvTree";
            this.tvTree.Size = new System.Drawing.Size(300, 610);
            this.tvTree.TabIndex = 0;
            this.tvTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTree_AfterSelect);
            // 
            // btnNodeRoot
            // 
            this.btnNodeRoot.Location = new System.Drawing.Point(306, 12);
            this.btnNodeRoot.Name = "btnNodeRoot";
            this.btnNodeRoot.Size = new System.Drawing.Size(75, 23);
            this.btnNodeRoot.TabIndex = 1;
            this.btnNodeRoot.Text = "添加根节点";
            this.btnNodeRoot.UseVisualStyleBackColor = true;
            this.btnNodeRoot.Click += new System.EventHandler(this.btnNodeRoot_Click);
            // 
            // btnSubNode
            // 
            this.btnSubNode.Location = new System.Drawing.Point(431, 12);
            this.btnSubNode.Name = "btnSubNode";
            this.btnSubNode.Size = new System.Drawing.Size(75, 23);
            this.btnSubNode.TabIndex = 2;
            this.btnSubNode.Text = "添加节子点";
            this.btnSubNode.UseVisualStyleBackColor = true;
            this.btnSubNode.Click += new System.EventHandler(this.button2_Click);
            // 
            // tvName
            // 
            this.tvName.Location = new System.Drawing.Point(306, 61);
            this.tvName.Name = "tvName";
            this.tvName.Size = new System.Drawing.Size(100, 25);
            this.tvName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 610);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tvName);
            this.Controls.Add(this.btnSubNode);
            this.Controls.Add(this.btnNodeRoot);
            this.Controls.Add(this.tvTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvTree;
        private System.Windows.Forms.Button btnNodeRoot;
        private System.Windows.Forms.Button btnSubNode;
        private System.Windows.Forms.TextBox tvName;
        private System.Windows.Forms.Button btnSave;
    }
}

