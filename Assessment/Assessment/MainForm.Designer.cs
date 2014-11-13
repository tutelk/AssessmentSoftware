namespace Assessment
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TopSplitter = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AssessmentLeafNode = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.SetWeight = new System.Windows.Forms.Button();
            this.AssessmentResult = new System.Windows.Forms.Button();
            this.NodeManagement = new System.Windows.Forms.Button();
            this.PersonnelManagement = new System.Windows.Forms.Button();
            this.AssessmentProgress = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1157, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 20);
            this.toolStripStatusLabel1.Text = "欢迎使用本系统：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(742, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabel3.Text = "系统当前时间：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("华文新魏", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TopLabel.Location = new System.Drawing.Point(63, 28);
            this.TopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(416, 44);
            this.TopLabel.TabIndex = 4;
            this.TopLabel.Text = "半物理仿真评估系统";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WelcomeLabel.Location = new System.Drawing.Point(949, 64);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(108, 25);
            this.WelcomeLabel.TabIndex = 5;
            this.WelcomeLabel.Text = "欢迎您：";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(1056, 65);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "刘坤";
            // 
            // TopSplitter
            // 
            this.TopSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSplitter.Location = new System.Drawing.Point(0, 0);
            this.TopSplitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopSplitter.Name = "TopSplitter";
            this.TopSplitter.Size = new System.Drawing.Size(1157, 99);
            this.TopSplitter.TabIndex = 2;
            this.TopSplitter.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 99);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.AssessmentProgress);
            this.splitContainer1.Panel1.Controls.Add(this.AssessmentLeafNode);
            this.splitContainer1.Panel1.Controls.Add(this.Exit);
            this.splitContainer1.Panel1.Controls.Add(this.ChangePassword);
            this.splitContainer1.Panel1.Controls.Add(this.SetWeight);
            this.splitContainer1.Panel1.Controls.Add(this.AssessmentResult);
            this.splitContainer1.Panel1.Controls.Add(this.NodeManagement);
            this.splitContainer1.Panel1.Controls.Add(this.PersonnelManagement);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(1157, 579);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 8;
            // 
            // AssessmentLeafNode
            // 
            this.AssessmentLeafNode.Location = new System.Drawing.Point(44, 219);
            this.AssessmentLeafNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessmentLeafNode.Name = "AssessmentLeafNode";
            this.AssessmentLeafNode.Size = new System.Drawing.Size(148, 32);
            this.AssessmentLeafNode.TabIndex = 6;
            this.AssessmentLeafNode.Text = "叶节点评估";
            this.AssessmentLeafNode.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(44, 445);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(148, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "退出系统";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.ChangePassword.Location = new System.Drawing.Point(44, 384);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(148, 32);
            this.ChangePassword.TabIndex = 4;
            this.ChangePassword.Text = "修改密码";
            this.ChangePassword.UseVisualStyleBackColor = true;
            // 
            // SetWeight
            // 
            this.SetWeight.Location = new System.Drawing.Point(44, 155);
            this.SetWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetWeight.Name = "SetWeight";
            this.SetWeight.Size = new System.Drawing.Size(148, 32);
            this.SetWeight.TabIndex = 3;
            this.SetWeight.Text = "设置权重";
            this.SetWeight.UseVisualStyleBackColor = true;
            // 
            // AssessmentResult
            // 
            this.AssessmentResult.Location = new System.Drawing.Point(44, 328);
            this.AssessmentResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessmentResult.Name = "AssessmentResult";
            this.AssessmentResult.Size = new System.Drawing.Size(148, 32);
            this.AssessmentResult.TabIndex = 2;
            this.AssessmentResult.Text = "评估结果";
            this.AssessmentResult.UseVisualStyleBackColor = true;
            // 
            // NodeManagement
            // 
            this.NodeManagement.Location = new System.Drawing.Point(44, 98);
            this.NodeManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NodeManagement.Name = "NodeManagement";
            this.NodeManagement.Size = new System.Drawing.Size(148, 32);
            this.NodeManagement.TabIndex = 1;
            this.NodeManagement.Text = "节点管理";
            this.NodeManagement.UseVisualStyleBackColor = true;
            // 
            // PersonnelManagement
            // 
            this.PersonnelManagement.Location = new System.Drawing.Point(44, 39);
            this.PersonnelManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonnelManagement.Name = "PersonnelManagement";
            this.PersonnelManagement.Size = new System.Drawing.Size(148, 34);
            this.PersonnelManagement.TabIndex = 0;
            this.PersonnelManagement.Text = "评估人员管理";
            this.PersonnelManagement.UseVisualStyleBackColor = true;
            // 
            // AssessmentProgress
            // 
            this.AssessmentProgress.Location = new System.Drawing.Point(44, 270);
            this.AssessmentProgress.Margin = new System.Windows.Forms.Padding(4);
            this.AssessmentProgress.Name = "AssessmentProgress";
            this.AssessmentProgress.Size = new System.Drawing.Size(148, 32);
            this.AssessmentProgress.TabIndex = 7;
            this.AssessmentProgress.Text = "评估进度";
            this.AssessmentProgress.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 703);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.TopSplitter);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "评估系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Splitter TopSplitter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button SetWeight;
        private System.Windows.Forms.Button AssessmentResult;
        private System.Windows.Forms.Button NodeManagement;
        private System.Windows.Forms.Button PersonnelManagement;
        private System.Windows.Forms.Button AssessmentLeafNode;
        private System.Windows.Forms.Button AssessmentProgress;
    }
}

