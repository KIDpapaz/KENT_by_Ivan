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
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Потом будет
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdkDataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.bdkDataSet.Таблица1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Найти тему
            таблица1BindingSource.Filter = "Тема = \'" + richTextBox1.Text + "\'"; 
        }


        //Открытие форм2 братие кординат и присваивание всяких wiki и сайтов
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Берёт индекс куда нажмёт пользователь(Кординаты)
            int a = dataGridView1.CurrentCell.RowIndex;
            int b = dataGridView1.CurrentCell.ColumnIndex;




            





            //Это открытие 2 формы и передача данных
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
    }
}