using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet._18_Array
{
	class Array
	{

		static void WhyArray()
		{
			//[?] 배열을 사용하지 않고 3명의 학생의 국어 점수의 총점을 구하려면? 
			var kor1 = 90; // 1번 학생
			var kor2 = 80; // 2번 학생
			var kor3 = 70; // 3번 학생

			var tot = kor1 + kor2 + kor3;

			Console.WriteLine($"총점: {tot}"); // 240 
		}

		static void ArrayString()
		{
			// 문자열== 문자의 배열
			string arr = "C#8";
			Console.WriteLine(arr[0]);
			Console.WriteLine(arr[1]);
			Console.WriteLine(arr[2]);
		}

		static void StringIndexer()
		{
			//[?] 문자열 인덱서: 문자열에 직접 인덱서([]) 사용하기 
			Console.WriteLine("ABC"[0]); // 'A'
			Console.WriteLine("ABC"[1]); // 'B'
			Console.WriteLine("ABC"[2]); // 'C'

			Console.WriteLine("ABC".GetType()); // System.String
			Console.WriteLine("ABC"[0].GetType()); // System.Char
		}

		static void ArrayDescription()
		{
			//[1] 배열 선언
			ushort[] numbers;
			//[2] 배열의 요소수 생성
			numbers = new ushort[2];    //요소수가 2이므로, [0],[1] 사용
			//[3] 배열 초기화
			numbers[0] = 3840;
			numbers[1] = 2160;
			//[4] 배열 사용
			Console.WriteLine($"{ numbers[0]} * { numbers[1]}");
		}
	}
}
