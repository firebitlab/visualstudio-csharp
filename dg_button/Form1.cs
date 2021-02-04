using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_dg_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //INSERT TO DATAGRID
            int rowId = dataGridView_main.Rows.Add();
            DataGridViewRow row = dataGridView_main.Rows[rowId];
            row.Cells["Column1"].Value = "Value1";
            row.Cells["Column2"].Value = "Value2";

            rowId = dataGridView_main.Rows.Add();
            row = dataGridView_main.Rows[rowId]; 
            row.Cells["Column1"].Value = "Value3";
            row.Cells["Column2"].Value = "Value4";

            rowId = dataGridView_main.Rows.Add();
            row = dataGridView_main.Rows[rowId];
            row.Cells["Column1"].Value = "Value5";
            row.Cells["Column2"].Value = "Value6";

            rowId = dataGridView_main.Rows.Add();
            row = dataGridView_main.Rows[rowId];
            row.Cells["Column1"].Value = "Value7";
            row.Cells["Column2"].Value = "Value8";

            rowId = dataGridView_main.Rows.Add();
            row = dataGridView_main.Rows[rowId];
            row.Cells["Column1"].Value = "Value9";
            row.Cells["Column2"].Value = "Value10";

            //INSERT TO DATAGRID


            //ADD BUTTON
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "button_1";
            uninstallButtonColumn.Text = "EDIT";
            uninstallButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex = 2;
            if (dataGridView_main.Columns["button_1"] == null)
            {
                dataGridView_main.Columns.Insert(columnIndex, uninstallButtonColumn);
            }

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "button_2";
            editButtonColumn.Text = "DELETE";
            editButtonColumn.UseColumnTextForButtonValue = true;
            columnIndex = 3;
            if (dataGridView_main.Columns["button_2"] == null)
            {
                dataGridView_main.Columns.Insert(columnIndex, editButtonColumn);
            }
            //ADD BUTTON


        }

        private void dataGridView_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == dataGridView_main.Columns["button_1"].Index)
            {
                MessageBox.Show(dataGridView_main.SelectedRows[0].Cells[0].Value.ToString());
            }
            else if (e.ColumnIndex == dataGridView_main.Columns["button_2"].Index)
            {
                MessageBox.Show(dataGridView_main.SelectedRows[0].Cells[1].Value.ToString());
            }


        }
    }
}
