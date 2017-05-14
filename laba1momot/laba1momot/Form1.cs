using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace laba1momot
{
    public partial class Form1 : Form
    {
        FormClick clickform = new FormClick();
        FormAbout about = new FormAbout();
        SqlConnection sc = new SqlConnection("Data Source='C: /Users/Skripnik/documents/visual studio 2017/Projects/laba1momot/laba1momot/sport_club.mdb'");




        public Image MyPictureName1 { get; private set; }
        private const string helpfile = @"c:\help.chm";
        
        private const string KeywInd = "dbgrid";
        public Form1()
        {
            InitializeComponent();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
       

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.sport_clubDataSet.Залы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet2.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet2.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Абонементы". При необходимости она может быть перемещена или удалена.
            this.абонементыTableAdapter.Fill(this.sport_clubDataSet.Абонементы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.sport_clubDataSet.Залы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet2.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet2.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet2.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.sport_clubDataSet2.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet2.Абонементы". При необходимости она может быть перемещена или удалена.
            this.абонементыTableAdapter.Fill(this.sport_clubDataSet2.Абонементы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet10.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter2.Fill(this.sport_clubDataSet10.Залы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet1.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter2.Fill(this.sport_clubDataSet1.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet10.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter1.Fill(this.sport_clubDataSet10.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet10.Запрос3". При необходимости она может быть перемещена или удалена.
            this.запрос3TableAdapter.Fill(this.sport_clubDataSet10.Запрос3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet10.Абонементы". При необходимости она может быть перемещена или удалена.
            this.абонементыTableAdapter2.Fill(this.sport_clubDataSet10.Абонементы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet1.Абонементы". При необходимости она может быть перемещена или удалена.
            this.абонементыTableAdapter1.Fill(this.sport_clubDataSet1.Абонементы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet1.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this.sport_clubDataSet1.Запрос1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Абонементы". При необходимости она может быть перемещена или удалена.
            this.абонементыTableAdapter.Fill(this.sport_clubDataSet.Абонементы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Учет". При необходимости она может быть перемещена или удалена.
            this.учетTableAdapter.Fill(this.sport_clubDataSet.Учет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet1.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter1.Fill(this.sport_clubDataSet1.Залы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.sport_clubDataSet.Залы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_clubDataSet.Абонементы". При необходимости она может быть перемещена или удалена.
            this.абонементыTableAdapter.Fill(this.sport_clubDataSet.Абонементы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1databaseDataSet1.Events". При необходимости она может быть перемещена или удалена.
            //this.eventsTableAdapter.Fill(this.laba1databaseDataSet1.Events);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1databaseDataSet11.Events". При необходимости она может быть перемещена или удалена.
            //this.eventsTableAdapter1.Fill(this.laba1databaseDataSet11.Events);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1databaseDataSet1.Events". При необходимости она может быть перемещена или удалена.
            this.eventsTableAdapter.Fill(this.laba1databaseDataSet1.Events);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1databaseDataSet1.Events". При необходимости она может быть перемещена или удалена.
            this.eventsTableAdapter.Fill(this.laba1databaseDataSet1.Events);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1databaseDataSet1.Events". При необходимости она может быть перемещена или удалена.
           

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {






        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
  
           

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    pictureBox1.Image = Properties.Resources.image3;
            }
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    pictureBox1.Image = Properties.Resources.Imageforlaba;
            }
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpFileName = @"c:\help.chm";
            if (System.IO.File.Exists(helpFileName))
            {
                Help.ShowHelp(this, helpFileName);
            }
        }

        private void dataGridView1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
        HelpNavigator navigator = HelpNavigator.KeywordIndex;
        Help.ShowHelp(this, helpfile, navigator, KeywInd);
        }
        private void dataGridView2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
         HelpNavigator navigator = HelpNavigator.KeywordIndex;
         Help.ShowHelp(this, helpfile, navigator, KeywInd);
        }
    }
}
  