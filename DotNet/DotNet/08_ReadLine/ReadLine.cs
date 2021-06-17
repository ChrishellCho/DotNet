using System;
using System.Text;

class ReadLine
{
	static void Main()
	{
		Console.ReadLine(); // <- 이 시점에서 대기하는 효과
			//[1] 콘솔로 입력받은 문자열을 그대로 콘솔에 출력하기 
			Console.WriteLine(Console.ReadLine());


		//3. InputName
			//[1] 콘솔에 "이름을 입력하시오 =>" 출력 
			Console.Write("이름을 입력하시오 => ");
			//[2] 콘솔로부터 문자열을 입력받아 name 변수에 저장
			string name = Console.ReadLine();
			//[3] name 변수의 값을 {0}에 출력
			Console.WriteLine("안녕하세요. {0}님.", name);


		//4. Console.Read
			//[1] 콘솔로부터 문자 하나를 입력 후 엔터키를 누릅니다. 
			int x = Console.Read();

			//[2] 대문자 'A'가 입력되면 'A'에 해당하는 정수 값인 65가 출력됩니다.
			Console.WriteLine(x);

			//[3] x가 65면 정수 65에 해당하는 유니코드 문자인 A가 출력됩니다. 
			Console.WriteLine(Convert.ToChar(x));


		//5. TypeConversionError
			//[1] long 형식 변수의 가장 큰 값을 l 변수에 저장
			long l = long.MaxValue;
			Console.WriteLine($"l의 값 : {l}");
			//[2] l 변수의 값을 int 형식으로 형식 변환하여 i 변수에 저장
			int i = (int)l;
			Console.WriteLine($"i의 값 : {i}");


		//6. IntToByte
			int z = 255;
			byte y = (byte)x; // byte 형식은 0에서 255까지 저장 가능
			Console.WriteLine($"{z} -> {y}");


		//7. TypeConversion
			double d = 12.34;
			int a = 1234;

			//[1] double > int: 묵시적(암묵적, 암시적) 형식 변환
			d = a; // 큰 그릇에 작은 그릇의 값이 저장
			Console.WriteLine("암시적 형식 변환 = " + d); // 1234

			//[2] 작은 형식 <= 큰 형식: 명시적인 형식 변환 필요
			d = 12.34;
			a = (int)d; // () 캐스트 연산자 사용: 정수형 데이만 저장
			Console.WriteLine("명시적 형식 변환 = " + a); // 12

			//[3] 다른 형식간의 변환: Convert 클래스
			string s = "";
			s = Convert.ToString(d); // Convert.ToInt32(), Convert.ToDouble()
			Console.WriteLine("형식 변환 = " + s); // "12.34"


		//8. GetType
			int b = 1234;               // 정수
			string c = "안녕하세요.";    // 문자열
			char e = 'A';               // 문자
			double f = 3.14;            // 실수
			object g = new Object();    // 개체: 개체 생성하는 구문

			Console.WriteLine(b.GetType()); // System.Int32
			Console.WriteLine(c.GetType()); // System.String
			Console.WriteLine(e.GetType()); // System.Char
			Console.WriteLine(f.GetType()); // System.Double
			Console.WriteLine(g.GetType()); // System.Object


		//9. ReadLineInteger
			Console.Write("정수를 입력하세요: ");
			string input = Console.ReadLine(); // "10"을 입력한다면
			int number = Convert.ToInt32(input); // "10"을 정수 10으로 변환
			Console.WriteLine($"{number}-{number.GetType()}"); // 10-System.Int32


		//10. ReadLineRealNumber
			Console.Write("실수를 입력하세요: ");
			string input2 = Console.ReadLine(); // "3.14"를 입력한다면 
			double PI = Convert.ToDouble(input2); // "3.14"를 3.14로 변경
			Console.WriteLine(PI); // 3.14


		//11. ReadLineCharacter
			Console.Write("문자를 입력하세요: ");
			string input3 = Console.ReadLine(); // "가"를 입력하면 
			char charac = Convert.ToChar(input3); // "가"를 '가'로 변환
			Console.WriteLine(c); // '가'


		//12. BinaryString
			byte h = 10;
			// x를 2진수로 표현하되, 8자리로 하고 앞부분은 모두 _으로 채운다
			Console.WriteLine($"십진수: {h} -> 이진수: {Convert.ToString(h, 2).PadLeft(8, '_')}"); //____1010


		//13. RadixTransformation
			// 10진수 10을 2진수로 변경하면 1010
			Console.WriteLine(
					$"십진수 10을 이진수로 변경: {Convert.ToString(10, 2)}"); // 8421 => 1010

			// 2진수 1010을 10진수로 변경하면 10
			Console.WriteLine(
					$"이진수 1010을 십진수로 변경: {Convert.ToInt32("1010", 2)}"); // 10


		//14. BinaryLiteral
			// 0b 또는 0B로 시작하는 정수 리터럴은 이진수 리터럴
			byte b1 = 0b0010; // 이진수 0010 -> 십진수 2 
			byte b2 = 0B1100; // 이진수 1100 -> 십진수 12

			// 컴퓨터에서는 자동으로 십진수 단위로 처리함
			Console.WriteLine($"10진수: {b1}"); // 10진수: 2
			Console.WriteLine($"10진수: {b2}"); // 10진수: 12


		//15. DigitSeparatorPseudo
			int bin = 0b0001_0001; // 0001 0001 
			int dec = 1_000_000; // 1,000,000
			int hex = 0xA0_B0_C0; // A0 B0 C0

			Console.WriteLine(bin); // 17
			Console.WriteLine(dec); // 1000000
			Console.WriteLine(hex); // ‭10531008‬


		//16. Var : 암시적으로 형식화된 로컬 변수
			var name2 = "C#"; // string 형식으로 변환해줌
			Console.WriteLine(name2); // C#

			var version = 8.0; // double 형식으로 변환해줌
			Console.WriteLine("{0:0.0}", version); // 8.0


		//17. TypeAssertion
			var number2 = 1234; // int number2;
			Console.WriteLine(number2.GetType()); // System.Int32

			var message = "안녕하세요."; // string message;
			Console.WriteLine(message.GetType()); // System.String 


		//18. VarInput
			// 문자열 입력 받기
			var j = Console.ReadLine();

			// 문자 하나 입력 받기
			var k = Convert.ToChar(Console.Read());

			// 입력받은 값과 형식 출력하기 
			Console.WriteLine($"{j}: {j.GetType()}, {k}: {k.GetType()}");


		//19. KeyboardInput
			Console.WriteLine("아무키나 누르세요.");
			// 키보드 키 값 입력
			ConsoleKeyInfo cki = Console.ReadKey(true);
			Console.WriteLine("{0}", cki.Key); // 키
			Console.WriteLine("{0}", cki.KeyChar); // 유니코드
			Console.WriteLine("{0}", cki.Modifiers); // Ctrl, Shift, Alt 조합
			if (cki.Key == ConsoleKey.Q)
			{
				Console.WriteLine("Q를 입력하셨군요...");
			}


		//20. VariableDefault
			int m = default;
			double n = default;
			char o = default;
			string p = default;
			Console.WriteLine($"[{m}], [{n}], [{o}], [{p}]");
			Console.WriteLine($"[{m}], [{n}], [{o == Char.MinValue}], [{p == null}]");


		//21. DefaultExpression
			// default 키워드
			int intDefault = default(int); // int 형식의 기본값
			bool boolDefault = default(bool); // bool 형식의 기본값
			string strDefault = default(string); // string 형식의 기본값
			StringBuilder sbDefault =
					default(StringBuilder); // StringBuilder 클래스의 기본값

			Console.WriteLine(intDefault); // 0
			Console.WriteLine(boolDefault); // false
			Console.WriteLine(strDefault); // null
			Console.WriteLine(sbDefault); // null
			Console.WriteLine(sbDefault == null); // true
	}
}