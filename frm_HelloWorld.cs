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
    public partial class frm_HelloWorld : Form
    {
        private Button Btn_Sair;
        private Button Btn_ModificaLabel;
        private TextBox Txt_ConteudoLabel;
        private Label Lbl_Titulo;

        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void HelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HelloWorld));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_ModificaLabel = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AccessibleDescription = " ";
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(213, 19);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Visual Studio .NET Version";
            this.Lbl_Titulo.Click += new System.EventHandler(this.lbl_Titulo_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(454, 392);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(190, 41);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Fechar a aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_ModificaLabel
            // 
            this.Btn_ModificaLabel.Location = new System.Drawing.Point(35, 75);
            this.Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            this.Btn_ModificaLabel.Size = new System.Drawing.Size(318, 33);
            this.Btn_ModificaLabel.TabIndex = 2;
            this.Btn_ModificaLabel.Text = "Modifica Texto do Label";
            this.Btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificaLabel.Click += new System.EventHandler(this.Btn_ModificaLabel_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(35, 114);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(459, 20);
            this.Txt_ConteudoLabel.TabIndex = 3;
            this.Txt_ConteudoLabel.TextChanged += new System.EventHandler(this.Txt_ConteudoLabel_TextChanged);
            // 
            // frm_HelloWorld
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(656, 445);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModificaLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.HelloWorld_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HelloWorld_Load_1(object sender, EventArgs e)
        {

        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }

        private void Txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
