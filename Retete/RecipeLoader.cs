using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retete
{
    class RecipeLoader
    {
        public static Recipe[] AllRecipes(string url)
        {
            List<Recipe> recipeList = new List<Recipe>();
            string html = HTMLDownloader.DownloadPage(url);
            int index = 0;

            var recipe = HTMLParser.NextRecipe(html, ref index);
            while(recipe != null)
            {
                recipeList.Add(recipe);
                recipe = HTMLParser.NextRecipe(html, ref index);
            }

            return recipeList.ToArray();
        }
    }
}
