using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Retete
{
    public partial class FormRecipe : Form
    {
        private Recipe recipe;

        public FormRecipe(Recipe recipe)
        {
            InitializeComponent();

            this.recipe = recipe;
            updateAll();
        }

        private void updateAll()
        {
            // Change labels
            this.Text = recipe.Name;
            recipeNameLabel.Text = recipe.Name;
            hasVideoLabel.Visible = recipe.HasVideo;

            // Change the link
            linkLabel.Links.Remove(linkLabel.Links[0]);
            linkLabel.Links.Add(0, recipe.Link.Length, recipe.Link);

            // Change the image
            try
            {
                pictureBox.Load(recipe.ImageLink);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Nu am gasit poza la adresa " + recipe.ImageLink);

                // If we couldn't find the image, set it to a default one
                pictureBox.Image = Retete.Properties.Resources.imageNotFound;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }

        private void FormRecipe_Load(object sender, EventArgs e)
        {

        }
    }
}
