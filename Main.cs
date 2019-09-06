/*
	Practicing C# Stuff Methods And Overall the Language 
	seeing whats similar and whats not 
*/

using System; //Allows me to use Console.WriteLine() and Console.ReadLine()  

namespace MyAapplication
{
	public class MainClass
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Please Enter Your Name ?");
			String name = (String)(Console.ReadLine());

			for(int i = 0; i < name.Length;i++)
			{
				System.Console.WriteLine(name[i]);
			}
			
			if(name ==("Jose"))
			{
				Console.WriteLine("WE HAVE THE SAME NAME");
			}

			System.Console.WriteLine("Printing a New Line");

			Triangle(10,'+');
			BackwardTriangle(10,'-');
		}
		public static void Triangle(int size, char design)
		{
			//Rows 
			for(int i = 0; i < size;i++)
			{
				//Cols
				for(int j = 0; j <= i; j++)
				{
					Console.Write(design);
				}
				Console.WriteLine(); //Printing a New Line 
			}
		}
		public static void BackwardTriangle(int size, char design)
		{
			//Rows
			for(int i = 0; i < size; i++)
			{
				//Cols
				for(int j = size; j >= i; j--)
				{
					Console.Write(design); //Printing the Design to the Scree
				}
				Console.WriteLine(); //Printing a New Line After Every Col
			}
		}
	}
}
