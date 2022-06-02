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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.CreationProduit = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.creationProduitGroupBox = new System.Windows.Forms.GroupBox();
            this.descProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.descProduitCreationLabel = new System.Windows.Forms.Label();
            this.prixProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.qtyProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.catProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.nomProduitCreationTextBox = new System.Windows.Forms.TextBox();
            this.prixProduitCreationLabel = new System.Windows.Forms.Label();
            this.qtyProduitCreationLabel = new System.Windows.Forms.Label();
            this.catProduitCreationLabel = new System.Windows.Forms.Label();
            this.nomProduitCreationLabel = new System.Windows.Forms.Label();
            this.btnCreation = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.modifyProductGroupBox = new System.Windows.Forms.GroupBox();
            this.modifyProductDescTextField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modifyProductPriceTextField = new System.Windows.Forms.TextBox();
            this.modifyProductQtyTextField = new System.Windows.Forms.TextBox();
            this.modifyProductCatTextField = new System.Windows.Forms.TextBox();
            this.modifyProductNameTextField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.productsListView = new MaterialSkin.Controls.MaterialListView();
            this.produitId = new System.Windows.Forms.ColumnHeader();
            this.produitNom = new System.Windows.Forms.ColumnHeader();
            this.produitCategorie = new System.Windows.Forms.ColumnHeader();
            this.produitQty = new System.Windows.Forms.ColumnHeader();
            this.produitPrix = new System.Windows.Forms.ColumnHeader();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.produitIdLabel = new System.Windows.Forms.Label();
            this.CreationProduit.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.creationProduitGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.modifyProductGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(688, 32);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Rechercher";
            this.searchTextBox.Size = new System.Drawing.Size(100, 23);
            this.searchTextBox.TabIndex = 13;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.CreationProduit;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-12, 60);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(825, 23);
            this.materialTabSelector1.TabIndex = 14;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // CreationProduit
            // 
            this.CreationProduit.Controls.Add(this.tabPage1);
            this.CreationProduit.Controls.Add(this.tabPage2);
            this.CreationProduit.Depth = 0;
            this.CreationProduit.Location = new System.Drawing.Point(12, 89);
            this.CreationProduit.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreationProduit.Name = "CreationProduit";
            this.CreationProduit.SelectedIndex = 0;
            this.CreationProduit.Size = new System.Drawing.Size(776, 351);
            this.CreationProduit.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.creationProduitGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Créer Produit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // creationProduitGroupBox
            // 
            this.creationProduitGroupBox.Controls.Add(this.descProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.descProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.prixProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.qtyProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.catProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.nomProduitCreationTextBox);
            this.creationProduitGroupBox.Controls.Add(this.prixProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.qtyProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.catProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.nomProduitCreationLabel);
            this.creationProduitGroupBox.Controls.Add(this.btnCreation);
            this.creationProduitGroupBox.Location = new System.Drawing.Point(213, 6);
            this.creationProduitGroupBox.Name = "creationProduitGroupBox";
            this.creationProduitGroupBox.Size = new System.Drawing.Size(311, 364);
            this.creationProduitGroupBox.TabIndex = 2;
            this.creationProduitGroupBox.TabStop = false;
            this.creationProduitGroupBox.Text = "Création Produit";
            // 
            // descProduitCreationTextBox
            // 
            this.descProduitCreationTextBox.Location = new System.Drawing.Point(7, 228);
            this.descProduitCreationTextBox.Name = "descProduitCreationTextBox";
            this.descProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.descProduitCreationTextBox.TabIndex = 12;
            // 
            // descProduitCreationLabel
            // 
            this.descProduitCreationLabel.AutoSize = true;
            this.descProduitCreationLabel.Location = new System.Drawing.Point(7, 210);
            this.descProduitCreationLabel.Name = "descProduitCreationLabel";
            this.descProduitCreationLabel.Size = new System.Drawing.Size(109, 15);
            this.descProduitCreationLabel.TabIndex = 11;
            this.descProduitCreationLabel.Text = "Description Produit";
            // 
            // prixProduitCreationTextBox
            // 
            this.prixProduitCreationTextBox.Location = new System.Drawing.Point(5, 184);
            this.prixProduitCreationTextBox.Name = "prixProduitCreationTextBox";
            this.prixProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.prixProduitCreationTextBox.TabIndex = 10;
            // 
            // qtyProduitCreationTextBox
            // 
            this.qtyProduitCreationTextBox.Location = new System.Drawing.Point(6, 140);
            this.qtyProduitCreationTextBox.Name = "qtyProduitCreationTextBox";
            this.qtyProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyProduitCreationTextBox.TabIndex = 9;
            // 
            // catProduitCreationTextBox
            // 
            this.catProduitCreationTextBox.Location = new System.Drawing.Point(5, 96);
            this.catProduitCreationTextBox.Name = "catProduitCreationTextBox";
            this.catProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.catProduitCreationTextBox.TabIndex = 8;
            // 
            // nomProduitCreationTextBox
            // 
            this.nomProduitCreationTextBox.Location = new System.Drawing.Point(6, 52);
            this.nomProduitCreationTextBox.Name = "nomProduitCreationTextBox";
            this.nomProduitCreationTextBox.Size = new System.Drawing.Size(100, 23);
            this.nomProduitCreationTextBox.TabIndex = 7;
            // 
            // prixProduitCreationLabel
            // 
            this.prixProduitCreationLabel.AutoSize = true;
            this.prixProduitCreationLabel.Location = new System.Drawing.Point(5, 166);
            this.prixProduitCreationLabel.Name = "prixProduitCreationLabel";
            this.prixProduitCreationLabel.Size = new System.Drawing.Size(69, 15);
            this.prixProduitCreationLabel.TabIndex = 5;
            this.prixProduitCreationLabel.Text = "Prix Produit";
            // 
            // qtyProduitCreationLabel
            // 
            this.qtyProduitCreationLabel.AutoSize = true;
            this.qtyProduitCreationLabel.Location = new System.Drawing.Point(7, 122);
            this.qtyProduitCreationLabel.Name = "qtyProduitCreationLabel";
            this.qtyProduitCreationLabel.Size = new System.Drawing.Size(95, 15);
            this.qtyProduitCreationLabel.TabIndex = 4;
            this.qtyProduitCreationLabel.Text = "Quantité Produit";
            // 
            // catProduitCreationLabel
            // 
            this.catProduitCreationLabel.AutoSize = true;
            this.catProduitCreationLabel.Location = new System.Drawing.Point(6, 78);
            this.catProduitCreationLabel.Name = "catProduitCreationLabel";
            this.catProduitCreationLabel.Size = new System.Drawing.Size(100, 15);
            this.catProduitCreationLabel.TabIndex = 3;
            this.catProduitCreationLabel.Text = "Catégorie Produit";
            // 
            // nomProduitCreationLabel
            // 
            this.nomProduitCreationLabel.AutoSize = true;
            this.nomProduitCreationLabel.Location = new System.Drawing.Point(6, 34);
            this.nomProduitCreationLabel.Name = "nomProduitCreationLabel";
            this.nomProduitCreationLabel.Size = new System.Drawing.Size(76, 15);
            this.nomProduitCreationLabel.TabIndex = 2;
            this.nomProduitCreationLabel.Text = "Nom Produit";
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(166, 140);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(75, 23);
            this.btnCreation.TabIndex = 1;
            this.btnCreation.Text = "Créer";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialRaisedButton1);
            this.tabPage2.Controls.Add(this.modifyProductGroupBox);
            this.tabPage2.Controls.Add(this.productsListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modifier Produit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(3, 284);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(596, 36);
            this.materialRaisedButton1.TabIndex = 17;
            this.materialRaisedButton1.Text = "Actualiser";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // modifyProductGroupBox
            // 
            this.modifyProductGroupBox.Controls.Add(this.produitIdLabel);
            this.modifyProductGroupBox.Controls.Add(this.deleteProductButton);
            this.modifyProductGroupBox.Controls.Add(this.modifyProductDescTextField);
            this.modifyProductGroupBox.Controls.Add(this.label7);
            this.modifyProductGroupBox.Controls.Add(this.modifyProductPriceTextField);
            this.modifyProductGroupBox.Controls.Add(this.modifyProductQtyTextField);
            this.modifyProductGroupBox.Controls.Add(this.modifyProductCatTextField);
            this.modifyProductGroupBox.Controls.Add(this.modifyProductNameTextField);
            this.modifyProductGroupBox.Controls.Add(this.label8);
            this.modifyProductGroupBox.Controls.Add(this.label9);
            this.modifyProductGroupBox.Controls.Add(this.label10);
            this.modifyProductGroupBox.Controls.Add(this.label11);
            this.modifyProductGroupBox.Controls.Add(this.modifyProductButton);
            this.modifyProductGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.modifyProductGroupBox.Location = new System.Drawing.Point(599, 3);
            this.modifyProductGroupBox.Name = "modifyProductGroupBox";
            this.modifyProductGroupBox.Size = new System.Drawing.Size(166, 317);
            this.modifyProductGroupBox.TabIndex = 16;
            this.modifyProductGroupBox.TabStop = false;
            this.modifyProductGroupBox.Text = "Modifier Produit";
            // 
            // modifyProductDescTextField
            // 
            this.modifyProductDescTextField.Location = new System.Drawing.Point(7, 228);
            this.modifyProductDescTextField.Name = "modifyProductDescTextField";
            this.modifyProductDescTextField.Size = new System.Drawing.Size(100, 23);
            this.modifyProductDescTextField.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description Produit";
            // 
            // modifyProductPriceTextField
            // 
            this.modifyProductPriceTextField.Location = new System.Drawing.Point(5, 184);
            this.modifyProductPriceTextField.Name = "modifyProductPriceTextField";
            this.modifyProductPriceTextField.Size = new System.Drawing.Size(100, 23);
            this.modifyProductPriceTextField.TabIndex = 10;
            // 
            // modifyProductQtyTextField
            // 
            this.modifyProductQtyTextField.Location = new System.Drawing.Point(6, 140);
            this.modifyProductQtyTextField.Name = "modifyProductQtyTextField";
            this.modifyProductQtyTextField.Size = new System.Drawing.Size(100, 23);
            this.modifyProductQtyTextField.TabIndex = 9;
            // 
            // modifyProductCatTextField
            // 
            this.modifyProductCatTextField.Location = new System.Drawing.Point(5, 96);
            this.modifyProductCatTextField.Name = "modifyProductCatTextField";
            this.modifyProductCatTextField.Size = new System.Drawing.Size(100, 23);
            this.modifyProductCatTextField.TabIndex = 8;
            // 
            // modifyProductNameTextField
            // 
            this.modifyProductNameTextField.Location = new System.Drawing.Point(6, 52);
            this.modifyProductNameTextField.Name = "modifyProductNameTextField";
            this.modifyProductNameTextField.Size = new System.Drawing.Size(100, 23);
            this.modifyProductNameTextField.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Prix Produit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Quantité Produit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Catégorie Produit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nom Produit";
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(7, 267);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductButton.TabIndex = 1;
            this.modifyProductButton.Text = "Modifier";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // productsListView
            // 
            this.productsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.produitId,
            this.produitNom,
            this.produitCategorie,
            this.produitQty,
            this.produitPrix});
            this.productsListView.Depth = 0;
            this.productsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsListView.FullRowSelect = true;
            this.productsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(3, 3);
            this.productsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.productsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.productsListView.Name = "productsListView";
            this.productsListView.OwnerDraw = true;
            this.productsListView.Size = new System.Drawing.Size(597, 275);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            this.productsListView.Click += new System.EventHandler(this.productsListView_Click);
            // 
            // produitId
            // 
            this.produitId.Text = "ID";
            // 
            // produitNom
            // 
            this.produitNom.Text = "Nom";
            this.produitNom.Width = 150;
            // 
            // produitCategorie
            // 
            this.produitCategorie.Text = "Catégorie";
            this.produitCategorie.Width = 150;
            // 
            // produitQty
            // 
            this.produitQty.Text = "Quantité";
            this.produitQty.Width = 135;
            // 
            // produitPrix
            // 
            this.produitPrix.Text = "Prix";
            this.produitPrix.Width = 104;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(88, 267);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 13;
            this.deleteProductButton.Text = "Supprimer";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // produitIdLabel
            // 
            this.produitIdLabel.AutoSize = true;
            this.produitIdLabel.Location = new System.Drawing.Point(8, 15);
            this.produitIdLabel.Name = "produitIdLabel";
            this.produitIdLabel.Size = new System.Drawing.Size(0, 15);
            this.produitIdLabel.TabIndex = 14;
            this.produitIdLabel.Visible = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreationProduit);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.searchTextBox);
            this.Name = "BaseForm";
            this.Text = "HubMarket Desktop";
            this.CreationProduit.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.creationProduitGroupBox.ResumeLayout(false);
            this.creationProduitGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.modifyProductGroupBox.ResumeLayout(false);
            this.modifyProductGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.GroupBox creaProduitBox;
        private System.Windows.Forms.Label produitIdLabel;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl CreationProduit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Label fournisseurCreationLabel;
        private System.Windows.Forms.Button btnCreation;
        private MaterialSkin.Controls.MaterialListView productsListView;
        private System.Windows.Forms.ColumnHeader produitId;
        private System.Windows.Forms.ColumnHeader produitNom;
        private System.Windows.Forms.ColumnHeader produitQty;
        private System.Windows.Forms.ColumnHeader produitPrix;
        private System.Windows.Forms.GroupBox modifyProductGroupBox;
        private System.Windows.Forms.TextBox modifyProductDescTextField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modifyProductPriceTextField;
        private System.Windows.Forms.TextBox modifyProductQtyTextField;
        private System.Windows.Forms.TextBox modifyProductCatTextField;
        private System.Windows.Forms.TextBox modifyProductNameTextField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.ColumnHeader produitCategorie;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Button deleteProductButton;
    }
}