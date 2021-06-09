using System;

class BoolCharString
{
	static void Main()
	{
		// 1. Character : 문자 데이터 형식 변수를 선언
		char grade = 'A';
		char kor = '가';

		Console.WriteLine(grade);
		Console.WriteLine(kor);

		// 2. String
		string name = "박용준";
		Console.WriteLine("안녕하세요. {0}입니다.", name);
			//MultiLine String
			string multiLines = @"
							안녕하세요.
							반갑습니다. 
					";

			Console.WriteLine(multiLines);

			// 문자열 보간법(String Interpolation) 
        string message = "String Interpolation";
        Console.WriteLine("Message: {0}", message); // WriteLine() 메서드 기본 제공
        Console.WriteLine("Message: " + message); // 더하기 연산자
        Console.WriteLine($"Message: {message}"); // 문자열 보간법

				string name = "C#";
				string version = "8.0";

				//[1] WriteLine() 메서드의 기본 제공 기능 사용
				Console.WriteLine("{0} {1}", name, version);

				//[2] String.Format() 메서드 사용
				string result = String.Format("{0} {1}", name, version);
				Console.WriteLine(result);

				//[3] 문자열 보간법(String Interpolation) 사용
				Console.WriteLine($"{name} {version}");

				// C# Interactive에서는 Console.WriteLine() 생략 가능
				// $"{name} {version}"

			// String.Format() 메서드: 문자열 연결 관련 주요 기능 제공
				string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요.");
				Console.WriteLine(msg); // 홍길동님, 안녕하세요.


		// 3. Boolean 논리 자료형: 참(True) 또는 거짓(False) 값 저장
		bool bln = true; // 참
		Console.WriteLine(bln); // true => True

		bool isFalse = false; // 거짓
		Console.WriteLine(isFalse); // false => False

	}
}
