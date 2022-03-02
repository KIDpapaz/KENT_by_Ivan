using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KENT
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Descending);
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdkDataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            //this.таблица1TableAdapter.Fill(this.bdkDataSet.Таблица1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.Filter = "Тема = \'" + richTextBox1.Text + "\'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Ascending);
        }
    }
}
