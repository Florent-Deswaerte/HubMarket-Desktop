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
            System.Windows.Forms.TextBox prixProduitModifTextBox;
            this.fournisseurCreationLabel = new System.Windows.Forms.Label();
            this.btnCreation = new System.Windows.Forms.Button();
            this.creationProduitGroupBox = new System.Windows.Forms.GroupBox();
            this.descProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.descProduitCreationLabel = new System.Windows.Forms.Label();
            this.prixProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.qtyProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.catProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.nomProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.fournisseurCreationTextBox = new System.Windows.Forms.TextBox();
            this.prixProduitCreationLabel = new System.Windows.Forms.Label();
            this.qtyProduitCreationLabel = new System.Windows.Forms.Label();
            this.catProduitCreationLabel = new System.Windows.Forms.Label();
            this.nomProduitCreationLabel = new System.Windows.Forms.Label();
            this.modificationProduitGroupBox = new System.Windows.Forms.GroupBox();
            this.descProduitModifTextBox = new System.Windows.Forms.TextBox();
            this.descProduitModifLabel = new System.Windows.Forms.Label();
            this.qtyProduitModifTextBox = new System.Windows.Forms.TextBox();
            this.catProduitModifTextBox = new System.Windows.Forms.TextBox();
            this.nomProduitModifTextBox = new System.Windows.Forms.TextBox();
            this.fournisseurModifTextBox = new System.Windows.Forms.TextBox();
            this.prixProduitModifLabel = new System.Windows.Forms.Label();
            this.qtyProduitModifLabel = new System.Windows.Forms.Label();
            this.catProduitModifLabel = new System.Windows.Forms.Label();
            this.nomProduitModifLabel = new System.Windows.Forms.Label();
            this.fournisseurModifLabel = new System.Windows.Forms.Label();
            this.btnModification = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            prixProduitModifTextBox = new System.Windows.Forms.TextBox();
            this.creationProduitGroupBox.SuspendLayout();
            this.modificationProduitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fournisseurCreationLabel
            // 
            this.fournisseurCreationLabel.AutoSize = true;
            this.fournisseurCreationLabel.Location = new System.Drawing.Point(5, 35);
            this.fournisseurCreationLabel.Name = "fournisseurCreationLabel";
            this.fournisseurCreationLabel.Size = new System.Drawing.Size(98, 15);
            this.fournisseurCreationLabel.TabIndex = 0;
            this.fournisseurCreationLabel.Text = "Nom Fournisseur";
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(7, 335);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(75, 23);
            this.btnCreation.TabIndex = 1;
            this.btnCreation.Text = "Créer";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // creationProduitGroupBox
            // 
            this.creationProduitGroupBox.Controls.Add(this.descProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.descProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.prixProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.qtyProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.catProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.nomProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.fournisseurCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.prixProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.qtyProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.catProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.nomProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.fournisseurCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.btnCreation);
            this.creationProduitGroupBox.Location = new System.Drawing.Point(477, 74);
            this.creationProduitGroupBox.Name = "creationProduitGroupBox";
            this.creationProduitGroupBox.Size = new System.Drawing.Size(311, 364);
            this.creationProduitGroupBox.TabIndex = 2;
            this.creationProduitGroupBox.TabStop = false;
            this.creationProduitGroupBox.Text = "Création Produit";
            // 
            // descProduitCreationTextBox
            // 
            this.descProduitCreationTextBox.Location = new System.Drawing.Point(7, 273);
            this.descProduitCreationTextBox.Name = "descProduitCreationTextBox";
            this.descProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.descProduitCreationTextBox.TabIndex = 12;
            // 
            // descProduitCreationLabel
            // 
            this.descProduitCreationLabel.AutoSize = true;
            this.descProduitCreationLabel.Location = new System.Drawing.Point(7, 255);
            this.descProduitCreationLabel.Name = "descProduitCreationLabel";
            this.descProduitCreationLabel.Size = new System.Drawing.Size(109, 15);
            this.descProduitCreationLabel.TabIndex = 11;
            this.descProduitCreationLabel.Text = "Description Produit";
            // 
            // prixProduitCreationTextBox
            // 
            this.prixProduitCreationTextBox.Location = new System.Drawing.Point(5, 229);
            this.prixProduitCreationTextBox.Name = "prixProduitCreationTextBox";
            this.prixProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.prixProduitCreationTextBox.TabIndex = 10;
            // 
            // qtyProduitCreationTextBox
            // 
            this.qtyProduitCreationTextBox.Location = new System.Drawing.Point(6, 185);
            this.qtyProduitCreationTextBox.Name = "qtyProduitCreationTextBox";
            this.qtyProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyProduitCreationTextBox.TabIndex = 9;
            // 
            // catProduitCreationTextBox
            // 
            this.catProduitCreationTextBox.Location = new System.Drawing.Point(5, 141);
            this.catProduitCreationTextBox.Name = "catProduitCreationTextBox";
            this.catProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.catProduitCreationTextBox.TabIndex = 8;
            // 
            // nomProduitCreationTextBox
            // 
            this.nomProduitCreationTextBox.Location = new System.Drawing.Point(6, 97);
            this.nomProduitCreationTextBox.Name = "nomProduitCreationTextBox";
            this.nomProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.nomProduitCreationTextBox.TabIndex = 7;
            // 
            // fournisseurCreationTextBox
            // 
            this.fournisseurCreationTextBox.Location = new System.Drawing.Point(5, 53);
            this.fournisseurCreationTextBox.Name = "fournisseurCreationTextBox";
            this.fournisseurCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.fournisseurCreationTextBox.TabIndex = 6;
            // 
            // prixProduitCreationLabel
            // 
            this.prixProduitCreationLabel.AutoSize = true;
            this.prixProduitCreationLabel.Location = new System.Drawing.Point(5, 211);
            this.prixProduitCreationLabel.Name = "prixProduitCreationLabel";
            this.prixProduitCreationLabel.Size = new System.Drawing.Size(69, 15);
            this.prixProduitCreationLabel.TabIndex = 5;
            this.prixProduitCreationLabel.Text = "Prix Produit";
            // 
            // qtyProduitCreationLabel
            // 
            this.qtyProduitCreationLabel.AutoSize = true;
            this.qtyProduitCreationLabel.Location = new System.Drawing.Point(0, 167);
            this.qtyProduitCreationLabel.Name = "qtyProduitCreationLabel";
            this.qtyProduitCreationLabel.Size = new System.Drawing.Size(95, 15);
            this.qtyProduitCreationLabel.TabIndex = 4;
            this.qtyProduitCreationLabel.Text = "Quantité Produit";
            // 
            // catProduitCreationLabel
            // 
            this.catProduitCreationLabel.AutoSize = true;
            this.catProduitCreationLabel.Location = new System.Drawing.Point(6, 123);
            this.catProduitCreationLabel.Name = "catProduitCreationLabel";
            this.catProduitCreationLabel.Size = new System.Drawing.Size(100, 15);
            this.catProduitCreationLabel.TabIndex = 3;
            this.catProduitCreationLabel.Text = "Catégorie Produit";
            // 
            // nomProduitCreationLabel
            // 
            this.nomProduitCreationLabel.AutoSize = true;
            this.nomProduitCreationLabel.Location = new System.Drawing.Point(6, 79);
            this.nomProduitCreationLabel.Name = "nomProduitCreationLabel";
            this.nomProduitCreationLabel.Size = new System.Drawing.Size(76, 15);
            this.nomProduitCreationLabel.TabIndex = 2;
            this.nomProduitCreationLabel.Text = "Nom Produit";
            // 
            // modificationProduitGroupBox
            // 
            this.modificationProduitGroupBox.Controls.Add(this.descProduitModifTextBox);
            this.modificationProduitGroupBox.Controls.Add(this.descProduitModifLabel);
            this.modificationProduitGroupBox.Controls.Add(prixProduitModifTextBox);
            this.modificationProduitGroupBox.Controls.Add(this.qtyProduitModifTextBox);
            this.modificationProduitGroupBox.Controls.Add(this.catProduitModifTextBox);
            this.modificationProduitGroupBox.Controls.Add(this.nomProduitModifTextBox);
            this.modificationProduitGroupBox.Controls.Add(this.fournisseurModifTextBox);
            this.modificationProduitGroupBox.Controls.Add(this.prixProduitModifLabel);
            this.modificationProduitGroupBox.Controls.Add(this.qtyProduitModifLabel);
            this.modificationProduitGroupBox.Controls.Add(this.catProduitModifLabel);
            this.modificationProduitGroupBox.Controls.Add(this.nomProduitModifLabel);
            this.modificationProduitGroupBox.Controls.Add(this.fournisseurModifLabel);
            this.modificationProduitGroupBox.Controls.Add(this.btnModification);
            this.modificationProduitGroupBox.Location = new System.Drawing.Point(160, 74);
            this.modificationProduitGroupBox.Name = "modificationProduitGroupBox";
            this.modificationProduitGroupBox.Size = new System.Drawing.Size(311, 364);
            this.modificationProduitGroupBox.TabIndex = 3;
            this.modificationProduitGroupBox.TabStop = false;
            this.modificationProduitGroupBox.Text = "Modification Produit";
            // 
            // descProduitModifTextBox
            // 
            this.descProduitModifTextBox.Location = new System.Drawing.Point(7, 273);
            this.descProduitModifTextBox.Name = "descProduitModifTextBox";
            this.descProduitModifTextBox.Size = new System.Drawing.Size(100, 23);
            this.descProduitModifTextBox.TabIndex = 12;
            // 
            // descProduitModifLabel
            // 
            this.descProduitModifLabel.AutoSize = true;
            this.descProduitModifLabel.Location = new System.Drawing.Point(7, 255);
            this.descProduitModifLabel.Name = "descProduitModifLabel";
            this.descProduitModifLabel.Size = new System.Drawing.Size(109, 15);
            this.descProduitModifLabel.TabIndex = 11;
            this.descProduitModifLabel.Text = "Description Produit";
            // 
            // prixProduitModifTextBox
            // 
            prixProduitModifTextBox.Location = new System.Drawing.Point(5, 229);
            prixProduitModifTextBox.Name = "prixProduitModifTextBox";
            prixProduitModifTextBox.Size = new System.Drawing.Size(100, 23);
            prixProduitModifTextBox.TabIndex = 10;
            // 
            // qtyProduitModifTextBox
            // 
            this.qtyProduitModifTextBox.Location = new System.Drawing.Point(6, 185);
            this.qtyProduitModifTextBox.Name = "qtyProduitModifTextBox";
            this.qtyProduitModifTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyProduitModifTextBox.TabIndex = 9;
            // 
            // catProduitModifTextBox
            // 
            this.catProduitModifTextBox.Location = new System.Drawing.Point(5, 141);
            this.catProduitModifTextBox.Name = "catProduitModifTextBox";
            this.catProduitModifTextBox.Size = new System.Drawing.Size(100, 23);
            this.catProduitModifTextBox.TabIndex = 8;
            // 
            // nomProduitModifTextBox
            // 
            this.nomProduitModifTextBox.Location = new System.Drawing.Point(6, 97);
            this.nomProduitModifTextBox.Name = "nomProduitModifTextBox";
            this.nomProduitModifTextBox.Size = new System.Drawing.Size(100, 23);
            this.nomProduitModifTextBox.TabIndex = 7;
            // 
            // fournisseurModifTextBox
            // 
            this.fournisseurModifTextBox.Location = new System.Drawing.Point(5, 53);
            this.fournisseurModifTextBox.Name = "fournisseurModifTextBox";
            this.fournisseurModifTextBox.Size = new System.Drawing.Size(100, 23);
            this.fournisseurModifTextBox.TabIndex = 6;
            // 
            // prixProduitModifLabel
            // 
            this.prixProduitModifLabel.AutoSize = true;
            this.prixProduitModifLabel.Location = new System.Drawing.Point(5, 211);
            this.prixProduitModifLabel.Name = "prixProduitModifLabel";
            this.prixProduitModifLabel.Size = new System.Drawing.Size(69, 15);
            this.prixProduitModifLabel.TabIndex = 5;
            this.prixProduitModifLabel.Text = "Prix Produit";
            // 
            // qtyProduitModifLabel
            // 
            this.qtyProduitModifLabel.AutoSize = true;
            this.qtyProduitModifLabel.Location = new System.Drawing.Point(6, 167);
            this.qtyProduitModifLabel.Name = "qtyProduitModifLabel";
            this.qtyProduitModifLabel.Size = new System.Drawing.Size(95, 15);
            this.qtyProduitModifLabel.TabIndex = 4;
            this.qtyProduitModifLabel.Text = "Quantité Produit";
            // 
            // catProduitModifLabel
            // 
            this.catProduitModifLabel.AutoSize = true;
            this.catProduitModifLabel.Location = new System.Drawing.Point(6, 123);
            this.catProduitModifLabel.Name = "catProduitModifLabel";
            this.catProduitModifLabel.Size = new System.Drawing.Size(100, 15);
            this.catProduitModifLabel.TabIndex = 3;
            this.catProduitModifLabel.Text = "Catégorie Produit";
            // 
            // nomProduitModifLabel
            // 
            this.nomProduitModifLabel.AutoSize = true;
            this.nomProduitModifLabel.Location = new System.Drawing.Point(6, 79);
            this.nomProduitModifLabel.Name = "nomProduitModifLabel";
            this.nomProduitModifLabel.Size = new System.Drawing.Size(76, 15);
            this.nomProduitModifLabel.TabIndex = 2;
            this.nomProduitModifLabel.Text = "Nom Produit";
            // 
            // fournisseurModifLabel
            // 
            this.fournisseurModifLabel.AutoSize = true;
            this.fournisseurModifLabel.Location = new System.Drawing.Point(5, 35);
            this.fournisseurModifLabel.Name = "fournisseurModifLabel";
            this.fournisseurModifLabel.Size = new System.Drawing.Size(98, 15);
            this.fournisseurModifLabel.TabIndex = 0;
            this.fournisseurModifLabel.Text = "Nom Fournisseur";
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(7, 335);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(75, 23);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "Modifier";
            this.btnModification.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(688, 32);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Rechercher";
            this.searchTextBox.Size = new System.Drawing.Size(100, 23);
            this.searchTextBox.TabIndex = 13;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.modificationProduitGroupBox);
            this.Controls.Add(this.creationProduitGroupBox);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.creationProduitGroupBox.ResumeLayout(false);
            this.creationProduitGroupBox.PerformLayout();
            this.modificationProduitGroupBox.ResumeLayout(false);
            this.modificationProduitGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label fournisseurCreationLabel;
        private System.Windows.Forms.GroupBox creationProduitGroupBox;
        private System.Windows.Forms.TextBox descProduitCreationTextBox;
        private System.Windows.Forms.Label descProduitCreationLabel;
        private System.Windows.Forms.TextBox prixProduitCreationTextBox;
        private System.Windows.Forms.TextBox qtyProduitCreationTextBox;
        private System.Windows.Forms.TextBox catProduitCreationTextBox;
        private System.Windows.Forms.TextBox nomProduitCreationTextBox;
        private System.Windows.Forms.TextBox fournisseurCreationTextBox;
        private System.Windows.Forms.Label prixProduitCreationLabel;
        private System.Windows.Forms.Label qtyProduitCreationLabel;
        private System.Windows.Forms.Label catProduitCreationLabel;
        private System.Windows.Forms.Label nomProduitCreationLabel;
        private System.Windows.Forms.GroupBox modificationProduitGroupBox;
        private System.Windows.Forms.TextBox descProduitModifTextBox;
        private System.Windows.Forms.Label descProduitModifLabel;
        private System.Windows.Forms.TextBox qtyProduitModifTextBox;
        private System.Windows.Forms.TextBox catProduitModifTextBox;
        private System.Windows.Forms.TextBox nomProduitModifTextBox;
        private System.Windows.Forms.TextBox fournisseurModifTextBox;
        private System.Windows.Forms.Label prixProduitModifLabel;
        private System.Windows.Forms.Label qtyProduitModifLabel;
        private System.Windows.Forms.Label catProduitModifLabel;
        private System.Windows.Forms.Label nomProduitModifLabel;
        private System.Windows.Forms.Label fournisseurModifLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Button btnModification;
    }
}