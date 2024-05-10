using System;
using System.IO;
using System.Runtime.CompilerServices;
namespace FileFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\AnandAruldoss\OneDrive - Syncfusion\Desktop\Assignment\Advanced OOPS\MyFolder";
        // string folderPath = path + "/Anand";
        // if (!Directory.Exists(folderPath))
        // {
        //     System.Console.WriteLine("Creating folder...");
        //     Directory.CreateDirectory(folderPath);
        // }
        // else
        // {
        //     System.Console.WriteLine("Folder already Exists!");
        // }

        // string filePath = path + "/myFile.txt";
        // if (!File.Exists(filePath))
        // {
        //     System.Console.WriteLine("Creating file...");
        //     File.Create(filePath);
        // }
        // else
        // {
        //     System.Console.WriteLine("File already Exists!");
        // }
        bool flag = true;
        do
        {
            System.Console.WriteLine("1. Create Folder 2. Create File 3. Delete Folder 4. Delete File 5.Exit");
            System.Console.Write("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        System.Console.Write("Enter your FolderName:");
                        string folderName = Console.ReadLine();
                        string newPath = path + "/" + folderName;
                        if (!Directory.Exists(newPath))
                        {
                            System.Console.WriteLine($"Creating Folder {folderName}...");
                            Directory.CreateDirectory(newPath);
                        }
                        else
                        {
                            System.Console.WriteLine("Folder already Exists!");
                        }
                        break;
                    }

                case 2:
                    {
                        System.Console.Write("Enter a File Name to create:");
                        string fileName = Console.ReadLine();
                        System.Console.Write("Enter File Extension:");
                        string extension = Console.ReadLine();
                        string newFilePath = path + "/" + fileName + "." + extension;
                        if (!File.Exists(newFilePath))
                        {
                            System.Console.WriteLine($"Creating a file {fileName}.{extension}");
                            File.Create(newFilePath);
                        }
                        else
                        {
                            System.Console.WriteLine("File already Exists!");
                        }
                        break;
                    }

                case 3:
                    {
                        bool flag1 = true;
                        foreach (string paths in Directory.GetDirectories(path))
                        {
                            System.Console.WriteLine(paths);
                        }
                        System.Console.Write("Enter Folder name to delete:");
                        string folderName = Console.ReadLine();
                        foreach (string paths in Directory.GetDirectories(path))
                        {
                            if (paths.Contains(folderName))
                            {
                                flag1 = false;
                                System.Console.WriteLine($"Removing Folder {folderName}...");
                                Directory.Delete(paths);
                            }
                        }
                        if (flag1)
                        {
                            System.Console.WriteLine("Folder doesnt exists!");
                        }
                        break;
                    }

                case 4:
                    {
                        bool flag2 = true;
                        foreach (string files in Directory.GetFiles(path))
                        {
                            System.Console.WriteLine(files);
                        }
                        System.Console.Write("Enter File Name & its extension to delete:");
                        string file1 = Console.ReadLine();
                        foreach (string files in Directory.GetFiles(path))
                        {
                            if (files.Contains(file1)) //checking file exits in list of files in the path
                            {
                                flag2 = false;
                                System.Console.WriteLine($"Deleting File {file1}");
                                File.Delete(files); //removing the file using ForEach
                            }
                        }
                        if (flag2)
                        {
                            System.Console.WriteLine("File doesnt exists!");
                        }
                        break;

                    }

                case 5:
                    {
                        System.Console.WriteLine("Exiting...");
                        flag = false;
                        break;
                    }

                default:
                    {
                        System.Console.WriteLine("Invalid Choice!");
                        break;
                    }
            }
        } while (flag);








    }
}
