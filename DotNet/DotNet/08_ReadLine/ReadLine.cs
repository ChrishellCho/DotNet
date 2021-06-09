using System

	class ReadLine
{
	static void Main()
	{
		Console.ReadLine(); // <- 이 시점에서 대기하는 효과
			//[1] 콘솔로 입력받은 문자열을 그대로 콘솔에 출력하기 
			Console.WriteLine(Console.ReadLine());

		// InputName
			//[1] 콘솔에 "이름을 입력하시오 =>" 출력 
			Console.Write("이름을 입력하시오 => ");
			//[2] 콘솔로부터 문자열을 입력받아 name 변수에 저장
			string name = Console.ReadLine();
			//[3] name 변수의 값을 {0}에 출력
			Console.WriteLine("안녕하세요. {0}님.", name);

		// Console.Read
			//[1] 콘솔로부터 문자 하나를 입력 후 엔터키를 누릅니다. 
			int x = Console.Read();

			//[2] 대문자 'A'가 입력되면 'A'에 해당하는 정수 값인 65가 출력됩니다.
			Console.WriteLine(x);

			//[3] x가 65면 정수 65에 해당하는 유니코드 문자인 A가 출력됩니다. 
			Console.WriteLine(Convert.ToChar(x));
	}
}