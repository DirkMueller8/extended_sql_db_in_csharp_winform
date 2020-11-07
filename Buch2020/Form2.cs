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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        //public void DetailsNameLaden(string kname)
        //{
        //    this.kundeTableAdapter.FillBynameDetail(this.buch2020DataSet.Kunde, kname);
        //    //this.kundeTableAdapter.FillBykundeDetail(this.buch2020DataSet.Kunde, kname);
        //}

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kundeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);

        }

        public void DetailsLaden(string name)
        {
            //bitte in einer Zeile eingeben
            this.kundeTableAdapter.FillBynameDetail(this.buch2020DataSet.Kunde, name);
        }
    }
}
