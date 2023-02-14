using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Start your engines!");
		GearShift("Early");
		GearShift("Late");
		GearShift("Perfect");
	}
	public void GearShift (string timing) {
		if (timing == "Perfect") {
			Console.WriteLine("You made a perfect shift and won the race!");
		} else if (timing == "Early") {
			Console.WriteLine("You shifted too early and lost...");
		} else {
			Console.WriteLine("You redlined your car and your engine exploded... how embarrasing");
		}
	}
}