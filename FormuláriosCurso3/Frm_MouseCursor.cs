using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWinform
{
    public partial class Frm_MouseCursor : Form
    {
        public Frm_MouseCursor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            for(int i=0; i<=10; i++)
            {
                System.Threading.Thread.Sleep(1000);//ele vai esperar 1000ms para fazer a operação, como tem o 10 ele vai levar 10segundos para fazer esse evento 
            }
            this.Cursor = Cursors.Default;
        }
    }
}
