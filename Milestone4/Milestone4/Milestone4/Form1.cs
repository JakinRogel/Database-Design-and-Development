namespace Milestone4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseDAO databaseDAO = new DatabaseDAO();

        // Show all categories
        private void showAllCategoriesBtn_Click(object sender, EventArgs e)
        {
            List<Category> categories = databaseDAO.GetAllCategories();
            categoriesDataGridView.DataSource = categories;
        }

        // Search categories
        private void searchCategoriesBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchCategoriesTxtBox.Text;
            List<Category> searchResults = databaseDAO.SearchCategories(searchTerm);
            categoriesDataGridView.DataSource = searchResults;
        }

        // Delete a category
        private void deleteCategory_Click(object sender, EventArgs e)
        {
            
            int rowClicked = categoriesDataGridView.CurrentRow.Index;
            int categoryId = int.Parse(categoriesDataGridView.Rows[rowClicked].Cells[0].Value.ToString());

            databaseDAO.DeleteCategory(categoryId);
            
            showAllCategoriesBtn_Click(sender, new EventArgs());

            
        }


        // Add a new category
        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            string categoryName = categoryNameTxtBox.Text;
            if (!string.IsNullOrEmpty(categoryName))
            {
                Category newCategory = new Category { CategoryName = categoryName };
                int categoryId = databaseDAO.AddCategory(newCategory);

                if (categoryId > 0)
                {
                    // Category added successfully, refresh the grid
                    showAllCategoriesBtn_Click(sender, e);
                    categoryNameTxtBox.Text = string.Empty; // Clear the input field
                    categoryDescriptionTxtBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Failed to add the category.");
                }
            }
        }


        // Show all products
        private void showAllProductsBtn_Click(object sender, EventArgs e)
        {
            List<Product> products = databaseDAO.GetAllProducts();
            productsDataGridView.DataSource = products;
        }

        // Search products
        private void searchProductsBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchProductTxtBox.Text;
            List<Product> searchResults = databaseDAO.SearchProducts(searchTerm);
            productsDataGridView.DataSource = searchResults;
        }

        // Delete a product
        private void deleteProductBtn_Click(object sender, EventArgs e)
        {

            int rowClicked = productsDataGridView.CurrentRow.Index;
            int productId = int.Parse(productsDataGridView.Rows[rowClicked].Cells[0].Value.ToString());
            int categoryId = int.Parse(productsDataGridView.Rows[rowClicked].Cells[5].Value.ToString());

            databaseDAO.DeleteProduct(productId, categoryId);
            MessageBox.Show("Product deleted successfully");
            showAllProductsBtn_Click(sender, e);
            
        }

        // Add a new product
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            string productName = productNameTxtBox.Text;
            if (!string.IsNullOrEmpty(productName))
            {
                // Construct a Product object with the required information
                Product newProduct = new Product
                {
                    ProductName = productName,
                    ProductDescription = productDescriptionTxtBox.Text,
                    RetailPrice = decimal.Parse(productRetailPriceTxtBox.Text),
                    WholesalePrice = decimal.Parse(productWholesalePriceTxtBox.Text),
                    CategoryId = int.Parse(categoryIdTxtBox.Text)
                };

                int productId = databaseDAO.AddProduct(newProduct);

                if (productId > 0)
                {
                    // Product added successfully, refresh the grid
                    showAllProductsBtn_Click(sender, e);
                    ClearProductInputs(); // Clear the input fields
                }
                else
                {
                    MessageBox.Show("Failed to add the product.");
                }
            }
        }


        // Helper method to clear product input fields
        private void ClearProductInputs()
        {
            productNameTxtBox.Text = string.Empty;
            productDescriptionTxtBox.Text = string.Empty;
            productRetailPriceTxtBox.Text = string.Empty;
            productWholesalePriceTxtBox.Text = string.Empty;
            categoryIdTxtBox.Text= string.Empty;
        }


    }
}