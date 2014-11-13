namespace Assessment
{
    partial class UserManagement
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ExportButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddRowUp = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRowDown = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseAll = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.GridView.Location = new System.Drawing.Point(35, 88);
            this.GridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridView.Name = "GridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.Size = new System.Drawing.Size(945, 440);
            this.GridView.TabIndex = 0;
            this.GridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_CellMouseDown);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(779, 575);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(109, 35);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "导出";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.Export_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Location = new System.Drawing.Point(131, 575);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(109, 35);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "更新数据";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.Update_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseAll,
            this.Copy,
            this.AddRowUp,
            this.AddRowDown,
            this.Delete});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(154, 124);
            // 
            // AddRowUp
            // 
            this.AddRowUp.Name = "AddRowUp";
            this.AddRowUp.Size = new System.Drawing.Size(153, 24);
            this.AddRowUp.Text = "上方插入行";
            this.AddRowUp.Click += new System.EventHandler(this.AddRowUp_Click);
            // 
            // AddRowDown
            // 
            this.AddRowDown.Name = "AddRowDown";
            this.AddRowDown.Size = new System.Drawing.Size(153, 24);
            this.AddRowDown.Text = "下方插入行";
            this.AddRowDown.Click += new System.EventHandler(this.AddRowdown_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(153, 24);
            this.Delete.Text = "删除";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RefreshButton.Location = new System.Drawing.Point(463, 575);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(109, 35);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "刷新显示";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(153, 24);
            this.Copy.Text = "复制";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // ChooseAll
            // 
            this.ChooseAll.Name = "ChooseAll";
            this.ChooseAll.Size = new System.Drawing.Size(153, 24);
            this.ChooseAll.Text = "全选";
            this.ChooseAll.Click += new System.EventHandler(this.ChooseAll_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.GridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(1019, 641);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem AddRowUp;
        private System.Windows.Forms.ToolStripMenuItem AddRowDown;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ToolStripMenuItem ChooseAll;
        private System.Windows.Forms.ToolStripMenuItem Copy;



    }
}
