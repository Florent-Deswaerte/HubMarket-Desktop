namespace HubMarket_Desktop
{
    partial class BaseForm
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
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.creaProduitBox = new System.Windows.Forms.GroupBox();
            this.prixProduitTextBox = new System.Windows.Forms.TextBox();
            this.qtyProduitTextBox = new System.Windows.Forms.TextBox();
            this.catProduitTextBox = new System.Windows.Forms.TextBox();
            this.nomProduitTextBox = new System.Windows.Forms.TextBox();
            this.fournisseurTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionProduitTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.creaProduitBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Fournisseur";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(7, 335);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 1;
            this.btnEnvoyer.Text = "Créer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // creaProduitBox
            // 
            this.creaProduitBox.Controls.Add(this.descriptionProduitTextBox);
            this.creaProduitBox.Controls.Add(this.label6);
            this.creaProduitBox.Controls.Add(this.prixProduitTextBox);
            this.creaProduitBox.Controls.Add(this.qtyProduitTextBox);
            this.creaProduitBox.Controls.Add(this.catProduitTextBox);
            this.creaProduitBox.Controls.Add(this.nomProduitTextBox);
            this.creaProduitBox.Controls.Add(this.fournisseurTextBox);
            this.creaProduitBox.Controls.Add(this.label5);
            this.creaProduitBox.Controls.Add(this.label4);
            this.creaProduitBox.Controls.Add(this.label3);
            this.creaProduitBox.Controls.Add(this.label2);
            this.creaProduitBox.Controls.Add(this.label1);
            this.creaProduitBox.Controls.Add(this.btnEnvoyer);
            this.creaProduitBox.Location = new System.Drawing.Point(477, 74);
            this.creaProduitBox.Name = "creaProduitBox";
            this.creaProduitBox.Size = new System.Drawing.Size(311, 364);
            this.creaProduitBox.TabIndex = 2;
            this.creaProduitBox.TabStop = false;
            this.creaProduitBox.Text = "Création Produit";
            // 
            // prixProduitTextBox
            // 
            this.prixProduitTextBox.Location = new System.Drawing.Point(5, 229);
            this.prixProduitTextBox.Name = "prixProduitTextBox";
            this.prixProduitTextBox.Size = new System.Drawing.Size(100, 23);
            this.prixProduitTextBox.TabIndex = 10;
            // 
            // qtyProduitTextBox
            // 
            this.qtyProduitTextBox.Location = new System.Drawing.Point(6, 185);
            this.qtyProduitTextBox.Name = "qtyProduitTextBox";
            this.qtyProduitTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyProduitTextBox.TabIndex = 9;
            // 
            // catProduitTextBox
            // 
            this.catProduitTextBox.Location = new System.Drawing.Point(5, 141);
            this.catProduitTextBox.Name = "catProduitTextBox";
            this.catProduitTextBox.Size = new System.Drawing.Size(100, 23);
            this.catProduitTextBox.TabIndex = 8;
            // 
            // nomProduitTextBox
            // 
            this.nomProduitTextBox.Location = new System.Drawing.Point(6, 97);
            this.nomProduitTextBox.Name = "nomProduitTextBox";
            this.nomProduitTextBox.Size = new System.Drawing.Size(100, 23);
            this.nomProduitTextBox.TabIndex = 7;
            // 
            // fournisseurTextBox
            // 
            this.fournisseurTextBox.Location = new System.Drawing.Point(5, 53);
            this.fournisseurTextBox.Name = "fournisseurTextBox";
            this.fournisseurTextBox.Size = new System.Drawing.Size(100, 23);
            this.fournisseurTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prix Produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantitée Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Catégorie Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom Produit";
            // 
            // descriptionProduitTextBox
            // 
            this.descriptionProduitTextBox.Location = new System.Drawing.Point(7, 273);
            this.descriptionProduitTextBox.Name = "descriptionProduitTextBox";
            this.descriptionProduitTextBox.Size = new System.Drawing.Size(100, 23);
            this.descriptionProduitTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description Produit";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.creaProduitBox);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.creaProduitBox.ResumeLayout(false);
            this.creaProduitBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.GroupBox creaProduitBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prixProduitTextBox;
        private System.Windows.Forms.TextBox qtyProduitTextBox;
        private System.Windows.Forms.TextBox catProduitTextBox;
        private System.Windows.Forms.TextBox nomProduitTextBox;
        private System.Windows.Forms.TextBox fournisseurTextBox;
        private System.Windows.Forms.TextBox descriptionProduitTextBox;

    }
}