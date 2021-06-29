using System;
using static System.Console;

namespace DotNet._14_Switch
{
	class Switch
	{
		static void SwitchExpression()
		{
			int x = 2;
			switch (x)
			{
				case 1:
					Console.WriteLine("1입니다."); //x가 1일 때 실행
					break;
				case 2:
					Console.WriteLine("2입니다."); //x가 2일 때 실행
					break;
			}
		}
		static void SwitchDemo()
		{
			Console.WriteLine("정수를 입력하세요.");
			int answer = Convert.ToInt32(Console.ReadLine());

			// 선택문
			switch (answer)
			{
				case 1:
					Console.WriteLine("1을 선택했습니다.");
					break;
				case 2:
					Console.WriteLine("2을 선택했습니다.");
					break;
				case 3:
					Console.WriteLine("3을 선택했습니다.");
					break;
				default:
					Console.WriteLine("그냥 찍으셨군요.");
					break;
			}
		}

		static void SwitchStatement()
		{
			WriteLine("가장 좋아하는 프로그래밍 언어는? ");
			Write("1. C\t");
			Write("2. C++\t");
			Write("3. C#\t");
			Write("4. Java\n");

			int choice = Convert.ToInt32(ReadLine());

			switch (choice)
			{
				case 1:
					WriteLine("C언어 선택");
					break;
				case 2:
					WriteLine("C++ 선택");
					break;
				case 3:
					WriteLine("C# 선택");
					break;
				case 4:
					WriteLine("Java 선택");
					break;
				default:
					WriteLine("C, C++, C#, Java가 아니군요.");
					break;
			}
		}
	}
}
