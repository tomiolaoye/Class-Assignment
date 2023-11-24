using System;

public class Sport
{
    // Class members
    private string name;
    private int numberOfPlayers;
    private string rules;

    // Constructor
    public Sport(string name, int numberOfPlayers, string rules)
    {
        this.name = name;
        this.numberOfPlayers = numberOfPlayers;
        this.rules = rules;
    }

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int NumberOfPlayers
    {
        get { return numberOfPlayers; }
        set { numberOfPlayers = value; }
    }

    public string Rules
    {
        get { return rules; }
        set { rules = value; }
    }

    // Method to display information about the sport
    public void DisplaySportInfo()
    {
        Console.WriteLine($"Sport: {name}");
        Console.WriteLine($"Number of Players: {numberOfPlayers}");
        Console.WriteLine($"Rules: {rules}");
    }

    // Main method
    public static void Main(string[] args)
    {
        Sport soccer = new Sport("Soccer", 11, "Score by getting the ball into the opponent's goal.");

        // Display information about the sport
        soccer.DisplaySportInfo();
    }
}
