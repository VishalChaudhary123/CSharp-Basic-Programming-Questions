using System;
using System.Diagnostics;

public class Program
{
	public static void Main()
	{
		int [] input = new int [] {10,34,100,67,89,3,23};
		Console.WriteLine(LargestElement(input));
		Console.WriteLine(SmallestElement(input));
	}
	public static int LargestElement(int [] input)
	{
		int num = 0;
		for(int i =0; i<= input.Length-1; i++)
		{
			if( input[i]>= num)
			{
				num = input[i];
			}
		}
		return num;
	}
	public static int SmallestElement(int[] input)
	{
		int num = int.MaxValue;
		for(int i =0; i<=input.Length-1;i++)
		{
			if(input[i] < num){
				num = input[i];
			}
		}
		return num;
	}
}