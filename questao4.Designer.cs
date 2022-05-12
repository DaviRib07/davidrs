namespace AppProva10DaviRibeiro
{
    partial class questao4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_questão4 = new System.Windows.Forms.Label();
            this.ltx_listar = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl_questão4);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 179);
            this.panel1.TabIndex = 0;
            // 
            // lbl_questão4
            // 
            this.lbl_questão4.AutoSize = true;
            this.lbl_questão4.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_questão4.Location = new System.Drawing.Point(326, 68);
            this.lbl_questão4.Name = "lbl_questão4";
            this.lbl_questão4.Size = new System.Drawing.Size(146, 39);
            this.lbl_questão4.TabIndex = 0;
            this.lbl_questão4.Text = "Questão 4";
            // 
            // ltx_listar
            // 
            this.ltx_listar.FormattingEnabled = true;
            this.ltx_listar.ItemHeight = 15;
            this.ltx_listar.Location = new System.Drawing.Point(229, 197);
            this.ltx_listar.Name = "ltx_listar";
            this.ltx_listar.Size = new System.Drawing.Size(333, 214);
            this.ltx_listar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questao4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ltx_listar);
            this.Controls.Add(this.panel1);
            this.Name = "questao4";
            this.Text = "questao4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_questão4;
        private ListBox ltx_listar;
        private Button button1;
    }
}