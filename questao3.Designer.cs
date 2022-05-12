namespace AppProva10DaviRibeiro
{
    partial class questao3
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
            this.pnl_questão2 = new System.Windows.Forms.Panel();
            this.lbl_questao3 = new System.Windows.Forms.Label();
            this.btn_dados = new System.Windows.Forms.Button();
            this.pnl_questão2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_questão2
            // 
            this.pnl_questão2.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_questão2.Controls.Add(this.lbl_questao3);
            this.pnl_questão2.Location = new System.Drawing.Point(-2, -1);
            this.pnl_questão2.Name = "pnl_questão2";
            this.pnl_questão2.Size = new System.Drawing.Size(804, 158);
            this.pnl_questão2.TabIndex = 11;
            // 
            // lbl_questao3
            // 
            this.lbl_questao3.AutoSize = true;
            this.lbl_questao3.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_questao3.Location = new System.Drawing.Point(328, 60);
            this.lbl_questao3.Name = "lbl_questao3";
            this.lbl_questao3.Size = new System.Drawing.Size(146, 39);
            this.lbl_questao3.TabIndex = 0;
            this.lbl_questao3.Text = "Questão 3";
            // 
            // btn_dados
            // 
            this.btn_dados.BackColor = System.Drawing.Color.MintCream;
            this.btn_dados.Location = new System.Drawing.Point(275, 239);
            this.btn_dados.Name = "btn_dados";
            this.btn_dados.Size = new System.Drawing.Size(258, 100);
            this.btn_dados.TabIndex = 12;
            this.btn_dados.Text = "Rolar os dados";
            this.btn_dados.UseVisualStyleBackColor = false;
            this.btn_dados.Click += new System.EventHandler(this.btn_dados_Click);
            // 
            // questao3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dados);
            this.Controls.Add(this.pnl_questão2);
            this.Name = "questao3";
            this.Text = "questao3";
            this.pnl_questão2.ResumeLayout(false);
            this.pnl_questão2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_questão2;
        private Label lbl_questao3;
        private Button btn_dados;
    }
}