using System;
					
public class Class
{
	public Gun revolver;
	public Gun rifle;
    public Gun sniper;
	
	public void Main()
	{
		revolver = new Gun();
		rifle = new Gun();
        sniper = new Gun();

        revolver.rpm = 140;
        revolver.damage = 50;
        revolver.range = 30;

        rifle.rpm = 600;
        rifle.damage = 10;
        rifle.range = 50;

        sniper.rpm = 90;
        sniper.damage = 100;
        sniper.range = 100;

        Console.WriteLine(revolver.rpm);
        Console.WriteLine(revolver.damage);
        Console.WriteLine(revolver.range);

        Console.WriteLine(rifle.rpm);
        Console.WriteLine(rifle.damage);
        Console.WriteLine(rifle.range);

        Console.WriteLine(sniper.rpm);
        Console.WriteLine(sniper.damage);
        COnsole.WriteLine(sniper.range);
	}
}

public class Gun {
	public int rpm;
	public int damage;
    public int range;
}