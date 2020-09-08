namespace Conceito_While
{
    partial class While_For
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Ano:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboAno
            // 
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(198, 62);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(121, 21);
            this.cboAno.TabIndex = 1;
            this.cboAno.SelectedIndexChanged += new System.EventHandler(this.cboAno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parte 06 - Contador com FOR";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(22, 108);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 30);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.Location = new System.Drawing.Point(320, 108);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(40, 30);
            this.btnAvancar.TabIndex = 17;
            this.btnAvancar.Text = ">";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // While_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.label1);
            this.Name = "While_For";
            this.Text = "While_For";
            this.Load += new System.EventHandler(this.While_For_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
    }
}