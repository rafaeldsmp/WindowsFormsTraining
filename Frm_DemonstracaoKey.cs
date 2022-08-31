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
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Presionei uma tecla: " + e.KeyCode + "\r\n"); //zrzn é uma quebra de linha 
            Txt_Msg.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n"); ///t é tab, ele vai chegar um pouco a direita 
            Txt_Msg.AppendText("\t" + "Nome da tecla: : " + e.KeyData + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_Input.Text = "";
            Lbl_Lower.Text = "";
            Lbl_Upper.Text = "";

        }
    }
}
