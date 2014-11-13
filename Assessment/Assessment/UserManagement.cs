using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Assessment
{
    public partial class UserManagement : UserControl
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        DataTable dt;
        MySqlDataAdapter da;

        private void UserManagement_Load(object sender, EventArgs e)
        {
            GridView_Bind();
        }

        private void GridView_Bind()
        {
            string connStr = PublicParms.ConnStr;
            string SqlStr = "select 编号,姓名,职称,工作单位,联系电话,是否管理员 from _tbuser";

            conn = new MySqlConnection(connStr);
            dt = new DataTable();

            try
            {
                conn.Open();
                da = new MySqlDataAdapter(SqlStr, conn);
                da.Fill(dt);
                GridView.DataSource = dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //绘制行号
        private void GridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) 
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                GridView.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                GridView.RowHeadersDefaultCellStyle.Font,
                rectangle,
                GridView.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);

            /*int width = 0;
            for (int i = 0; i < GridView.Columns.Count; i++)
            {
                width += GridView.Columns[i].Width;
            }
            if (width < GridView.Width)
            {
                GridView.Columns.Add("", "");
                GridView.Columns[GridView.Columns.Count - 1].Width = GridView.Width - width;
            }
            */
        }

        private void ChooseAll_Click(object sender, EventArgs e)
        {
            int counts = GridView.Rows.Count;
            for (int i = 0; i < counts; i++)
            {

                if (GridView.Rows[i].Selected == false)
                {
                    GridView.Rows[i].Selected = true;
                }
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(GridView.GetClipboardContent());
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("更新成功！");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    GridView.ClearSelection();
                    //若行已是选中状态就不再进行设置 
                    if (GridView.Rows[e.RowIndex].Selected == false)
                    {
                        GridView.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格 
                    if (GridView.SelectedRows.Count == 1)
                    {
                        GridView.CurrentCell = GridView.Rows[e.RowIndex].Cells[0];
                    }                    
                    //弹出操作菜单 
                    MenuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除行吗？", "确认删除",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow dr in GridView.SelectedRows)
                {
                    GridView.Rows.Remove(dr);
                }
            }

        }

        private void AddRowUp_Click(object sender, EventArgs e)
        {
            //this.dt = (DataTable)GridView.DataSource;
            DataRow dr = dt.NewRow();
            dr[0] = null;
            dt.Rows.InsertAt(dr, GridView.CurrentRow.Index);
        }

        private void AddRowdown_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, GridView.CurrentRow.Index+1);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            GridView_Bind();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            //设置文件类型
            openDialog.Filter = "Excel 工作簿(*.xlsx)|*.xlsx|Excel 97-2003工作簿(*.xls)|*.xls";
            //设置默认文件类型显示顺序
            openDialog.FilterIndex = 1;
            //保存对话框是否记忆上次打开的目录
            openDialog.RestoreDirectory = true;
            //点了保存按钮进入
            if (openDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

    }
}
