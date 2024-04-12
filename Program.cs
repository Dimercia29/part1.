namespace recipebook
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("Enter 1 to enter recipe  details");
                Console.WriteLine("Enter 2 to Display");
                Console.WriteLine("Enter 3 to Scale");
                Console.WriteLine("Enter 4 to reset Qauntities");
                Console.WriteLine("Enter 5 to Clear Recipes");
                Console.WriteLine("Enter 6 to exit");
                Console.WriteLine("=====================================================");
                string ans = Console.ReadLine();
                switch (ans)
                {
                    case "1":
                        recipe.EnterData();
                        break;
                    case "2":
                        recipe.RecipeDisplay();
                        break;
                    case "3":
                        Console.WriteLine("Enter a scale of 0.5,2or3");
                        double scale1 = Convert.ToDouble(Console.ReadLine());
                        recipe.RecipeScale(scale1);
                        break;
                    case "4":
                        recipe.ResetRecipe();
                        break;
                    case "5":
                        recipe.ClearRecipe();
                        break;
                    case "6":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Wrong value, please try again !");
                        break;
                }
            }
        }
    }
    class Recipe
    {
        //igredients
        //amounts
        private String[] ingredients;
        private double[] amount;
        private String[] units;
        private String[] steps;

        public Recipe()
        {
            ingredients = new String[0];
            amount = new double[0];
            units = new String[0];
            steps = new String[0];
        }
        public void EnterData()
        {
            Console.WriteLine("Enter number of  Ingredients");
            int ingNum = Convert.ToInt32(Console.ReadLine());

            ingredients = new string[ingNum];
            amount = new double[ingNum];
            units = new string[ingNum];
            for (int i = 0; i < ingNum; i++)
            {//when i for loop enter it will give us a number of ingredients and it will give i a value and it will incremt it by one
                Console.WriteLine($"Enter ingredient detials#{i + 1}");
                Console.Write("Name:");
                ingredients[i] = Console.ReadLine();
                Console.Write("Quantity:");
                amount[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Units  of messurement :");
                units[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter Number of steps:");
            int stpNum = Convert.ToInt32(Console.ReadLine());
            steps = new string[stpNum];

            for (int a = 0; a < stpNum; a++)
            {
                Console.Write($"Steps#{a + 1}:");
                steps[a] = Console.ReadLine();
            }
        }


        public void RecipeDisplay()
        {
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($"-{amount[i]}{units[0]} of {ingredients[i]}");
            }
            Console.WriteLine("Steps:");
            for (int a = 0; a < steps.Length; a++)
            {
                Console.WriteLine($"-{steps[a]}");
            }
        }

        public void RecipeScale(double scale)
        {
            for (int i = 0; i < amount.Length; i++)// storing the amount of things and ingredentient 
            {
                amount[i] *= scale;

            }
        }
        public void ResetRecipe()
        {
            for (int i = 0; i < amount.Length; i++)
            {
                amount[i] /=2; //this will reset everthing to 2

            }
        }

        public void ClearRecipe()
        {
            ingredients = new String[0];
            amount = new double[0];
            units = new String[0];
            steps = new String[0];
        }

    }

}