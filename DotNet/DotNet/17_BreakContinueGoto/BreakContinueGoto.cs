using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet._17_BreakContinueGoto
{
	class BreakContinueGoto
	{
		static void BreakFor()
		{
			for(int i=0; i < 5; i++)
			{
				if (i >= 0)
				{
					break;
				}
			}
		}

		static void BreakInfiniteLoop()
		{
			int number = 0;

			while (true)
			{
				Console.WriteLine(++number);
				if (number >= 5)
				{
					break;
				}
			}
		}

		static void BreakDemo()
		{
			for (int i=0; i < 100; i++)
			{
				if (i == 5)
				{
					break;
				}
				Console.Write($"{(i + 1)}번 반복\t");
			}
			Console.WriteLine();
		}

		static void WhileBreak()
		{
			int goal = 22;
			int sum = 0;

			int i = 1;
			while (i <= 10)
			{
				sum += i;
				if (sum >= goal)
				{
					break;
				}
				i++;
			}

			Console.WriteLine($"1부터 {i}까지의 합은 {sum}이고, 목표치 {goal}이상을 달성했습니다.");
		}

		static void ForIFContinue()
		{
			for (int i=1; i<=5; i++)
			{
				if (i % 2 == 0)
				{
					//[!] 현재 반복 중지 후 다음 반복으로 이동
					continue;
				}
				Console.WriteLine(i);
			}
		}

		static void ContinueDemo()
		{
			//[!] 1~100까지 정수 중 3의 배수를 제외한 수의 합
			int sum = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0)
				{
					continue; // 3의 배수이면 [i++] 코드 영역으로 이동하기 
				}
				sum += i;
			}
			Console.WriteLine("SUM: {0}", sum); // 3367
		}

		static void GotoDemo()
		{
			Console.WriteLine("시작");
			Start:
				Console.WriteLine("0,1,2 중 하나 입력 : _\b");
				int chapter = Convert.ToInt32(Console.ReadLine());

				if (chapter == 1)
				{
					goto Chapter1;
				}
				else if (chapter == 2)
				{
					goto Chapter2;
				}
				else
				{
					goto End;
				}

			Chapter1:
				Console.WriteLine("1장입니다");
			Chapter2:
				Console.WriteLine("2장입니다");
				goto Start;

			End:
				Console.WriteLine("종료");
		}
	}
}
