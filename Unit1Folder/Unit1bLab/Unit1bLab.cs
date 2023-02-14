using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome");
		DoMath(14, 5);
		DoMath(6, 3);
		DoMath(20, 3);
		Compare(4, 7);
		Compare(7, 1);
		CheckPassword("G35VQ35DE");
		CheckPassword("SUP2JZ");
		
	}
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, value 1 is greater than value 2");
		} else {
			Console.WriteLine("False, value 2 is greater than value 1");
		}
	}
	public void CheckPassword (string password) {
		if(password == "G35VQ35DE") {
			Console.WriteLine("The password is correct");
		} else {
			Console.WriteLine("The password is incorrect");
		}
	}
}