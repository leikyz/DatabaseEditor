using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Stump.DofusProtocol.Classes;
using Stump.DofusProtocol.D2oClasses.Tools.D2o;
using Stump.DofusProtocol.D2oClasses.Tools.Dlm;

namespace DatabaseEditor
{
    /// <summary>
    /// Logique d'interaction pour D2OEditor.xaml
    /// </summary>
    /// 
    
    public partial class D2OEditor : Window
    {
        private readonly D2OReader d2oReader;

        public D2OEditor(Stream stream)
        {
            InitializeComponent();

            try
            {
                d2oReader = new D2OReader(stream);

                Dictionary<int, AchievementCategory> categoryObjects = d2oReader.ReadObjects<AchievementCategory>();

                // Display values of fields for each AchievementCategory object
                foreach (var categoryObject in categoryObjects.Values)
                {
                    // Construct a string representation of the AchievementCategory object with its field values
                    string categoryInfo = $"ID: {categoryObject.Id}, Name: {categoryObject.NameId}, Achievement IDs: [{string.Join(",", categoryObject.AchievementIds)}], etc.";

                    // Show the category information in a message box
                    MessageBox.Show(categoryInfo);
                }
                }

            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing D2OReader: {ex.Message}");
                // Handle the exception as needed
            }
        }
        //public static Type ResolveType(string fileName)
        //{
        //    // Convertir le nom de fichier en minuscules pour faciliter la comparaison
        //    string lowerFileName = fileName.ToLowerInvariant();

        //    // Analyser le nom du fichier pour déterminer le type de classe correspondant
        //    if (lowerFileName.Contains("achievement_categories"))
        //    {
        //        return typeof(AchievementCategory);
        //    }
        //    else if (lowerFileName.Contains("achievements"))
        //    {
        //        return typeof(Achievement);
        //    }
        //    // Ajoutez d'autres conditions pour d'autres types de fichiers si nécessaire

        //    // Si aucun type correspondant n'est trouvé, renvoyer null
        //    return null;
        //}

        //public void DisplayD2OObjects<T>() where T : class
        //{
        //    try
        //    {
        //        // Vérifie si le type de classe T existe dans le fichier D2O
        //        var classType = typeof(T).Name;
        //        if (d2oReader.Classes.Values.Any(c => c.Name == classType))
        //        {
        //            // Lisez les objets du type T à partir du fichier D2O
        //            Dictionary<int, T> categoryObjects = d2oReader.ReadObjects<T>();
        //         //   categoryObjects.Values.Count();
        //            MessageBox.Show(categoryObjects.Values.Count().ToString());
        //            // Affichez les valeurs des champs pour chaque objet de type T
        //            //foreach (var categoryObject in categoryObjects.Values)
        //            //{
        //            //    // Construisez une représentation de chaîne de l'objet T avec ses valeurs de champ
        //            //    string categoryInfo = $"ID: {categoryObject.Id}, Name: {categoryObject.NameId}, Achievement IDs: [{string.Join(",", categoryObject.AchievementIds)}], etc.";

        //            //    // Affichez les informations de catégorie dans une boîte de message
        //            //    MessageBox.Show(categoryInfo);
        //            //}
        //        }
        //        else
        //        {
        //            MessageBox.Show($"La classe de type {typeof(T).Name} n'est pas présente dans le fichier D2O.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erreur lors de l'initialisation de D2OReader : {ex.Message}");
        //        // Gérez l'exception selon vos besoins
        //    }
        //}


        private void PopulateCategories()
        {
            // Assuming you have a method in D2OReader to get categories
            List<string> categories = GetCategories();
            foreach (string category in categories)
            {
                categoryListBox.Items.Add(category);
            }
        }

        private List<string> GetCategories()
        {
            // Assuming you have a method in D2OReader to retrieve categories
            // This is just a placeholder, replace it with the actual implementation
            List<string> categories = new List<string>();
            // Example: categories = d2oReader.GetCategories();
            return categories;
        }
    }
}

