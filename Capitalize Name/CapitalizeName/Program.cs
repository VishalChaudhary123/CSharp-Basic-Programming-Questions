using System;
using System.Collections.Generic;

namespace CapitalizeName
{
    public class Program
    {
        public static void Main()
        {
         	string a = CapitalizeName("vishal chaudhary");
		    Console.WriteLine(a);
            
        }
        public static string CapitalizeName(string str)
	   {
		string name = "";
		string [] parts = str.Split(' ');
		foreach(var item in parts)
		{
		    name += char.ToUpper(item[0]) + item.Substring(1) + " ";
			
		}
		 // Trim any extra space at the end
		name = name.TrimEnd();
		return name;
	   }
    }
}