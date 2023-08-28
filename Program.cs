﻿
var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozzarella(),
    new TomatoSauce()

};

foreach(var ing in ingredients)
{
    Console.WriteLine(ing.Name);
}


public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredients(Ingredient ingredient) => _ingredients.Add(ingredient);
    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}
public class Ingredient
{
    public virtual string Name => "Some of ingredient";
    public int PublicField;
    public string PublicMethod() => "This method is public in Ingredients class";
    private string PrivateMethod() => "This method is private in Ingredients class";
    protected string ProtectedMethod() => "This method is protected in Ingredients class";
}
public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedInMonths { get; }
    public void UseMethodFromBaseClass()
    {
        
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}
public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}
public class Mozzarella : Ingredient
{
    public override string Name => "Mozzarella";
    public bool IsLight { get; }

}