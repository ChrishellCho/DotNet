//  예외 처리(Exception Handling): try-catch-finally와 throw를 사용해 에외 처리하기

using System;

class TryCatch
{
	static void Main()
	{
		try
		{
			int[] arr = new int[2];
			arr[100] = 1234;  // 에러(예외) 발생 : System.IndexOutOfRangeException 
		}
		catch
		{
			Console.WriteLine("에러가 발생했습니다.");
		}
	}
}

class ExceptionDemo
{
	static void Main()
	{
		try
		{
			int[] arr = new int[2];
			arr[100] = 1234;
		}
		catch (Exception ex) // ex 변수에는 예외에 대한 상세 정보가 담김
		{
			Console.WriteLine(ex.Message);
		}
	}
}

class FormatExceptionDemo
{
	static void Main()
	{
		string inputNumber = "3.14";
		int number = 0;

		try
		{
			number = Convert.ToInt32(inputNumber);
			Console.WriteLine($"입력한 값 : {number}");
		}
		catch (FormatException fe)
		{
			Console.WriteLine( $"에러 발생 : {fe.Message}");
			Console.WriteLine( $"{inputNumber}는 정수여야 합니다" );
		}
	}
}


class TryCatchDemi
{
	static void Main()
	{
		try
		{
			int now = DateTime.Now.Second;
			Console.WriteLine($"[0] 현재 초 : {now}");

			//[!] 실행시간이 짝수이면 0으로 나누기에 에러가 발생
			int result = 2 / (now % 2);
			Console.WriteLine("[1] 홀수초에는 정상 처리");
		}
		catch
		{
			Console.WriteLine("[2] 짝수 초에서는 런타임 에러 발생");
		}
	}
}


class TrowNote
{
	static void Main()
	{
		throw new Exception();
		throw new ArgumentException();
	}
}