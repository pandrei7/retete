using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retete
{
    class RecipeChooser
    {
        public static Recipe RandomRecipe(string url)
        {
            var recipes = RecipeLoader.AllRecipes(url);
            var rng = new Random();

            return recipes[rng.Next(0, recipes.Length)];
        }

        public static Recipe RandomFilteredRecipe(string url, string filter)
        {
            var recipes = RecipeLoader.AllRecipes(url);
            recipes = filterRecipes(recipes, filter);

            // If no recipes match the filter, throw an exception
            if (recipes.Length <= 0)
            {
                throw new RecipeNotFoundException("Nicio reteta nu corespunde filtrului.");
            }

            Console.WriteLine("In urma filtrarii am gasit " + recipes.Length + " rezultate.");

            var rng = new Random();
            return recipes[rng.Next(0, recipes.Length)];
        }

        private static Recipe[] filterRecipes(Recipe[] recipes, string filter)
        {
            List<Recipe> recipeList = new List<Recipe>();
            var filterWords = filter.Replace(" ", "").Split(',');

            foreach(var recipe in recipes)
            {
                if(matchesFilter(recipe, filterWords))
                    recipeList.Add(recipe);
            }

            return recipeList.ToArray();
        }

        private static bool matchesFilter(Recipe recipe, string[] filter)
        {
            foreach(string word in filter)
            {
                if (recipe.Name.IndexOf(word, StringComparison.CurrentCultureIgnoreCase) == -1)
                    return false;
            }
            return true;
        }
    }
}
