namespace Chave_Facil
{
    partial class FrmChaveFacil
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
            this.pnSala1 = new System.Windows.Forms.Panel();
            this.lbS1 = new System.Windows.Forms.Label();
            this.btnRtrS1 = new System.Windows.Forms.Button();
            this.btnDvlrS1 = new System.Windows.Forms.Button();
            this.pnSala1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSala1
            // 
            this.pnSala1.BackColor = System.Drawing.Color.Lime;
            this.pnSala1.Controls.Add(this.btnDvlrS1);
            this.pnSala1.Controls.Add(this.btnRtrS1);
            this.pnSala1.Controls.Add(this.lbS1);
            this.pnSala1.Location = new System.Drawing.Point(12, 68);
            this.pnSala1.Name = "pnSala1";
            this.pnSala1.Size = new System.Drawing.Size(200, 100);
            this.pnSala1.TabIndex = 0;
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbS1.Location = new System.Drawing.Point(62, 11);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(71, 18);
            this.lbS1.TabIndex = 0;
            this.lbS1.Text = "SALA 01";
            // 
            // btnRtrS1
            // 
            this.btnRtrS1.Location = new System.Drawing.Point(14, 60);
            this.btnRtrS1.Name = "btnRtrS1";
            this.btnRtrS1.Size = new System.Drawing.Size(75, 23);
            this.btnRtrS1.TabIndex = 1;
            this.btnRtrS1.Text = "RETIRAR";
            this.btnRtrS1.UseVisualStyleBackColor = true;
            this.btnRtrS1.Click += new System.EventHandler(this.btnRtrS1_Click);
            // 
            // btnDvlrS1
            // 
            this.btnDvlrS1.Location = new System.Drawing.Point(112, 60);
            this.btnDvlrS1.Name = "btnDvlrS1";
            this.btnDvlrS1.Size = new System.Drawing.Size(75, 23);
            this.btnDvlrS1.TabIndex = 2;
            this.btnDvlrS1.Text = "DEVOLVER";
            this.btnDvlrS1.UseVisualStyleBackColor = true;
            this.btnDvlrS1.Click += new System.EventHandler(this.btnDvlrS1_Click);
            // 
            // FrmChaveFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnSala1);
            this.Name = "FrmChaveFacil";
            this.Text = "ChaveFacil";
            this.pnSala1.ResumeLayout(false);
            this.pnSala1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSala1;
        private System.Windows.Forms.Label lbS1;
        private System.Windows.Forms.Button btnDvlrS1;
        private System.Windows.Forms.Button btnRtrS1;
    }
}

