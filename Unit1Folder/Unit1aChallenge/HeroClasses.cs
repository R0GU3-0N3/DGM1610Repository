using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
    public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
        heroThree = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
        heroOne.speed = 4;
        heroOne.stealth = 3;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.speed = 4;
        heroTwo.stealth = 3;

        heroThree.health = 6;
        heroThree.powerlevel = 7;
        heroThree.speed = 1;
        heroThree.stealth = 0;
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.speed);
        Console.WriteLine(heroOne.stealth):		


		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.speed);
        Console.WriteLine(heroTwo.stealth):
        
        Console.WriteLine(heroThree.health);
        Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine(heroThree.speed);
        Console.WriteLine(heroThree.stealth):
	}
}

public class Hero {
	public int health;
	public int powerLevel;
    public int speed;
    public int stealth;
}