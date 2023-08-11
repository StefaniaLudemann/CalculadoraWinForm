using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Telefono Movistar = new Telefono();

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Movistar.Llamar();
        }
    }
}
