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
    public partial class NameSearch : Form
    {
        public NameSearch()
        {
            InitializeComponent();
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            // Create new instance:
            SearchResult searchnew = new SearchResult();
            searchnew.ShowDialog();
        }
    }
}
