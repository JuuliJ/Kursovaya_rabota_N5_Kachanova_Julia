using System;
using System.Windows.Forms;

namespace ProgramDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void scoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scoreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Score". При необходимости она может быть перемещена или удалена.
            this.scoreTableAdapter.Fill(this.database1DataSet.Score);

        }

        private void GroupToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoreTableAdapter.FillBy1(this.database1DataSet.Score, GroupToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
