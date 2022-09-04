using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWinform
{
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var posicaoX = e.X;
                var posicaoY = e.Y;
                //MessageBox.Show("Cliquei com o botão direito. A Posição relativa foi (" + posicaoX.ToString() + ","+posicaoY.ToString()+")");

                //var ContextMenu = new ContextMenuStrip(); //estou criando uma variável de memória e estou estanciando uma classe do tipo ContextMenuStrip;
                //o Context seria o menu todo ex arquivo windows novo sair
                //var vToolTip001 = new ToolStripMenuItem(); //toolstrip seria o item Novo e sair
                //vToolTip001.Text = "Item do menu 1";
                //var vToolTip002 = new ToolStripMenuItem();
                //vToolTip002.Text = "Item do menu 2";

                //ContextMenu.Items.Add(vToolTip001.Text);//vai adicionar dentro do contextMenu;
                //ContextMenu.Items.Add(vToolTip002.Text);               
                //ContextMenu.Show(this, new Point(posicaoX, posicaoY));                           

                //COM A CRIAÇÃO DA ROTINA FICA:
                var ContextMenu = new ContextMenuStrip();//adicionamos a variavel menu
                var vToolTip001 = DesenhaItemMenu("Item do menu 1", "key");//adiciona duas varivaveis do tipo item e coloca parametos nela
                var vToolTip002 = DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha");
                ContextMenu.Items.Add(vToolTip001);//adiciona ao menu 
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Show(this, new Point(e.X, e.Y)); //desenha o item no menu nessa posição      
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);//adiciono o evento clique a cada cursor
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            }

            void vToolTip001_Click(object sender1, EventArgs e1)//temos que mudar o sender pois é padrão
            {
                MessageBox.Show("Selecionei a opção do menu 001");
            }
            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do menu 002");
            }
            //PrivateFontCollection void vToolTip001_Click(object sender, EventArgs e)
            //{

            //}

            //criando uma rotina para fazer um menuflutuante
            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem) //função para retornar um toolstrip menu item
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;
                Image myImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = myImage;
                return vToolTip;
            }


            /*   string str1 = e.Button.ToString();
               if (str1 == "Right")
               {              
               MessageBox.Show(str1);              
               }*/
        }
    }
}
