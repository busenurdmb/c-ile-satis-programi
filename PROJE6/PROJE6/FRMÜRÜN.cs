using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE6
{
    public partial class FRMÜRÜN : Form
    {
        public FRMÜRÜN()
        {
            InitializeComponent();
        }

        private void FRMÜRÜN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proje6DataSet1.TBLÜRÜNLER' table. You can move, or remove it, as needed.
            this.tBLÜRÜNLERTableAdapter.Fill(this.proje6DataSet1.TBLÜRÜNLER);

        }
    }
}
