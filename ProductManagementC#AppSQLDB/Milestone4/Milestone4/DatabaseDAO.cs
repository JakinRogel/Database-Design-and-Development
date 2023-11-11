using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Milestone4
{
    internal class DatabaseDAO
    {
        private string connectionString = "datasource=localhost;port=3307;username=root;password=root;database=milestone345_2.1;";


        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CategoryId, CategoryName FROM productcategories";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category category = new Category
                        {
                            CategoryId = reader.GetInt32(0),
                            CategoryName = reader.GetString(1)
                        };
                        categories.Add(category);
                    }
                }
            }

            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CategoryId, CategoryName FROM productcategories WHERE CategoryId = @CategoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Category category = new Category
                            {
                                CategoryId = reader.GetInt32(0),
                                CategoryName = reader.GetString(1)
                            };
                            return category;
                        }
                    }
                }

                return null; // Category not found
            }
        }

        public int AddCategory(Category category)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO productcategories (CategoryName) VALUES (@CategoryName)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", category.CategoryName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Retrieve the last inserted category's ID
                        command.CommandText = "SELECT LAST_INSERT_ID()";
                        int categoryId = Convert.ToInt32(command.ExecuteScalar());
                        return categoryId;
                    }
                    else
                    {
                        return -1; // Category insertion failed
                    }
                }
            }
        }


        public bool UpdateCategory(Category category)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE productcategories SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    command.Parameters.AddWithValue("@CategoryId", category.CategoryId);

                    // Execute the query and check if any rows were affected
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Delete products associated with the category first
                DeleteProductsByCategoryId(categoryId);

                // Now delete the category
                string query = "DELETE FROM productcategories WHERE CategoryId = @CategoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    // Execute the query and check if any rows were affected
                    return command.ExecuteNonQuery() > 0;
                }
            }
            MessageBox.Show("Category deleted successfully");
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProductId, ProductName, ProductDescription, RetailPrice, WholesalePrice, CategoryId FROM Products";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            ProductId = reader.GetInt32(0),
                            ProductName = reader.GetString(1),
                            ProductDescription = reader.GetString(2),
                            RetailPrice = reader.GetDecimal(3),
                            WholesalePrice = reader.GetDecimal(4),
                            CategoryId = reader.GetInt32(5)
                        };
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        public Product GetProductById(int productId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProductId, ProductName, ProductDescription, RetailPrice, WholesalePrice, CategoryId FROM Products WHERE ProductId = @ProductId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                ProductDescription = reader.GetString(2),
                                RetailPrice = reader.GetDecimal(3),
                                WholesalePrice = reader.GetDecimal(4),
                                CategoryId = reader.GetInt32(5)
                            };
                            return product;
                        }
                    }
                }

                return null; // Product not found
            }
        }

        public int AddProduct(Product product)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Now, insert the product with the valid categoryId
                string query = "INSERT INTO Products (ProductName, ProductDescription, RetailPrice, WholesalePrice, CategoryId) " +
                               "VALUES (@ProductName, @ProductDescription, @RetailPrice, @WholesalePrice, @CategoryId)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                    command.Parameters.AddWithValue("@RetailPrice", product.RetailPrice);
                    command.Parameters.AddWithValue("@WholesalePrice", product.WholesalePrice);
                    command.Parameters.AddWithValue("@CategoryId", product.CategoryId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Retrieve the last inserted product's ID
                        command.CommandText = "SELECT LAST_INSERT_ID()";
                        int productId = Convert.ToInt32(command.ExecuteScalar());
                        return productId;
                    }
                    else
                    {
                        return -1; // Product insertion failed
                    }
                }
            }
        }

        public bool UpdateProduct(Product product)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Products SET ProductName = @ProductName, ProductDescription = @ProductDescription, " +
                               "RetailPrice = @RetailPrice, WholesalePrice = @WholesalePrice, CategoryId = @CategoryId " +
                               "WHERE ProductId = @ProductId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", product.ProductId);
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                    command.Parameters.AddWithValue("@RetailPrice", product.RetailPrice);
                    command.Parameters.AddWithValue("@WholesalePrice", product.WholesalePrice);
                    command.Parameters.AddWithValue("@CategoryId", product.CategoryId);

                    // Execute the query and check if any rows were affected
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteProduct(int productId, int categoryId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Products WHERE ProductId = @ProductId AND CategoryId = @CategoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    // Execute the query and check if any rows were affected
                    return command.ExecuteNonQuery() > 0;
                }
            }


        }

        public List<Category> SearchCategories(string searchTerm)
        {
            List<Category> categories = new List<Category>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CategoryId, CategoryName FROM productcategories WHERE CategoryName LIKE @SearchTerm";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category
                            {
                                CategoryId = reader.GetInt32(0),
                                CategoryName = reader.GetString(1)
                            };
                            categories.Add(category);
                        }
                    }
                }
            }

            return categories;
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProductId, ProductName, ProductDescription, RetailPrice, WholesalePrice, CategoryId FROM Products " +
                               "WHERE ProductName LIKE @SearchTerm OR ProductDescription LIKE @SearchTerm";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                ProductDescription = reader.GetString(2),
                                RetailPrice = reader.GetDecimal(3),
                                WholesalePrice = reader.GetDecimal(4),
                                CategoryId = reader.GetInt32(5)
                            };
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        private void DeleteProductsByCategoryId(int categoryId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Products WHERE CategoryId = @CategoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    // Execute the query to delete products associated with the category
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProductId, ProductName, ProductDescription, RetailPrice, WholesalePrice, CategoryId FROM Products " +
                               "WHERE CategoryId = @CategoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                ProductDescription = reader.GetString(2),
                                RetailPrice = reader.GetDecimal(3),
                                WholesalePrice = reader.GetDecimal(4),
                                CategoryId = reader.GetInt32(5)
                            };
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }


    }

}

