using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet._09_Operator
{
	class Operator
	{
		static void OperatorDescription()
		{
			//[1] 식(Expression)
			Console.WriteLine(3 + 5); // 8
			Console.WriteLine(3 - 5); // -2

			//[2] 문(Statement) 
			Console.WriteLine(3 * 5); // 15
			Console.WriteLine(3 / 5); // 0
		}

		static void UnaryOperator() // 단항 연산자
		{
			int value = 0;

			value = 8; // value에 8 대입
			value = +value; // value의 값에 + 기호로 붙여 있는 그대로 표현
			Console.WriteLine(value); // +8

			value = -8; // value에 -8 대입
			value = +value; // value의 값에 + 기호를 붙여 있는 그대로 표현
			Console.WriteLine(value); // -8

			value = 8; // value에 8 대입
			value = -value; // value의 값에 - 기호를 붙여 부호를 반대로 변경
			Console.WriteLine(value); // -8

			value = -8; // value에 -8 대입
			value = -value; // value의 값에 - 기호를 붙여 부호를 반대로 변경
			Console.WriteLine(value); // +8
		}

		static void CastingOperator()
		{
			int number = (int)3.14; // 3.14를 정수(int)로 변환
			Console.WriteLine(number); // 3
		}

		static void PlusOperator()
		{
			int i = 10;
			int j = 20;
			int k = i + j; // k = 10 + 20
			Console.WriteLine(k); // 30
		}

		static void OperatorAdd()
		{
			int i = 10;
			int j = 20;
			int k = i + j; // k = 10 + 20
			Console.WriteLine(k); // 30
		}

		static void OperatorSubtract()
		{
			decimal i = 3.14M;
			decimal j = 3.14M;
			decimal k = i - j; // k = 3.14 - 3.14
			Console.WriteLine(k); // 0.00
		}

		static void OperatorMultiply()
		{
			long i = 100;
			long j = 200;
			long k = i * j; // k = 100 * 200
			Console.WriteLine(k); // 20000
		}

		static void OperatorDivide()
		{
			double i = 1.5;
			double j = 0.5;
			double k = i / j; // k = 1.5 / 0.5
			Console.WriteLine(k); // 3
		}

		static void Remainder() // 나머지 값 구하기
		{
			int first = 5;
			int second = 3;
			int result = 0;
			result = first % second;
			Console.WriteLine(result);
		}

		static void AdditionOperator()
		{
			Console.WriteLine("Hello" + "World"); // 문자열 더하기 
			Console.WriteLine("Hi" + " " + "everyone");
			Console.WriteLine("123" + "456"); // "123456" => 숫자형 문자열은 문자열로 취급
			Console.WriteLine("123" + 456); // "123456" => 문자열과 숫자형은 문자열로 취급
			Console.WriteLine(123 + "456"); // "123456"
			Console.WriteLine(123 + 456); // 산술연산 => 숫자들끼리는 산술 연산
			Console.WriteLine("123" + true); // 123True => bool 형식과의 더하기는 문자열 취급
																			 //Console.WriteLine("123" - 456); // 에러: 문자열에서 정수를 뺄 수 없음
		}

		static void NumberToString()
		{
			int days = 28;

			//[1] 암시적(Implicit)으로 숫자 형식을 문자열로 변환하기
			Console.WriteLine($"2월달은 {days}일입니다");

			//[2] 명시적(Explicit)으로 숫자 형식을 문자열로 변환하기: 2가지
			Console.WriteLine($"2월달은 {days.ToString()}일입니다");
			Console.WriteLine($"2월달은 {Convert.ToString(days)}일입니다");
		}
	}
}
