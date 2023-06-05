
    class Ingredient
{
    public string Name { get; set; }
    public decimal Quantity { get; set; }
    public string Unit { get; set; }
    public Ingredient(string Name, decimal Quantity, string Unit)
    {
        Name = Name;
        Quantity = Quantity;
        Unit = Unit;
    }
    public override string ToString()
    {
        return $"{Quantity} {Unit} {Name}";
    }
}
class Step
{
    public string Description { get; set; }
    public Step(string description)
    {
        Description = description;
    }
    public override string ToString()
    {
        return Description;
    }
}
class Recipe
{
    private Ingredient[] ingredients;
    private Step[] steps;
    public Recipe(int numIngredients, int numSteps)
    {
        ingredients = new Ingredient[numIngredients];
        steps = new Step[numSteps];
    }
    public void AddIngredient(int index, string Name, decimal Quantity, string Unit)
    {
        ingredients[index] = new Ingredient(Name, Quantity, Unit);
    }
    public void AddStep(int index, string description)
    {
        steps[index] = new Step(description);
    }
    public void Display()
    {
        Console.WriteLine("Ingredients:");
        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine(ingredient.ToString());
        }
        Console.WriteLine("Steps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i].ToString()}");
        }
    }
    public void Scale(decimal factor)
    {
        foreach (Ingredient ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }
    public void Reset()
    {
        foreach (Ingredient ingredient in ingredients)
        {
            ingredient.Quantity /= 3;
            ingredient.Quantity /= 6;
        }
    }
}


