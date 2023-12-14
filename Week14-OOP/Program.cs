
Dog goodBoy = new Dog("Good Boy");

Console.WriteLine($"Name: {goodBoy.Name}; Level of happinnes: {goodBoy.LevelOfHappinness}");





class Dog
{
    private string Name;
    private int LevelOfHappinness;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappinness = 0;
        Console.WriteLine($"{Name} is your friend now.");
    }
}