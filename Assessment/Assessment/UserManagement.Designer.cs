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
            this.Export = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddRowUp = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRowDown = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
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
            this.GridView.Location = new System.Drawing.Point(35, 87);
            this.GridView.Margin = new System.Windows.Forms.Padding(4);
            this.GridView.Name = "GridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.Size = new System.Drawing.Size(945, 440);
            this.GridView.TabIndex = 0;
            this.GridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_CellMouseDown);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // Export
            // 
            this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Export.Location = new System.Drawing.Point(640, 575);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(109, 35);
            this.Export.TabIndex = 4;
            this.Export.Text = "导出";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update.Location = new System.Drawing.Point(261, 575);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(109, 35);
            this.Update.TabIndex = 5;
            this.Update.Text = "更新";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRowUp,
            this.AddRowDown,
            this.Delete});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(154, 76);
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
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.GridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(1019, 641);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem AddRowUp;
        private System.Windows.Forms.ToolStripMenuItem AddRowDown;



    }
}
