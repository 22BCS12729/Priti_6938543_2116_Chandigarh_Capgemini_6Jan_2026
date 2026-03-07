using Microsoft.Data.SqlClient;
using System.Data;

namespace UniversityApp
{
    
        internal class Program
        {
            static string connectionString =
                "Data Source=DESKTOP-L1MO71T\\SQLEXPRESS;Initial Catalog=UniversityDB;Integrated Security=True;TrustServerCertificate=True;";

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\n===== UNIVERSITY MANAGEMENT SYSTEM =====");
                    Console.WriteLine("1. Insert Student");
                    Console.WriteLine("2. View All Students");
                    Console.WriteLine("3. Update Student");
                    Console.WriteLine("4. Delete Student");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: InsertStudent(); break;
                        case 2: GetAllStudents(); break;
                        case 3: UpdateStudent(); break;
                        case 4: DeleteStudent(); break;
                        case 5: return;
                        default: Console.WriteLine("Invalid Choice"); break;
                    }
                }
            }

            // INSERT
            static void InsertStudent()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_InsertStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("First Name: ");
                cmd.Parameters.AddWithValue("@FirstName", Console.ReadLine());

                Console.Write("Last Name: ");
                cmd.Parameters.AddWithValue("@LatName", Console.ReadLine());   // IMPORTANT

                Console.Write("Email: ");
                cmd.Parameters.AddWithValue("@Email", Console.ReadLine());

                Console.Write("Department Id: ");
                cmd.Parameters.AddWithValue("@DeptId", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Student Inserted Successfully!");
            }

            // SELECT
            static void GetAllStudents()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_GetAllStudents", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\n--- Students List ---");

                while (reader.Read())
                {
                    Console.WriteLine(
                        reader["StudId"] + " | " +
                        reader["FirstName"] + " " +
                        reader["LatName"] + " | " +
                        reader["Email"] + " | " +
                        reader["DeptName"]);
                }
            }

            // UPDATE
            static void UpdateStudent()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_UpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Student Id: ");
                cmd.Parameters.AddWithValue("@StudId", Convert.ToInt32(Console.ReadLine()));  // IMPORTANT

                Console.Write("New First Name: ");
                cmd.Parameters.AddWithValue("@FirstName", Console.ReadLine());

                Console.Write("New Last Name: ");
                cmd.Parameters.AddWithValue("@LatName", Console.ReadLine());

                Console.Write("New Email: ");
                cmd.Parameters.AddWithValue("@Email", Console.ReadLine());

                Console.Write("New Department Id: ");
                cmd.Parameters.AddWithValue("@DeptId", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Student Updated Successfully!");
            }

            // DELETE
            static void DeleteStudent()
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_DeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Student Id to Delete: ");
                cmd.Parameters.AddWithValue("@StudId", Convert.ToInt32(Console.ReadLine())); // IMPORTANT

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Student Deleted Successfully!");
            }
        }
    }