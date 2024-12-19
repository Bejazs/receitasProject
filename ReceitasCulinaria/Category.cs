using System.Collections.Generic;

public class Category
{
    public string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }

    // For ease of use in combo box binding
    public override string ToString()
    {
        return Name;
    }
}

public static class CategoryList
{
    public static List<Category> Categories = new List<Category>
    {
        new Category("Carne"),
        new Category("Peixe"),
        new Category("Marisco"),
        new Category("Pastelaria"),
        new Category("Sobremesas")
    };
}
