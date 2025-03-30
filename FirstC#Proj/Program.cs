using FirstC_Proj.GenericCollectionHW;
using FirstC_Proj.GenericCollections;
using FirstC_Proj.Lambda_Expressions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using FirstC_Proj.LINQ;
using FirstC_Proj.File_System;
using System.Text.RegularExpressions;
using System.Net;

namespace FirstC_Proj
{

    class Program
    {

        static void Main()
        {
            #region Task1
            //PoemList collection = new PoemList();
            //string choice2;
            //while (true)
            //{
            //    Console.WriteLine("1. Add Poem\n" +
            //                      "2. Remove Poem\n" +
            //                      "3. Update Poem\n" +
            //                      "4. Search Poems\n" +
            //                      "5. Save to File\n" +
            //                      "6. Load from File\n" +
            //                      "7. Exit");
            //    string choice = Console.ReadLine();

            //    if (choice == "1")
            //    {
            //        Poem poem = new Poem();
            //        Console.Write("Title: ");
            //        poem.poemName = Console.ReadLine();
            //        Console.Write("Author: ");
            //        poem.authorName = Console.ReadLine();
            //        Console.Write("Year: ");
            //        poem.yearOfWriting = int.Parse(Console.ReadLine());
            //        Console.Write("Text: ");
            //        poem.poemText = Console.ReadLine();
            //        Console.Write("Theme: ");
            //        poem.poemTheme = Console.ReadLine();
            //        collection.AddPoem(poem);
            //    }
            //    else if (choice == "2")
            //    {
            //        Console.Write("Enter Title: ");
            //        collection.RemovePoem(Console.ReadLine());
            //    }
            //    else if (choice == "3")
            //    {
            //        Console.Write("Enter Title to Update: ");
            //        string title = Console.ReadLine();
            //        Poem poem = new Poem();
            //        Console.Write("New Title: ");
            //        poem.poemName = Console.ReadLine();
            //        Console.Write("New Author: ");
            //        poem.authorName = Console.ReadLine();
            //        Console.Write("New Year: ");
            //        poem.yearOfWriting = int.Parse(Console.ReadLine());
            //        Console.Write("New Text: ");
            //        poem.poemText = Console.ReadLine();
            //        Console.Write("New Theme: ");
            //        poem.poemTheme = Console.ReadLine();
            //        collection.UpdatePoem(title, poem);
            //    }
            //    else if (choice == "4")
            //    {
            //        Console.Write("Enter Search: ");
            //        collection.SearchPoems(Console.ReadLine());
            //    }
            //    else if (choice == "5")
            //    {
            //        collection.SaveToFile("poems.txt");
            //    }
            //    else if (choice == "6")
            //    {
            //        collection.LoadFromFile("poems.txt");
            //    }
            //    else if (choice == "7")
            //    {
            //        Console.WriteLine("Save to file!!!");
            //        Console.WriteLine("1. Exit\n" +
            //                      "2. Save to file and exit\n");
            //        choice2 = Console.ReadLine();
            //        if (choice2 == "1")
            //        {
            //            break;
            //        }
            //        else if (choice2 == "2")
            //        {
            //            collection.SaveToFile("poems.txt");
            //            break;
            //        }
            //    }
            //}
            #endregion
            #region Task2
            //Console.Write("Enter directory path: ");
            //string directory = Console.ReadLine();

            //Console.Write("Enter file mask (e.g., *.txt): ");
            //string mask = Console.ReadLine();

            //if (Directory.Exists(directory))
            //{
            //    Console.WriteLine("Searching for files...");
            //    List<string> files = new List<string>();
            //    SearchFiles(directory, mask, files);

            //    if (files.Count > 0)
            //    {
            //        Console.WriteLine("Found files:");
            //        foreach (string file in files)
            //        {
            //            Console.WriteLine(file);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No files found.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Directory does not exist.");
            //}
            #endregion
            #region Task3
            //Console.Write("Enter directory path: ");
            //string directory = Console.ReadLine();

            //Console.Write("Enter file mask (e.g., *.txt): ");
            //string mask = Console.ReadLine();

            //if (Directory.Exists(directory))
            //{
            //    Console.WriteLine("Deleting files...");

            //    DeleteFilesAndDirectories(directory, mask);

            //    Console.WriteLine("Deletion process completed.");
            //}
            //else
            //{
            //    Console.WriteLine("Directory does not exist.");
            //}
            #endregion
            #region Task4
            //Console.Write("Enter restaurant name: ");
            //string restaurantName = Console.ReadLine();

            //if (IsValidRestaurantName(restaurantName))
            //{
            //    Console.WriteLine("Valid restaurant name.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid restaurant name.");
            //}
            #endregion
            #region Task5
            //Console.Write("Enter restaurant address: ");
            //string address = Console.ReadLine();

            //if (IsValidRestaurantAddress(address))
            //{
            //    Console.WriteLine("Valid restaurant address.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid restaurant address.");
            //}
            #endregion
            #region Task6
            //Console.Write("Enter kitchen name: ");
            //string kitchenName = Console.ReadLine();

            //if (IsValidKitchenName(kitchenName))
            //{
            //    Console.WriteLine("Valid kitchen name.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid kitchen name.");
            //}
            #endregion
            #region Task7
            //Console.Write("Enter mark for restaurant: ");
            //string restaurantMark = Console.ReadLine();

            //if (IsValidRestaurantMark(restaurantMark))
            //{
            //    Console.WriteLine("Valid mark.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid mark.");
            //}
            #endregion
            #region Task8
            string nick, email, phoneNumber, restaurantName, restaurantAddress, kitchenName, restaurantContact, restaurantMark, userResponse;

            do
            {
                Console.Write("Enter Nick: ");
                nick = Console.ReadLine();
            } while (!Validator.ValidateNick(nick));

            do
            {
                Console.Write("Enter Email: ");
                email = Console.ReadLine();
            } while (!Validator.ValidateEmail(email));

            do
            {
                Console.Write("Enter Phone Number: ");
                phoneNumber = Console.ReadLine();
            } while (!Validator.ValidatePhoneNumber(phoneNumber));

            do
            {
                Console.Write("Enter Restaurant Name: ");
                restaurantName = Console.ReadLine();
            } while (!Validator.ValidateRestaurantName(restaurantName));

            do
            {
                Console.Write("Enter Restaurant Address: ");
                restaurantAddress = Console.ReadLine();
            } while (!Validator.ValidateRestaurantAddress(restaurantAddress));

            do
            {
                Console.Write("Enter Kitchen Type: ");
                kitchenName = Console.ReadLine();
            } while (!Validator.ValidateKitchenName(kitchenName));

            do
            {
                Console.Write("Enter Restaurant Contact Number: ");
                restaurantContact = Console.ReadLine();
            } while (!Validator.ValidatePhoneNumber(restaurantContact));

            do
            {
                Console.Write("Enter Restaurant Mark (1-9): ");
                restaurantMark = Console.ReadLine();
            } while (!Validator.ValidateRestaurantMark(restaurantMark));

            do
            {
                Console.Write("Enter User Review: ");
                userResponse = Console.ReadLine();
            } while (!Validator.ValidateUserResponse(userResponse));

            string filePath = "restaurant_reviews.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Nick: {nick}");
                writer.WriteLine($"Email: {email}");
                writer.WriteLine($"Phone: {phoneNumber}");
                writer.WriteLine($"Restaurant: {restaurantName}");
                writer.WriteLine($"Address: {restaurantAddress}");
                writer.WriteLine($"Kitchen: {kitchenName}");
                writer.WriteLine($"Contact: {restaurantContact}");
                writer.WriteLine($"Mark: {restaurantMark}");
                writer.WriteLine($"Review: {userResponse}");
                writer.WriteLine(new string('-', 40));
            }

            Console.WriteLine("Data successfully saved to file.");
            #endregion
        }
        static bool IsValidEnter(string pattern, string str)
        {
            return Regex.IsMatch(str, pattern);
        }
        static bool IsValidRestaurantMark(string mark)
        {
            string pattern = "^(1[0-2]|[1-9])$";
            return Regex.IsMatch(mark, pattern);
        }
        static bool IsValidKitchenName(string name)
        {
            string pattern = "^[a-zA-Z]+$";
            return Regex.IsMatch(name, pattern);
        }
        static bool IsValidRestaurantAddress(string address)
        {
            string pattern = "^[a-zA-Z0-9]+$";
            return Regex.IsMatch(address, pattern);
        }
        static bool IsValidRestaurantName(string name)
        {
            string pattern = "^[^%&)(]+$";
            return Regex.IsMatch(name, pattern);
        }
        static void DeleteFilesAndDirectories(string directory, string mask)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directory, mask))
                {
                    try
                    {
                        File.Delete(file);
                        Console.WriteLine($"Deleted file: {file}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not delete file {file}: {ex.Message}");
                    }
                }

                foreach (string subDir in Directory.GetDirectories(directory))
                {
                    DeleteFilesAndDirectories(subDir, mask);
                    try
                    {
                        Directory.Delete(subDir, true);
                        Console.WriteLine($"Deleted directory: {subDir}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not delete directory {subDir}: {ex.Message}");
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access denied: {directory}");
            }
        }
        static void SearchFiles(string directory, string mask, List<string> files)
        {
            try
            {
                files.AddRange(Directory.GetFiles(directory, mask));
                foreach (string subDir in Directory.GetDirectories(directory))
                {
                    SearchFiles(subDir, mask, files);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access denied: {directory}");
            }
        }
    }
}