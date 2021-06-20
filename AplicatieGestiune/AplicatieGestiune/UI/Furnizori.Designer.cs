
namespace AplicatieGestiune.UI
{
    partial class formFurnizori
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
            this.lblIdFurnizor = new System.Windows.Forms.Label();
            this.lblNumeFurnizor = new System.Windows.Forms.Label();
            this.lblLocatieFurnizor = new System.Windows.Forms.Label();
            this.txtIdFurnizor = new System.Windows.Forms.TextBox();
            this.txtNumeFurnizor = new System.Windows.Forms.TextBox();
            this.txtLocatieFurnizor = new System.Windows.Forms.TextBox();
            this.dgvFurnizori = new System.Windows.Forms.DataGridView();
            this.txtSearchFurnizori = new System.Windows.Forms.TextBox();
            this.lblSearchFurnizori = new System.Windows.Forms.Label();
            this.btnAdaugaFurnizori = new System.Windows.Forms.Button();
            this.btnUpdateFurnizori = new System.Windows.Forms.Button();
            this.btnStergeFurnizori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnizori)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdFurnizor
            // 
            this.lblIdFurnizor.AutoSize = true;
            this.lblIdFurnizor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdFurnizor.Location = new System.Drawing.Point(12, 47);
            this.lblIdFurnizor.Name = "lblIdFurnizor";
            this.lblIdFurnizor.Size = new System.Drawing.Size(112, 30);
            this.lblIdFurnizor.TabIndex = 0;
            this.lblIdFurnizor.Text = "Id Furnizor";
            this.lblIdFurnizor.Click += new System.EventHandler(this.lblIdFurnizor_Click);
            // 
            // lblNumeFurnizor
            // 
            this.lblNumeFurnizor.AutoSize = true;
            this.lblNumeFurnizor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeFurnizor.Location = new System.Drawing.Point(12, 119);
            this.lblNumeFurnizor.Name = "lblNumeFurnizor";
            this.lblNumeFurnizor.Size = new System.Drawing.Size(151, 30);
            this.lblNumeFurnizor.TabIndex = 1;
            this.lblNumeFurnizor.Text = "Nume Furnizor";
            // 
            // lblLocatieFurnizor
            // 
            this.lblLocatieFurnizor.AutoSize = true;
            this.lblLocatieFurnizor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocatieFurnizor.Location = new System.Drawing.Point(12, 189);
            this.lblLocatieFurnizor.Name = "lblLocatieFurnizor";
            this.lblLocatieFurnizor.Size = new System.Drawing.Size(160, 30);
            this.lblLocatieFurnizor.TabIndex = 2;
            this.lblLocatieFurnizor.Text = "Locatie Furnizor";
            // 
            // txtIdFurnizor
            // 
            this.txtIdFurnizor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdFurnizor.Location = new System.Drawing.Point(189, 54);
            this.txtIdFurnizor.Name = "txtIdFurnizor";
            this.txtIdFurnizor.ReadOnly = true;
            this.txtIdFurnizor.Size = new System.Drawing.Size(174, 25);
            this.txtIdFurnizor.TabIndex = 3;
            // 
            // txtNumeFurnizor
            // 
            this.txtNumeFurnizor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeFurnizor.Location = new System.Drawing.Point(189, 128);
            this.txtNumeFurnizor.Name = "txtNumeFurnizor";
            this.txtNumeFurnizor.Size = new System.Drawing.Size(174, 25);
            this.txtNumeFurnizor.TabIndex = 4;
            // 
            // txtLocatieFurnizor
            // 
            this.txtLocatieFurnizor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocatieFurnizor.Location = new System.Drawing.Point(189, 196);
            this.txtLocatieFurnizor.Name = "txtLocatieFurnizor";
            this.txtLocatieFurnizor.Size = new System.Drawing.Size(174, 25);
            this.txtLocatieFurnizor.TabIndex = 5;
            // 
            // dgvFurnizori
            // 
            this.dgvFurnizori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFurnizori.Location = new System.Drawing.Point(453, 54);
            this.dgvFurnizori.Name = "dgvFurnizori";
            this.dgvFurnizori.RowTemplate.Height = 25;
            this.dgvFurnizori.Size = new System.Drawing.Size(519, 385);
            this.dgvFurnizori.TabIndex = 6;
            this.dgvFurnizori.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFurnizori_RowHeaderMouseClick);
            // 
            // txtSearchFurnizori
            // 
            this.txtSearchFurnizori.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchFurnizori.Location = new System.Drawing.Point(544, 14);
            this.txtSearchFurnizori.Name = "txtSearchFurnizori";
            this.txtSearchFurnizori.Size = new System.Drawing.Size(428, 25);
            this.txtSearchFurnizori.TabIndex = 8;
            this.txtSearchFurnizori.TextChanged += new System.EventHandler(this.txtSearchFurnizor_textChanged);
            // 
            // lblSearchFurnizori
            // 
            this.lblSearchFurnizori.AutoSize = true;
            this.lblSearchFurnizori.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchFurnizori.Location = new System.Drawing.Point(453, 9);
            this.lblSearchFurnizori.Name = "lblSearchFurnizori";
            this.lblSearchFurnizori.Size = new System.Drawing.Size(75, 30);
            this.lblSearchFurnizori.TabIndex = 7;
            this.lblSearchFurnizori.Text = "Search";
            this.lblSearchFurnizori.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdaugaFurnizori
            // 
            this.btnAdaugaFurnizori.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdaugaFurnizori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdaugaFurnizori.Location = new System.Drawing.Point(13, 270);
            this.btnAdaugaFurnizori.Name = "btnAdaugaFurnizori";
            this.btnAdaugaFurnizori.Size = new System.Drawing.Size(350, 41);
            this.btnAdaugaFurnizori.TabIndex = 9;
            this.btnAdaugaFurnizori.Text = "Adauga";
            this.btnAdaugaFurnizori.UseVisualStyleBackColor = false;
            this.btnAdaugaFurnizori.Click += new System.EventHandler(this.btnAdaugaFurnizori_Click);
            // 
            // btnUpdateFurnizori
            // 
            this.btnUpdateFurnizori.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdateFurnizori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateFurnizori.Location = new System.Drawing.Point(13, 328);
            this.btnUpdateFurnizori.Name = "btnUpdateFurnizori";
            this.btnUpdateFurnizori.Size = new System.Drawing.Size(350, 41);
            this.btnUpdateFurnizori.TabIndex = 10;
            this.btnUpdateFurnizori.Text = "Update";
            this.btnUpdateFurnizori.UseVisualStyleBackColor = false;
            this.btnUpdateFurnizori.Click += new System.EventHandler(this.btnUpdateFurnizori_Click);
            // 
            // btnStergeFurnizori
            // 
            this.btnStergeFurnizori.BackColor = System.Drawing.Color.Crimson;
            this.btnStergeFurnizori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStergeFurnizori.Location = new System.Drawing.Point(13, 386);
            this.btnStergeFurnizori.Name = "btnStergeFurnizori";
            this.btnStergeFurnizori.Size = new System.Drawing.Size(350, 41);
            this.btnStergeFurnizori.TabIndex = 11;
            this.btnStergeFurnizori.Text = "Sterge";
            this.btnStergeFurnizori.UseVisualStyleBackColor = false;
            this.btnStergeFurnizori.Click += new System.EventHandler(this.btnStergeFurnizori_Click);
            // 
            // formFurnizori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnStergeFurnizori);
            this.Controls.Add(this.btnUpdateFurnizori);
            this.Controls.Add(this.btnAdaugaFurnizori);
            this.Controls.Add(this.txtSearchFurnizori);
            this.Controls.Add(this.lblSearchFurnizori);
            this.Controls.Add(this.dgvFurnizori);
            this.Controls.Add(this.txtLocatieFurnizor);
            this.Controls.Add(this.txtNumeFurnizor);
            this.Controls.Add(this.txtIdFurnizor);
            this.Controls.Add(this.lblLocatieFurnizor);
            this.Controls.Add(this.lblNumeFurnizor);
            this.Controls.Add(this.lblIdFurnizor);
            this.Name = "formFurnizori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furnizori";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnizori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdFurnizor;
        private System.Windows.Forms.Label lblNumeFurnizor;
        private System.Windows.Forms.Label lblLocatieFurnizor;
        private System.Windows.Forms.TextBox txtIdFurnizor;
        private System.Windows.Forms.TextBox txtNumeFurnizor;
        private System.Windows.Forms.TextBox txtLocatieFurnizor;
        private System.Windows.Forms.DataGridView dgvFurnizori;
        private System.Windows.Forms.TextBox txtSearchFurnizori;
        private System.Windows.Forms.Label lblSearchFurnizori;
        private System.Windows.Forms.Button btnAdaugaFurnizori;
        private System.Windows.Forms.Button btnUpdateFurnizori;
        private System.Windows.Forms.Button btnStergeFurnizori;
    }
}