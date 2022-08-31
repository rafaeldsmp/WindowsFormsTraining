namespace CursoWinform
{
    partial class Frm_DemonstracaoKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.Txt_Msg = new System.Windows.Forms.TextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lbl_Minus = new System.Windows.Forms.Label();
            this.Lbl_Maius = new System.Windows.Forms.Label();
            this.Lbl_Upper = new System.Windows.Forms.Label();
            this.Lbl_Lower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(5, 5);
            this.Txt_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(81, 20);
            this.Txt_Input.TabIndex = 0;
            this.Txt_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Input_KeyDown);
            // 
            // Txt_Msg
            // 
            this.Txt_Msg.Location = new System.Drawing.Point(5, 36);
            this.Txt_Msg.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Msg.Multiline = true;
            this.Txt_Msg.Name = "Txt_Msg";
            this.Txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Msg.Size = new System.Drawing.Size(189, 216);
            this.Txt_Msg.TabIndex = 1;
            this.Txt_Msg.TabStop = false;
            this.Txt_Msg.TextChanged += new System.EventHandler(this.Txt_msg_TextChanged);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(117, 4);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(77, 20);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Lbl_Minus
            // 
            this.Lbl_Minus.Location = new System.Drawing.Point(213, 68);
            this.Lbl_Minus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Minus.Name = "Lbl_Minus";
            this.Lbl_Minus.Size = new System.Drawing.Size(36, 15);
            this.Lbl_Minus.TabIndex = 3;
            this.Lbl_Minus.Text = "Minus.";
            // 
            // Lbl_Maius
            // 
            this.Lbl_Maius.Location = new System.Drawing.Point(213, 36);
            this.Lbl_Maius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Maius.Name = "Lbl_Maius";
            this.Lbl_Maius.Size = new System.Drawing.Size(56, 14);
            this.Lbl_Maius.TabIndex = 4;
            this.Lbl_Maius.Text = "Maius.";
            // 
            // Lbl_Upper
            // 
            this.Lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Upper.Location = new System.Drawing.Point(283, 35);
            this.Lbl_Upper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Upper.Name = "Lbl_Upper";
            this.Lbl_Upper.Size = new System.Drawing.Size(21, 15);
            this.Lbl_Upper.TabIndex = 5;
            this.Lbl_Upper.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Lower
            // 
            this.Lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lower.Location = new System.Drawing.Point(283, 68);
            this.Lbl_Lower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Lower.Name = "Lbl_Lower";
            this.Lbl_Lower.Size = new System.Drawing.Size(21, 15);
            this.Lbl_Lower.TabIndex = 6;
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 254);
            this.Controls.Add(this.Lbl_Lower);
            this.Controls.Add(this.Lbl_Upper);
            this.Controls.Add(this.Lbl_Maius);
            this.Controls.Add(this.Lbl_Minus);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Txt_Msg);
            this.Controls.Add(this.Txt_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Input;
        private System.Windows.Forms.TextBox Txt_Msg;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lbl_Minus;
        private System.Windows.Forms.Label Lbl_Maius;
        private System.Windows.Forms.Label Lbl_Upper;
        private System.Windows.Forms.Label Lbl_Lower;
    }
}