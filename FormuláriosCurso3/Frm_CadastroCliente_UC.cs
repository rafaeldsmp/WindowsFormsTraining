using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using CursoWindowsFormsBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using CursoWindowsFormsBiblioteca;

namespace CursoWinform
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Genero.Text = "Genero";
            Grp_Outros.Text = "Outros";
            Lbl_Cidade.Text = "Cidade";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Chk_TemPai.Text = "Pai desconhecido";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";

            Cmb_Estados.Items.Clear();//Comando que garante que o combo box foi limpo
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            Tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base";
            Tls_Principal.Items[2].ToolTipText = "Atualize o cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados";
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }
        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                //C.Id = Txt_Codigo.Text; para não chamar uma variável de cada vez vou criar uma rotina
                C = LeituraFormulario();//vou atribuir a classe o conteúdo de formulário
                C.validaClasse();//depois irei testar ela
                C.ValidaComplemento();
                MessageBox.Show("Classe foi incializada sem erros", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)//aqui estou tratando apenas o erro do validaexception
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);//se gerar exceções vai ser gerada aqui
            }
            catch (Exception ex)//aqui é o exception para tratar as 3 condinções que estou testando
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);//se gerar exceções vai ser gerada aqui
            }


        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão Abrir");
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão Salvar");
        }

        private void ApagarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão Apagar");
        }

        private void LimparToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão LIMPAR");
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit c = new Cliente.Unit();
            c.Id = Txt_Codigo.Text;
            c.Nome = Txt_NomeCliente.Text;
            c.NomeMae = Txt_NomeMae.Text;
            c.NomePai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                c.NaoTemPai = true;
            }
            else
            {
                c.NaoTemPai = false;
            }
            if (Rdb_Masculino.Checked)
            {
                c.Genero = 0;
            }
            if (Rdb_Feminino.Checked)
            {
                c.Genero = 0;
            }
            if (Rdb_Indefinido.Checked)
            {
                c.Genero = 0;
            }
            c.Cpf = Txt_CPF.Text;

            c.Cep = Txt_CEP.Text;
            c.Logradouro = Txt_Logradouro.Text;
            c.Complemento = Txt_Complemento.Text;
            c.Cidade = Txt_Cidade.Text;
            c.Bairro = Txt_Bairro.Text;

            if (Cmb_Estados.SelectedIndex < 0)//o selectedindex diz a posição que foi selecionado, se for menor que zero significa que não foi selecionado ainda
            {
                c.Estado = string.Empty;
            }
            else//se for maior que zero significa que foi atribuido algum indice
            {
                c.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            c.Telefone = Txt_Telefone.Text;
            c.Profissao = Txt_Profissao.Text;

            //pela renda ser um double irei testar se o que digitou é um número
            //adicionando a referencia do microsoft visualbasic irei saber 

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
                if (vRenda < 0)
                {
                    c.RendaFamiliar = 0;
                }
                else
                {
                    c.RendaFamiliar = vRenda;
                }
            }

            return c;
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;
            if(vCep != string.Empty)
            {
                if(vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.desSerializedClassUnit(vJson);
                        Txt_Logradouro.Text = CEP.logradouro;
                        Txt_Bairro.Text = CEP.bairro;
                        Txt_Cidade.Text = CEP.localidade;

                        Cmb_Estados.SelectedIndex = -1;
                        for (int i = 0; i<= Cmb_Estados.Items.Count -1; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(),"(" + CEP.uf + ")");
                            //usarei a função InStr que ela busca um texto dentro de um string
                            if(vPos > 0)
                            {
                                Cmb_Estados.SelectedIndex= i; //o combo box automaticamente muda sua seleção e muda o elemento I da lista
                            }
                        }


                    }
                }
            }
           
        }
    }
}
