using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retete
{
    public partial class Form1 : Form
    {
        List<string> categoriesList;
        Dictionary<string, string> linksDictionary;

        public Form1()
        {
            InitializeComponent();

            initializeCategoriesList();
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            // Open a recipe form, depending on the 'categories' option
            string option = (string)categoriesListBox.SelectedItem;

            if (linksDictionary.ContainsKey(option))
            {
                string url = linksDictionary[option];

                // In case we are doing a filtered search, we might not get any recipes back.
                // We solve this case by catching an exception.
                try
                {
                    Recipe recipe;
                    if (string.IsNullOrWhiteSpace(filterTextBox.Text))
                        recipe = RecipeChooser.RandomRecipe(url);
                    else recipe = RecipeChooser.RandomFilteredRecipe(url, filterTextBox.Text);

                    var recipeForm = new FormRecipe(recipe);
                    recipeForm.Show();
                }
                catch(RecipeNotFoundException rnfe)
                {
                    MessageBox.Show(rnfe.Message);
                }
            }
        }

        private void initializeCategoriesList()
        {
            categoriesList = new List<string>();
            linksDictionary = new Dictionary<string, string>();

            categoriesList.Add("Supe si ciorbe*");
            linksDictionary.Add(categoriesList[0], "http://www.lalena.ro/retete-ciorbe.html");

            categoriesList.Add("Mancaruri*");
            linksDictionary.Add(categoriesList[1], "http://www.lalena.ro/retete-mancaruri.html");

            categoriesList.Add("Paine si altele");
            linksDictionary.Add(categoriesList[2], "http://www.lalena.ro/retete-paine-si-altele.html");

            categoriesList.Add("Placinte si pizza");
            linksDictionary.Add(categoriesList[3], "http://www.lalena.ro/retete-placinte-pizza.html");

            categoriesList.Add("Paste si altele");
            linksDictionary.Add(categoriesList[4], "http://www.lalena.ro/retete-paste-lasagna.html");

            categoriesList.Add("Preparate din carne");
            linksDictionary.Add(categoriesList[5], "http://www.lalena.ro/retete-preparate-din-carne.html");

            categoriesList.Add("Mancaruri cu legume");
            linksDictionary.Add(categoriesList[6], "http://www.lalena.ro/retete-mancaruri-legume.html");

            categoriesList.Add("Mancaruri din peste");
            linksDictionary.Add(categoriesList[7], "http://www.lalena.ro/retete-peste.html");

            categoriesList.Add("Mancaruri cu carne");
            linksDictionary.Add(categoriesList[8], "http://www.lalena.ro/retete-mancaruri-cu-carne.html");

            categoriesList.Add("Salate*");
            linksDictionary.Add(categoriesList[9], "http://www.lalena.ro/retete-salate.html");

            categoriesList.Add("Aperitive*");
            linksDictionary.Add(categoriesList[10], "http://www.lalena.ro/retete-aperitive.html");

            categoriesList.Add("Dulciuri*");
            linksDictionary.Add(categoriesList[11], "http://www.lalena.ro/retete-dulciuri.html");

            categoriesList.Add("Chec-uri");
            linksDictionary.Add(categoriesList[12], "http://www.lalena.ro/retete-checuri.html");

            categoriesList.Add("Prajituri");
            linksDictionary.Add(categoriesList[13], "http://www.lalena.ro/retete-prajituri.html");

            categoriesList.Add("Placinte");
            linksDictionary.Add(categoriesList[14], "http://www.lalena.ro/retete-placinte.html");

            categoriesList.Add("Deserturi cu fructe");
            linksDictionary.Add(categoriesList[15], "http://www.lalena.ro/retete-deserturi-cu-fructe.html");

            categoriesList.Add("Cozonaci, cornuri, strudele, etc.");
            linksDictionary.Add(categoriesList[16], "http://www.lalena.ro/retete-cozonac.html");

            categoriesList.Add("Budinci si alte mancaruri dulci");
            linksDictionary.Add(categoriesList[17], "http://www.lalena.ro/retete-budinca.html");

            categoriesList.Add("Biscuiti, fursecuri");
            linksDictionary.Add(categoriesList[18], "http://www.lalena.ro/retete-biscuiti.html");

            categoriesList.Add("Torturi");
            linksDictionary.Add(categoriesList[19], "http://www.lalena.ro/retete-torturi.html");

            categoriesList.Add("Altele");
            linksDictionary.Add(categoriesList[20], "http://www.lalena.ro/retete-alte%20retete.html");

            categoriesList.Add("Garnituri*");
            linksDictionary.Add(categoriesList[21], "http://www.lalena.ro/retete-garnituri.html");

            categoriesList.Add("Semipreparate*");
            linksDictionary.Add(categoriesList[22], "http://www.lalena.ro/retete-semipreparate.html");

            categoriesList.Add("Aluaturi");
            linksDictionary.Add(categoriesList[23], "http://www.lalena.ro/retete-aluat.html");

            categoriesList.Add("Sosuri diverse");
            linksDictionary.Add(categoriesList[24], "http://www.lalena.ro/retete-sosuri.html");

            categoriesList.Add("Utile");
            linksDictionary.Add(categoriesList[25], "http://www.lalena.ro/retete-utile-in-bucatarie.html");

            categoriesList.Add("Conserve*");
            linksDictionary.Add(categoriesList[26], "http://www.lalena.ro/retete-conserve.html");

            categoriesList.Add("Retete pentru copii");
            linksDictionary.Add(categoriesList[27], "http://www.lalena.ro/selectia-retete-copii.html");

            categoriesList.Add("Retete de post");
            linksDictionary.Add(categoriesList[28], "http://www.lalena.ro/selectia-retete-de-post.html");

            categoriesList.Add("Retete dietetice");
            linksDictionary.Add(categoriesList[29], "http://www.lalena.ro/selectia-retete-dietetice.html");

            categoriesList.Add("Retete de Craciun");
            linksDictionary.Add(categoriesList[30], "http://www.lalena.ro/selectia-retete-de-craciun.html");

            categoriesList.Add("Retete vegetariene");
            linksDictionary.Add(categoriesList[31], "http://www.lalena.ro/selectia-retete-vegetariene.html");

            categoriesList.Add("Retete vegane fara foc");
            linksDictionary.Add(categoriesList[32], "http://www.lalena.ro/selectia-retete-vegane-fara-foc.html");

            categoriesList.Add("Retete Tupperware");
            linksDictionary.Add(categoriesList[33], "http://www.lalena.ro/selectia-retete-tupperware.html");

            categoriesList.Add("Retete video");
            linksDictionary.Add(categoriesList[34], "http://www.lalena.ro/selectia-retete-culinare-video.html");

            categoriesListBox.DataSource = categoriesList;
        }

        private void filterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Display help message for the filter
            string message = "In aceasta casuta poti introduce mai multe cuvinte-cheie pentru a filtra rezultatele cautarii aleatoare. ";
            message += "Retetele returnate vor trebui sa contina toate cuvintele cheie introduse. ";
            message += "Daca sunt introduse mai multe cuvinte, acestea trebuie separate prin virgula. ";
            message += "De exemplu, daca vrem sa cautam paste cu sos de rosii, vom selecta mai intai categoria \"Paste si altele\", apoi vom scrie in filtru \"sos, rosii\".";
            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
