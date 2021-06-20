
namespace AplicatieGestiune
{
    partial class formPrimary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProduse = new System.Windows.Forms.Button();
            this.btnFurnizori = new System.Windows.Forms.Button();
            this.btnDeschidereTura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduse
            // 
            this.btnProduse.Location = new System.Drawing.Point(329, 87);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(300, 40);
            this.btnProduse.TabIndex = 0;
            this.btnProduse.Text = "Produse";
            this.btnProduse.UseVisualStyleBackColor = true;
            this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
            // 
            // btnFurnizori
            // 
            this.btnFurnizori.Location = new System.Drawing.Point(329, 160);
            this.btnFurnizori.Name = "btnFurnizori";
            this.btnFurnizori.Size = new System.Drawing.Size(300, 40);
            this.btnFurnizori.TabIndex = 1;
            this.btnFurnizori.Text = "Furnizori";
            this.btnFurnizori.UseVisualStyleBackColor = true;
            this.btnFurnizori.Click += new System.EventHandler(this.btnFurnizori_Click);
            // 
            // btnDeschidereTura
            // 
            this.btnDeschidereTura.Location = new System.Drawing.Point(329, 230);
            this.btnDeschidereTura.Name = "btnDeschidereTura";
            this.btnDeschidereTura.Size = new System.Drawing.Size(300, 40);
            this.btnDeschidereTura.TabIndex = 2;
            this.btnDeschidereTura.Text = "Deschidere tura";
            this.btnDeschidereTura.UseVisualStyleBackColor = true;
            // 
            // formPrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnDeschidereTura);
            this.Controls.Add(this.btnFurnizori);
            this.Controls.Add(this.btnProduse);
            this.Name = "formPrimary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduse;
        private System.Windows.Forms.Button btnFurnizori;
        private System.Windows.Forms.Button btnDeschidereTura;
    }
}

