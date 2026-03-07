using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LibraryApp
{
    internal class Program
    {
            static string connectionString =
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\n===== LIBRARY MANAGEMENT SYSTEM =====");
                    Console.WriteLine("1. View Books");
                    Console.WriteLine("2. Insert Book");
                    Console.WriteLine("3. Update Book");
                    Console.WriteLine("4. Delete Book");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: GetBooks(); break;
                        case 2: InsertBook(); break;
                        case 3: UpdateBook(); break;
                        case 4: DeleteBook(); break;
                        case 5: return;
                    }
                }
            }

            // DISCONNECTED SELECT
            static void GetBooks()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_GetAllBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                Console.WriteLine("\n--- Books List ---");

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"{row["BookId"]} | {row["Title"]} | {row["AuthorName"]} | {row["PublishedYear"]}");
                }
            }

            static void InsertBook()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_InsertBook", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Title: ");
                cmd.Parameters.AddWithValue("@Title", Console.ReadLine());

                Console.Write("Author Id: ");
                cmd.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(Console.ReadLine()));

                Console.Write("Published Year: ");
                cmd.Parameters.AddWithValue("@PublishedYear", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Book Inserted Successfully!");
            }

            static void UpdateBook()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_UpdateBook", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Book Id: ");
                cmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(Console.ReadLine()));

                Console.Write("New Title: ");
                cmd.Parameters.AddWithValue("@Title", Console.ReadLine());

                Console.Write("New Author Id: ");
                cmd.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(Console.ReadLine()));

                Console.Write("New Published Year: ");
                cmd.Parameters.AddWithValue("@PublishedYear", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Book Updated Successfully!");
            }

            static void DeleteBook()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_DeleteBook", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Book Id to Delete: ");
                cmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Book Deleted Successfully!");
            }
        }
    }