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
    public partial class Frm_Questao : Form
    {
        //Será usado no validacpf2
        public Frm_Questao(string nomeImagem, string mensagem)//o nomeImagem é o nome da imagem que quero que apareça
        {//estou passando para o formulario duas variáveis um nome e o texto da imagem
            InitializeComponent();

            Image MyImage = (Image)global::CursoWinform.Properties.Resources.ResourceManager.GetObject(nomeImagem);//buscando do resource do projeto a imagem
            Pic_Imagem.Image = MyImage;//carregando a propriedade imagem do picturebox
            Lbl_Questao.Text = mensagem;//carregada pra label
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
