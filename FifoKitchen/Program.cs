// Write a system that handles a kitchen food inventory

// We need a means of automatically storing in a first in first out system any kind of food ingredient

// ex. Lettuce "Monday", Lettuce "Tuesday", 
// ex Tomato "Wednesday", Tomato "Wednesday"

// Greek Salad [Lettuce Monday, Tomato Wednesday, Black Olives : "Missing black olives"]

// to add food, enter the name of the food, and day of the week it was added
// system should respond with how many of that item are now in the fridge

Dictionary<string, Queue<DateTime>> Ingredients = new Dictionary<string, Queue<DateTime>>();

bool continueRunning = true;

while(continueRunning)
{
    Console.WriteLine("1. Add or 2. Remove Ingredient");
    int addOrRemoveInput = Int32.Parse(Console.ReadLine());

    if (addOrRemoveInput == 1) 
    {
        // === ADD INGREDIENTS === 
        #region
        Console.WriteLine("Please input ingredient to add, STOP to end: ");
        string ingredientName = Console.ReadLine().ToUpper();

        while (ingredientName != "STOP")
        {

            while (ingredientName.Length < 3)
            {
                Console.WriteLine("Enter a minimum of three characters");
                ingredientName = Console.ReadLine().ToUpper();
            }

            if (!Ingredients.ContainsKey(ingredientName))
            {
                Ingredients.Add(ingredientName, new Queue<DateTime>());
            }

            Ingredients[ingredientName].Enqueue(DateTime.Now);
            ingredientName = Console.ReadLine().ToUpper();
        }

        #endregion
    } else if (addOrRemoveInput == 2)
    {
        // REMOVE INGREDIENT
        #region
        Console.WriteLine("Enter the name of the ingredient you want from the fridge, or STOP to stop removing: ");
        string removeInput = Console.ReadLine().ToUpper();

        while (removeInput != "STOP")
        {
            if (!Ingredients.ContainsKey(removeInput))
            {
                Console.WriteLine($"No ingredient found with name {removeInput}");
            }
            else
            {
                DateTime removedDate = Ingredients[removeInput].Dequeue();
                Console.WriteLine($"Removed {removeInput} with entry date {removedDate.ToString()}");
            }

            Console.WriteLine("Enter an item to remove");
            removeInput = Console.ReadLine().ToUpper();
        }
        #endregion
    } else
    {
        Console.WriteLine("Invalid choice");
        Console.WriteLine("1. Add or 2. Remove Ingredient");
        addOrRemoveInput = Int32.Parse(Console.ReadLine());
    }




}


// TEST
foreach (KeyValuePair<string, Queue<DateTime>> pair in Ingredients)
{
    Console.WriteLine(pair.Key);
    foreach(DateTime date in pair.Value)
    {
        Console.WriteLine(date.ToString());
    }
}