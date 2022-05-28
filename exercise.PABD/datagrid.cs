using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise.PABD
{
    public partial class datagrid : Form
    {
        public datagrid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            DG.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgview dgv = new dgview();
            dgv.NIM.Text = this.DG.CurrentRow.Cells[0].Value.ToString();
            dgv.NM.Text = this.DG.CurrentRow.Cells[1].Value.ToString();
            dgv.AM.Text = this.DG.CurrentRow.Cells[2].Value.ToString();
            dgv.JK.Text = this.DG.CurrentRow.Cells[3].Value.ToString();
            dgv.NT.Text = this.DG.CurrentRow.Cells[4].Value.ToString();

            dgv.Show();


            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            //Costumizing onload table background
            DG.Columns[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Purple;
            DG.Columns[1].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            DG.Columns[2].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkCyan;
            DG.Columns[3].DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
            DG.Columns[4].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            //Textalignment for specific cell / header
            DG.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //text style for header
            DG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

        }


        private void DG_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Pink;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
                //DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Pink;
                //DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Orange;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.DodgerBlue;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.SaddleBrown;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
        }

        private void DG_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Purple;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Blue;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkCyan;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Green;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                DG[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}

