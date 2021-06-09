using System;

class Number
{
	static void Main()
	{
		// 1. Integer

		// Int min, max
		int min = Int32.MinValue;
		int max = Int32.MaxValue;
		Console.WriteLine(min);
		Console.WriteLine(max);

		// signedInteger:  부호있는 정수 데이터 형식 : sbyte, short, int, long
		sbyte iSByte = 127;                 //  8비트 부호 있는 정수형 변수 선언 및 할당
		short iInt16 = 32767;               // 16비트 부호 있는 정수형 변수 선언 및 할당
		int iInt32 = 2147483647;          // 32비트 부호 있는 정수형 변수 선언 및 할당
		long iInt64 = 9223372036854775807; // 64비트 부호 있는 정수형 변수 선언 및 할당

		Console.WriteLine("sbyte: {0}", iSByte);
		Console.WriteLine("short: {0}", iInt16);
		Console.WriteLine("int  : {0}", iInt32);
		Console.WriteLine("long : {0}", iInt64);

		// unsignedInteger: 부호 없는 정수 데이터 형식: byte, ushort, uint, ulong
		byte iByte = 255;                  //  8비트 부호 없는 정수형 변수 선언 및 할당
		ushort iUInt16 = 65535;                // 16비트 부호 없는 정수형 변수 선언 및 할당
		uint iUInt32 = 4294967295;           // 32비트 부호 없는 정수형 변수 선언 및 할당
		ulong iUInt64 = 18446744073709551615; // 64비트 부호 없는 정수형 변수 선언 및 할당

		Console.WriteLine("byte  : {0}", iByte);
		Console.WriteLine("ushort: {0}", iUInt16);
		Console.WriteLine("uint  : {0}", iUInt32);
		Console.WriteLine("ulong : {0}", iUInt64);

		// 2. double : 실수형 데이터 형식 (64비트 부동 소수점 숫자)
		double PI = 3.141592; // 배정밀도 부동 소수점 변수를 선언하고 값을 할당
		Console.WriteLine("{0}", PI); // 3.141592

		// 3. Float : 실수형 데이터 형식(32비트 부동 소수점 숫자)
		float f = 99.99F; // 단정밀도 부동 소수점 변수를 선언하고 값을 할당 
		Console.WriteLine("{0}", f); // 99.99
			//Float min, max
			float min = float.MinValue; // float의 최솟값
			float max = float.MaxValue; // float의 최댓값

			Console.WriteLine(min); // -3.402823E+38
			Console.WriteLine(max); // +3.402823E+38

		// 4. Decimal : 실수형 데이터 형식(128비트 10진수)
		decimal d = 12.34M; // decimal 변수 선언 후 실수 데이터 저장 
		Console.WriteLine("{0}", d); // 12.34
			// Decimal min,max
			decimal min = Decimal.MinValue;
      decimal max = Decimal.MaxValue;

      Console.WriteLine(min); // -79228162514264337593543950335
      Console.WriteLine(max); // +79228162514264337593543950335

		//5. Nullable
		int? x = null; // 널 가능 형식
		double? d = null;
		Console.WriteLine(x);
		Console.WriteLine(d);
	}
}
