using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1momot
{
    public partial class FormClick : Form
    {
        public FormClick()
        {
            InitializeComponent();
        }

        private void FormClick_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet1.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.sport_clubDataSet1.Залы);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet1.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet1.Учет);
          

        }

        private void выйтиНавсегдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.абонементыTableAdapter.FillBy(this.sport_clubDataSet1.Абонементы);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.запрос4TableAdapter.FillBy(this.sport_clubDataSet1.Запрос4);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
