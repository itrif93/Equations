/*
 * Created by SharpDevelop.
 * User: itrif93
 * Date: 03.12.2017
 * Time: 15:40
 */
using System;

namespace QuadraticEquations
{
	class Program
	{
		public static void Main(string[] args)
		{
			while(true){
				Console.WriteLine("Input a, b and c:");
				double a,b,c,x1,x2;
				if(Double.TryParse(Console.ReadLine(), out a) && Double.TryParse(Console.ReadLine(), out b)
				   && Double.TryParse(Console.ReadLine(), out c)){
					if(Convert.ToInt32(a) == 0){
						x1 = -c/b;
						Console.WriteLine("x = {0}.", x1);
					}else{
						double d = b*b - 4*a*c;
						if(d<0){
							Console.WriteLine("There are no real roots.");
						}else{
							if(Convert.ToInt32(d) == 0){
								x1 = -b/(2*a);
								Console.WriteLine("x = {0}.", x1);
							}else{
								x1 = (-b - Math.Sqrt(d))/(2*a);
								x2 = (-b + Math.Sqrt(d))/(2*a);
								Console.WriteLine("x = {0}, x2 = {1}", x1, x2);
							}
							 
						}
					}
				}else{
					Console.WriteLine("Input correct a,b and c.");
				}
				
				Console.WriteLine("Press ESC to exit or other key to continue . . . ");
				if(Console.ReadKey(true).Key.Equals(ConsoleKey.Escape)){
					break;
				}
			}
		}
	}
}