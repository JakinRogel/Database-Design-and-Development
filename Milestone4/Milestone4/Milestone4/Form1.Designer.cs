namespace Milestone4
{
    partial class Form1
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
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.searchProductsBtn = new System.Windows.Forms.Button();
            this.searchProductTxtBox = new System.Windows.Forms.TextBox();
            this.showAllProductsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.searchCategoriesBtn = new System.Windows.Forms.Button();
            this.searchCategoriesTxtBox = new System.Windows.Forms.TextBox();
            this.showAllCategoriesBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productRetailPriceTxtBox = new System.Windows.Forms.TextBox();
            this.productWholesalePriceTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.productNameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.categoryNameTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryIdTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Location = new System.Drawing.Point(833, 276);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(215, 23);
            this.deleteProductBtn.TabIndex = 39;
            this.deleteProductBtn.Text = "Delete Selected Product";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // searchProductsBtn
            // 
            this.searchProductsBtn.Location = new System.Drawing.Point(752, 275);
            this.searchProductsBtn.Name = "searchProductsBtn";
            this.searchProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchProductsBtn.TabIndex = 38;
            this.searchProductsBtn.Text = "Search";
            this.searchProductsBtn.UseVisualStyleBackColor = true;
            this.searchProductsBtn.Click += new System.EventHandler(this.searchProductsBtn_Click);
            // 
            // searchProductTxtBox
            // 
            this.searchProductTxtBox.Location = new System.Drawing.Point(434, 276);
            this.searchProductTxtBox.Name = "searchProductTxtBox";
            this.searchProductTxtBox.Size = new System.Drawing.Size(312, 23);
            this.searchProductTxtBox.TabIndex = 37;
            // 
            // showAllProductsBtn
            // 
            this.showAllProductsBtn.Location = new System.Drawing.Point(353, 276);
            this.showAllProductsBtn.Name = "showAllProductsBtn";
            this.showAllProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.showAllProductsBtn.TabIndex = 36;
            this.showAllProductsBtn.Text = "Show All";
            this.showAllProductsBtn.UseVisualStyleBackColor = true;
            this.showAllProductsBtn.Click += new System.EventHandler(this.showAllProductsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Categories";
            // 
            // deleteCategory
            // 
            this.deleteCategory.Location = new System.Drawing.Point(833, 17);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(215, 23);
            this.deleteCategory.TabIndex = 33;
            this.deleteCategory.Text = "Delete Selected Category";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // searchCategoriesBtn
            // 
            this.searchCategoriesBtn.Location = new System.Drawing.Point(752, 18);
            this.searchCategoriesBtn.Name = "searchCategoriesBtn";
            this.searchCategoriesBtn.Size = new System.Drawing.Size(75, 23);
            this.searchCategoriesBtn.TabIndex = 32;
            this.searchCategoriesBtn.Text = "Search";
            this.searchCategoriesBtn.UseVisualStyleBackColor = true;
            this.searchCategoriesBtn.Click += new System.EventHandler(this.searchCategoriesBtn_Click);
            // 
            // searchCategoriesTxtBox
            // 
            this.searchCategoriesTxtBox.Location = new System.Drawing.Point(434, 18);
            this.searchCategoriesTxtBox.Name = "searchCategoriesTxtBox";
            this.searchCategoriesTxtBox.Size = new System.Drawing.Size(312, 23);
            this.searchCategoriesTxtBox.TabIndex = 31;
            // 
            // showAllCategoriesBtn
            // 
            this.showAllCategoriesBtn.Location = new System.Drawing.Point(353, 17);
            this.showAllCategoriesBtn.Name = "showAllCategoriesBtn";
            this.showAllCategoriesBtn.Size = new System.Drawing.Size(75, 23);
            this.showAllCategoriesBtn.TabIndex = 26;
            this.showAllCategoriesBtn.Text = "Show All";
            this.showAllCategoriesBtn.UseVisualStyleBackColor = true;
            this.showAllCategoriesBtn.Click += new System.EventHandler(this.showAllCategoriesBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryIdTxtBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.productRetailPriceTxtBox);
            this.groupBox2.Controls.Add(this.productWholesalePriceTxtBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.productDescriptionTxtBox);
            this.groupBox2.Controls.Add(this.productNameTxtBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addProductBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 299);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // productRetailPriceTxtBox
            // 
            this.productRetailPriceTxtBox.Location = new System.Drawing.Point(6, 179);
            this.productRetailPriceTxtBox.Name = "productRetailPriceTxtBox";
            this.productRetailPriceTxtBox.Size = new System.Drawing.Size(225, 23);
            this.productRetailPriceTxtBox.TabIndex = 25;
            // 
            // productWholesalePriceTxtBox
            // 
            this.productWholesalePriceTxtBox.Location = new System.Drawing.Point(6, 130);
            this.productWholesalePriceTxtBox.Name = "productWholesalePriceTxtBox";
            this.productWholesalePriceTxtBox.Size = new System.Drawing.Size(225, 23);
            this.productWholesalePriceTxtBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Retail Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Wholesale Price";
            // 
            // productDescriptionTxtBox
            // 
            this.productDescriptionTxtBox.Location = new System.Drawing.Point(6, 80);
            this.productDescriptionTxtBox.Name = "productDescriptionTxtBox";
            this.productDescriptionTxtBox.Size = new System.Drawing.Size(225, 23);
            this.productDescriptionTxtBox.TabIndex = 21;
            // 
            // productNameTxtBox
            // 
            this.productNameTxtBox.Location = new System.Drawing.Point(6, 37);
            this.productNameTxtBox.Name = "productNameTxtBox";
            this.productNameTxtBox.Size = new System.Drawing.Size(225, 23);
            this.productNameTxtBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product Name";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(6, 270);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addProductBtn.TabIndex = 13;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryDescriptionTxtBox);
            this.groupBox1.Controls.Add(this.categoryNameTxtBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addCategoryBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 172);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // categoryDescriptionTxtBox
            // 
            this.categoryDescriptionTxtBox.Location = new System.Drawing.Point(6, 89);
            this.categoryDescriptionTxtBox.Name = "categoryDescriptionTxtBox";
            this.categoryDescriptionTxtBox.Size = new System.Drawing.Size(188, 23);
            this.categoryDescriptionTxtBox.TabIndex = 19;
            // 
            // categoryNameTxtBox
            // 
            this.categoryNameTxtBox.Location = new System.Drawing.Point(6, 37);
            this.categoryNameTxtBox.Name = "categoryNameTxtBox";
            this.categoryNameTxtBox.Size = new System.Drawing.Size(188, 23);
            this.categoryNameTxtBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Category Name";
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Location = new System.Drawing.Point(6, 131);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.addCategoryBtn.TabIndex = 12;
            this.addCategoryBtn.Text = "Add";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(265, 305);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 25;
            this.productsDataGridView.Size = new System.Drawing.Size(783, 305);
            this.productsDataGridView.TabIndex = 29;
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Location = new System.Drawing.Point(265, 46);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.RowHeadersWidth = 51;
            this.categoriesDataGridView.RowTemplate.Height = 25;
            this.categoriesDataGridView.Size = new System.Drawing.Size(783, 208);
            this.categoriesDataGridView.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Category Id";
            // 
            // categoryIdTxtBox
            // 
            this.categoryIdTxtBox.Location = new System.Drawing.Point(6, 229);
            this.categoryIdTxtBox.Name = "categoryIdTxtBox";
            this.categoryIdTxtBox.Size = new System.Drawing.Size(225, 23);
            this.categoryIdTxtBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 622);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.searchProductsBtn);
            this.Controls.Add(this.searchProductTxtBox);
            this.Controls.Add(this.showAllProductsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.searchCategoriesBtn);
            this.Controls.Add(this.searchCategoriesTxtBox);
            this.Controls.Add(this.showAllCategoriesBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.categoriesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteProductBtn;
        private Button searchProductsBtn;
        private TextBox searchProductTxtBox;
        private Button showAllProductsBtn;
        private Label label2;
        private Label label1;
        private Button deleteCategory;
        private Button searchCategoriesBtn;
        private TextBox searchCategoriesTxtBox;
        private Button showAllCategoriesBtn;
        private GroupBox groupBox2;
        private TextBox productRetailPriceTxtBox;
        private TextBox productWholesalePriceTxtBox;
        private Label label8;
        private Label label7;
        private TextBox productDescriptionTxtBox;
        private TextBox productNameTxtBox;
        private Label label4;
        private Label label3;
        private Button addProductBtn;
        private GroupBox groupBox1;
        private TextBox categoryDescriptionTxtBox;
        private TextBox categoryNameTxtBox;
        private Label label6;
        private Label label5;
        private Button addCategoryBtn;
        private DataGridView productsDataGridView;
        private DataGridView categoriesDataGridView;
        private TextBox categoryIdTxtBox;
        private Label label9;
    }
}