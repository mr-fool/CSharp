using System;
class Pet
{
    private string name = "N/A";
    private string sex = "N/A";
    private string type = "N/A";
    private int age = 0;

    //properties
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public string Sex
    {
        get
        {
            return sex;
        }
        set
        {
            sex = value;
        }
    }
    public string Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    public override string ToString()
    {
        return "Name = " + name + ", Type = " + type + ", Sex = " + sex + ", Age = " + age;
    }

    public static void Main()
    {
        Console.WriteLine("Pet Properties");

        // Create a new Person object:
        Pet pet = new Pet();

        // Print out the name and the age associated with the person:
        Console.WriteLine("Pet details - {0}", pet);
        pet.Name = "Doge";
        pet.Age = 99;
        pet.Sex = "male";
        pet.Type = "Shiba Inu";
        Console.WriteLine("Pet details - {0}", pet);
    }
}
