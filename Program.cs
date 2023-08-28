var cheddar = new Cheddar();
var ing = new Ingredient();


Console.WriteLine(cheddar.PublicField);
Console.WriteLine(ing.PublicField);
cheddar.PublicField = 16;
Console.WriteLine(cheddar.PublicField);
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredients(Ingredient ingredient) => _ingredients.Add(ingredient);
    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}
public class Ingredient
{
    public int PublicField = 15;
    public string PublicMethod() => "This method is public in Ingredients class";
    private string PrivateMethod() => "This method is private in Ingredients class";
    protected string ProtectedMethod() => "This method is prothected in Ingredients class";
}
public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedInMonths { get; }
    public void UseMethodFromBaseClass()
    {
        //Console.WriteLine(PrivateMethod());
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}
public class TomatoSauce : Ingredient
{
    public string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}
public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella";
    public bool IsLight { get; }

}