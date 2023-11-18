using DewDecimalTrainingApp.Data;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Windows;

namespace DewDecimalTrainingApp
{
    public class FileHelper
    {
        static string? filePath;
        DeweyTreeStructure deweyTree;
        public FileHelper()
        {
            filePath = ConfigurationManager.AppSettings["filePath"];
            deweyTree = new DeweyTreeStructure();
        }

        public DeweyTreeStructure ReadJsonFile()
        {           
            
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);

                    deweyTree = JsonConvert.DeserializeObject<DeweyTreeStructure>(json);
                }

            }
            //Catch file related exceptions
            catch (IOException ex)
            {
                MessageBox.Show($"Error loading Dewey Decimal data: {ex.Message}","IO Exception",MessageBoxButton.OK);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Unable to ready file, unauthorized access: {ex.Message}","Unauthorized Access",MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Dewey Decimal data: {ex.Message}","Unable to read file",MessageBoxButton.OK);
            }

            return deweyTree;
        }
    }

}
