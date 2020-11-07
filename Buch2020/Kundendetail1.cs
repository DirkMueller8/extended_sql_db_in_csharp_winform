using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Kundendetail1 : Form
    {
        public void DetailsLaden(string name)
        {
            // Fühle die Form anhand der SQL Abfrage FillBynameDetail, die 
            // nach Gleichheit im Namen sucht:
            this.kundeTableAdapter.FillBynameDetail(this.buch2020DataSet.Kunde, name);
        }

        public Kundendetail1()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Kundendetail1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde".
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
