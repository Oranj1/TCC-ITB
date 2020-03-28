using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SegurSys
{
    public partial class frmLerRelatorio : Form
    {
        public frmLerRelatorio()
        {
            InitializeComponent();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLerRelatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
