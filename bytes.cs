using System;

public class Program
{
	public static void Main()
	{
		byte b1 = 255;
		//byte b2 = -128; // compile-time error: Constant value '-128' cannot be converted to a 'byte'
		sbyte sb1 = -128;
		sbyte sb2 = 127;

		Console.WriteLine(Byte.MaxValue);
		Console.WriteLine(Byte.MinValue);
		Console.WriteLine(SByte.MaxValue);
		Console.WriteLine(SByte.MinValue);
	}
}
