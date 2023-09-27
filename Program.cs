var pizza = new Pizza(); //new object pizza class
pizza.AddIngredient(new Cheddar()); // object pizza. function add ingredient . (new object)
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza.Describe()); // write object pizza. function Describe


public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>(); // private list _ingredient of class Ingredient = new object
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient); //public void method is Adding Ingredient (object ingrdient)
    // => object Ingredient. methid Add (ingredient)
    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}"; //public string method Describe() =>
    // is adding "," to list
}
public class Ingredient
{
    public virtual string Name => "Some of ingredient"; // Properties string Name return string
    public int PublicField;
    public string PublicMethod() => "This method is public in Ingredients class"; // public Method return string
    private string PrivateMethod() => "This method is private in Ingredients class"; // private Method return string
    protected string ProtectedMethod() => "This method is protected in Ingredients class"; // protected Method return string can only
    // be invoked in base and derrived class
}
public class Cheese : Ingredient
{

}
public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese"; // override properties return string
    public int AgedInMonths { get; } // getter method
    public void UseMethodFromBaseClass() // public method return PublicMethod and ProtectedMethod
    {
        
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}
public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce"; // override Properties
    public int TomatosIn100Grams { get; } //getter
}
public class Mozzarella : Cheese
{
    public override string Name => "Mozzarella"; //override Properties
    public bool IsLight { get; } // public bool getter

}