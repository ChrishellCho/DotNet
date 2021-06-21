using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet._23_Enumeration
{
	// 열거형(Enumeration) : 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수 집합을 정의


	class Enum
	{
		static void EnumerationTextbook()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Red");
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Green & {nameof(ConsoleColor.Yellow)}");
			Console.ResetColor();
		}
	}

	class EnumAnimal 
	{
		enum Animal { Mouse, Cow, Tiger}

		static void Main()
		{
			Animal animal = Animal.Tiger;
			Console.WriteLine(animal); // Tiger

			if (animal == Animal.Tiger)
			{
				Console.WriteLine("호랑이");
			}
		}
	}

	class EnumIndex
	{
		enum Animal { Rabbit, Dragon, Snake }
		static void Main()
		{
			Animal animal = Animal.Dragon;
			int num = (int)animal; // 1
			string str = animal.ToString(); // "Dragon"
			Console.WriteLine($"Animal.Dragon : {num}, {str}");
		}
	}
}
