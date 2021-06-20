
namespace AplicatieGestiune.UI
{
    partial class formProduse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnUpdateProdus = new System.Windows.Forms.Button();
            this.btnStergeProdus = new System.Windows.Forms.Button();
            this.txtCodQR = new System.Windows.Forms.TextBox();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.txtPretFaraTVA = new System.Windows.Forms.TextBox();
            this.txtUnitateMasura = new System.Windows.Forms.TextBox();
            this.txtProcentTVA = new System.Windows.Forms.TextBox();
            this.txtCantitateProdus = new System.Windows.Forms.TextBox();
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchProduse = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod QR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Furnizor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume Produs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret fara TVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unitate masura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Procent TVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantitate";
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdaugaProdus.Location = new System.Drawing.Point(12, 424);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(397, 32);
            this.btnAdaugaProdus.TabIndex = 7;
            this.btnAdaugaProdus.Text = "Adauga";
            this.btnAdaugaProdus.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProdus
            // 
            this.btnUpdateProdus.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdateProdus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateProdus.Location = new System.Drawing.Point(12, 462);
            this.btnUpdateProdus.Name = "btnUpdateProdus";
            this.btnUpdateProdus.Size = new System.Drawing.Size(397, 32);
            this.btnUpdateProdus.TabIndex = 8;
            this.btnUpdateProdus.Text = "Update";
            this.btnUpdateProdus.UseVisualStyleBackColor = false;
            // 
            // btnStergeProdus
            // 
            this.btnStergeProdus.BackColor = System.Drawing.Color.Crimson;
            this.btnStergeProdus.Location = new System.Drawing.Point(13, 500);
            this.btnStergeProdus.Name = "btnStergeProdus";
            this.btnStergeProdus.Size = new System.Drawing.Size(396, 32);
            this.btnStergeProdus.TabIndex = 9;
            this.btnStergeProdus.Text = "Sterge";
            this.btnStergeProdus.UseVisualStyleBackColor = false;
            // 
            // txtCodQR
            // 
            this.txtCodQR.Location = new System.Drawing.Point(203, 60);
            this.txtCodQR.Name = "txtCodQR";
            this.txtCodQR.Size = new System.Drawing.Size(206, 23);
            this.txtCodQR.TabIndex = 10;
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(203, 115);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(206, 23);
            this.txtNumeProdus.TabIndex = 11;
            // 
            // txtPretFaraTVA
            // 
            this.txtPretFaraTVA.Location = new System.Drawing.Point(203, 220);
            this.txtPretFaraTVA.Name = "txtPretFaraTVA";
            this.txtPretFaraTVA.Size = new System.Drawing.Size(206, 23);
            this.txtPretFaraTVA.TabIndex = 13;
            // 
            // txtUnitateMasura
            // 
            this.txtUnitateMasura.Location = new System.Drawing.Point(203, 271);
            this.txtUnitateMasura.Name = "txtUnitateMasura";
            this.txtUnitateMasura.Size = new System.Drawing.Size(206, 23);
            this.txtUnitateMasura.TabIndex = 14;
            // 
            // txtProcentTVA
            // 
            this.txtProcentTVA.Location = new System.Drawing.Point(203, 323);
            this.txtProcentTVA.Name = "txtProcentTVA";
            this.txtProcentTVA.Size = new System.Drawing.Size(206, 23);
            this.txtProcentTVA.TabIndex = 15;
            // 
            // txtCantitateProdus
            // 
            this.txtCantitateProdus.Location = new System.Drawing.Point(203, 376);
            this.txtCantitateProdus.Name = "txtCantitateProdus";
            this.txtCantitateProdus.Size = new System.Drawing.Size(206, 23);
            this.txtCantitateProdus.TabIndex = 16;
            // 
            // dgvProduse
            // 
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Location = new System.Drawing.Point(527, 54);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.RowTemplate.Height = 25;
            this.dgvProduse.Size = new System.Drawing.Size(631, 478);
            this.dgvProduse.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(527, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search";
            // 
            // txtSearchProduse
            // 
            this.txtSearchProduse.Location = new System.Drawing.Point(608, 15);
            this.txtSearchProduse.Name = "txtSearchProduse";
            this.txtSearchProduse.Size = new System.Drawing.Size(550, 23);
            this.txtSearchProduse.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 23);
            this.comboBox1.TabIndex = 20;
            // 
            // formProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearchProduse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvProduse);
            this.Controls.Add(this.txtCantitateProdus);
            this.Controls.Add(this.txtProcentTVA);
            this.Controls.Add(this.txtUnitateMasura);
            this.Controls.Add(this.txtPretFaraTVA);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.txtCodQR);
            this.Controls.Add(this.btnStergeProdus);
            this.Controls.Add(this.btnUpdateProdus);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formProduse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produse";
            this.Load += new System.EventHandler(this.formProduse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnUpdateProdus;
        private System.Windows.Forms.Button btnStergeProdus;
        private System.Windows.Forms.TextBox txtCodQR;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.TextBox txtPretFaraTVA;
        private System.Windows.Forms.TextBox txtUnitateMasura;
        private System.Windows.Forms.TextBox txtProcentTVA;
        private System.Windows.Forms.TextBox txtCantitateProdus;
        private System.Windows.Forms.DataGridView dgvProduse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchProduse;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}