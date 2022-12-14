using CursoWindowsFormsBiblioteca;
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
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleCPF = 0;
        int ControleCPF2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;
        int ControleCadastroClientes = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
            novoToolStripMenuItem.Enabled = false;//desativando abas no toolstrip para usuários não conectados
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;
            Frm_DemonstracaoKey_UC u = new Frm_DemonstracaoKey_UC();//instanciou um formulario do tipo usercontrol
            u.Dock = DockStyle.Fill;//para ocupar a área toda do formulário
            TabPage tb = new TabPage();//criou em memória uma tabpage
            tb.Name = "Demonstração Key " + ControleDemonstracaoKey;//esse é o nome interno
            tb.Text = "Demonstração Key " + ControleDemonstracaoKey;//Como fica o nome na tab
            tb.Controls.Add(u);//adicionou para dentro da página o formulario do tipo usercontrol
            tb.ImageIndex = 0;//que é o número que identifica a aplicação lá no meu image list
            Tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC u = new Frm_HelloWorld_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Hello World " + ControleHelloWorld;
            tb.Text = "Hello World " + ControleHelloWorld;
            tb.Controls.Add(u);
            tb.ImageIndex = 1;
            Tbc_Aplicacoes.TabPages.Add(tb);

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            Frm_Mascara_UC u = new Frm_Mascara_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Mascara " + ControleMascara;
            tb.Text = "Mascara " + ControleMascara;
            tb.Controls.Add(u);
            tb.ImageIndex = 2;
            Tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleCPF += 1;
            Frm_ValidaCPF_UC u = new Frm_ValidaCPF_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Valida CPF " + ControleCPF;
            tb.Text = "Valida CPF " + ControleCPF;
            tb.Controls.Add(u);
            tb.ImageIndex = 3;
            Tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleCPF2 += 1;
            Frm_CPF2_UC u = new Frm_CPF2_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Valida CPF2 " + ControleCPF2;
            tb.Text = "Valida CPF2 " + ControleCPF2;
            tb.Controls.Add(u);
            tb.ImageIndex = 4;
            Tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            Frm_Senha_UC u = new Frm_Senha_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Valida Senha " + ControleValidaSenha;
            tb.Text = "Valida Senha " + ControleValidaSenha;
            tb.Controls.Add(u);
            tb.ImageIndex = 5;
            Tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                /* Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);*///na tabpages irá remover a que está selecionada
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Curso\\CursoWinform\\CursoWinform\\Imagens"; //esse parâmetro é diretorio inicial que estará escolhendo o arquivo
            Db.Filter = "PNG|*.PNG"; //extenção para mostrar só arquivos PNG
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;

                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC u = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                u.Dock = DockStyle.Fill;
                TabPage tb = new TabPage();
                tb.Name = "Arquivo Imagem " + ControleArquivoImagem;
                tb.Text = "Arquivo Imagem " + ControleArquivoImagem;
                tb.Controls.Add(u);
                tb.ImageIndex = 6;
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            if (F.ShowDialog() == DialogResult.OK)
            {
                string senha = F.senha; //a variavel senha e login do formulario principal recebeu o valor da propriedade senha e login da classe frm_login
                string login = F.login;
                if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    cadastrosToolStripMenuItem.Enabled = true;
                    MessageBox.Show("Bem Vindo" + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha Inválida!" + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("icons8_question_mark_100", "Você deseja se desconectar?");
            Db.ShowDialog();
            //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            if (Db.DialogResult == DialogResult.Yes)
            {   //para fechar todas as abas terá que pegar da última aba até a primeira para assim não pular                        
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i--)//começa de traz para frente, poderia chamar o Tbc_Aplicacoes.TabPages.Clear();:
                {
                    //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }
            }
            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;
        }       
        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var posicaoX = e.X;
                var posicaoY = e.Y;

                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar Todas as Esquerdas", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar Todas as Direitas", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar Todas menos Esta", "DeleteAll");
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);
                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);
            }
        }

        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }
        void vToolTip002_Click(object sender1, EventArgs e1)
        {//deletar a partir da esquerda
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
            //int ItemSelecionado = Tbc_Aplicacoes.SelectedIndex;
            //for (int i = ItemSelecionado - 1; i >= 0; i--)
            //{
            //    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
            //}
        }
        void vToolTip003_Click(object sender1, EventArgs e1)
        {//deletar direita
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
            //int ItemSelecionado = Tbc_Aplicacoes.SelectedIndex;
            //for (int i = Tbc_Aplicacoes.TabCount - 1; i > ItemSelecionado; i += -1)
            //{
            //    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
            //}
        }
        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            Image myImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = myImage;
            return vToolTip;
        }

        void ApagaDireita(int ItemSelecionado)
        {
            for (int i = Tbc_Aplicacoes.TabCount - 1; i > ItemSelecionado; i += -1)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        void ApagaEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i--)
            {
                // Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        { //só vai abrir uma pagina
            if (ControleCadastroClientes == 0)
            {
                ControleCadastroClientes += 1;
                Frm_CadastroCliente_UC u = new Frm_CadastroCliente_UC();
                u.Dock = DockStyle.Fill;
                TabPage tb = new TabPage();
                tb.Name = "Cadastro de Clientes";
                tb.Text = "Cadastro de Clientes";
                tb.Controls.Add(u);
                tb.ImageIndex = 7;
                Tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não pode abrir o cadastro pois já está aberto", "Bytebank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void ApagaAba(TabPage TB)
        {
            if(TB.Name == "Cadastro de Clientes")
            {
                ControleCadastroClientes = 0;
            }
            Tbc_Aplicacoes.TabPages.Remove(TB);
        }
    }
}



