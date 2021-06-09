using System;

class Varuable
{
	static void Main()
	{
		// 1. Variable
		int number; //[1] 정수형 변수 만들기(선언) (이름은 소문자로)
		number = 7; //[2] 변수에 값 대입(할당)하기
		Console.WriteLine(number); //[3] 변수의 값을 화면에 출력하기(참조)

		int number2 = 152; // 변수 선언과 동시에 초기화
		Console.WriteLine("{0}", number2);

			// 구분자 1,234
			int number = 1_234; 
			Console.WriteLine(number);


		// 2. Literal
		Console.WriteLine(1234); //[1] 1234: 정수 리터럴
		Console.WriteLine(3.14F); //[2] 3.14F: 실수 리터럴
		Console.WriteLine('A'); //[3] A: 문자 리터럴/ 작은 따옴표 안에는 문자 하나만 가능
		Console.WriteLine("Hello"); //[4] Hello: 문자열리터럴

		// +접미사 F,f,D,d,M,m

		// 3. Constant(상수) : 변하지 않는 변수, read only variable
		const int MAX = 100; // 정수 형식의 상수 선언과 동시에 초기화
		MAX = 1_234;
		Console.WriteLine("최댓값: {0}", MAX);


	}
}
