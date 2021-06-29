using System;


// 함수(function) : 반복하여 사용하도록 하나의 이름으로 만들어 놓은 코드의 집합
class Function
{
  // 선언
  static int Sum(int first, int second = 5) => (first + second);

  // 호출: DotNet.exe 3 5 
  static void Main(string[] args)
  {
    int first = Convert.ToInt32(args[0]);
    int second = Convert.ToInt32(args[1]);
    Console.WriteLine(Sum(first, second));
  }


  //[1] Show 메서드(함수) 선언
  static void Show()
  {
    Console.WriteLine("Hello World");
  }

  // Main 메서드(함수)
  static void Main()
  {
    Show(); //[2] 호출
  }
}

class FunctionCall
{
  //[1] 함수 만들기(정의, 선언)
  static void Hi()    //static: 정적,공유/  void: 비어있다,반환값
	{
    Console.WriteLine("안녕하세요");
	}

  static void Main()
	{
    //[2] 함수 사용하기(호출): 여러 번 호출
    Hi(); Hi(); Hi();
  }
}

class FunctionParameter
{
  // 매개 변수가 있는 함수
  static void ShowMessage(string message)
	{
    Console.WriteLine(message);   // 넘어온 매개 변수의 값을 출력
  }

  static void Main()
	{
    ShowMessage("매개변수");    // ShowMessage() 함수에 "매개 변수" 문자열 전달
    ShowMessage("Parameter");   // ShowMessage() 함수에 "Parameter" 문자열 전달
  }
}


class ReturnValue
{
  static string GetString()
	{
    return "반환값(Return Value)"; // return 키워드로 단순 문자열 반환
	}

  static void Main()
	{
    //GetString() 함수 호출 후 반환된 반환값을 returnValue 변수에 저장
    string returnValue = GetString();
    Console.WriteLine(returnValue);
	}
}

class FunctionReturnValue   //반환값이 있는 함수(메서드)
{
  static int SquareFunction(int x)    // 입력: 매개 변수도 있고 
  {
    int r = x * x;                  // 처리: 함수의 본문
    return r;                       // 출력: 반환값도 있는 
  }
  static void Main()
  {
    int r = SquareFunction(2); // 함수 호출 및 반환값 받기 
    Console.WriteLine(r); // 4
  }
}


class MaxMinFunction
{
  // Max 함수: 두 수 중에서 큰 수를 반환시켜주는 함수
  static int Max(int x, int y)
  {
    return (x > y) ? x : y; // 3항 연산자로 큰 수 구하기 
  }

  // Min 함수: 두 수 중에서 작은 수를 반환시켜주는 함수
  static int Min(int x, int y)
  {
    // if else 문으로 작은 수 구하기 
    if (x < y)
    {
      return x; // 작은 값
    }
    else
    {
      return y;
    }
  }

  static void Main()
  {
    Console.WriteLine(Max(3, 5)); // 5
    Console.WriteLine(Min(-3, -5)); // -5
  }
}


class FunctionAbs
{
  //[?] 절댓값을 구하는 함수 만들기
  static int Abs(int num)
  {
    return (num < 0) ? -num : num;
  }

  static void Main()
  {
    int num = -21;
    int abs = Abs(num);
    Console.WriteLine($"{num}의 절댓값: {abs}");
  }
}


class FunctionAddNumbers
{
  /// <summary>
  /// 두 수를 더해서 그 결괏값을 반환시켜주는 함수
  /// </summary>
  /// <param name="a">첫번째 매개변수</param>
  /// <param name="b">두번째 매개변수</param>
  /// <returns>a + b 결과</returns>
  static int AddNumbers(int a, int b)
  {
    return a + b;
  }

  static void Main()
  {
    int a = 3;
    int b = 5;
    int c = AddNumbers(3, 5);
    Console.WriteLine($"{a} + {b} = {c}");
  }
}

class DefaultParameter
{
  static void Main()
  {
    Log("디버그");        // [A] 두 번째 매개 변수 생략
    Log("에러", 4);       // [B] 전체 매개 변수 사용
  }

  // [1] 기본 매개 변수(선택적 매개 변수): 매개 변수 선언과 동시에 초기화
  static void Log(string message, byte level = 1)
  {
    Console.WriteLine($"{message}, {level}");
  }
}


class NamedParameter
{
  static void Main()
  {
    // 기본 형태
    Sum(10, 20); // 30

    // [1] 매개 변수 이름과 콜론(:) 기호를 사용하여 호출
    Sum(first: 10, second: 20); // 30

    // [2] 매개 변수 이름 지정하면 변수 위치 변경 가능
    Sum(second: 20, first: 10); // 30
  }

  // 명명된 매개 변수(Named Parameter)
  static void Sum(int first, int second)
  {
    Console.WriteLine(first + second);
  }
}

class MethodOverloadNumber    //메서드(함수) 오버로드(다중 정의)
{
  // GetNumber 함수: int 매개 변수
  static void GetNumber(int number)
  {
    Console.WriteLine($"Int32: {number}");
  }

  // GetNumber 함수: long 매개 변수
  static void GetNumber(long number)
  {
    Console.WriteLine($"Int64: {number}");
  }

  static void Main()
  {
    GetNumber(1234);    // Int32: 1234
    GetNumber(1234L);   // Int64: 1234
  }
}


class MethodOverload
{
  // 매개 변수가 없는 Hi() 함수
  static void Hi()
  {
    Console.WriteLine("안녕하세요.");
  }

  // 매개 변수가 있는 Hi() 함수
  static void Hi(string msg)
  {
    Console.WriteLine(msg);
  }

  static void Main()
  {
    Hi();
    Hi("반갑습니다.");
  }
}

class FunctionOverload    // 함수(메서드) 오버로드(Overload; 오버로딩): 다중 정의/여러 번 정의/중복
{
  static void Multi()
  {
    Console.WriteLine("안녕하세요.");
  }

  static void Multi(string message)
  {
    Console.WriteLine(message);
  }

  static void Multi(string message, int count)
  {
    for (int i = 0; i < count; i++)
    {
      Console.WriteLine("{0}", message);
    }
  }

  static void Main()
  {
    Multi();
    Multi("반갑습니다.");
    Multi("또 만나요.", 3);
  }
}


class RecursionDemo   //재귀 함수
{
  static void Main()
  {
    // 재귀 호출을 사용하여 Factorial을 구하기: 4! = 4 * 3 * 2 * 1 = 24
    Console.WriteLine(4 * 3 * 2 * 1); // 24
    Console.WriteLine(FactorialFor(4));
    Console.WriteLine(Factorial(4));
    Console.WriteLine(Fact(4));
  }

  // 3항 연산자를 사용한 Factorial 구하기
  static int Fact(int n)
  {
    return (n > 1) ? n * Fact(n - 1) : 1;
  }

  // 재귀 함수를 사용한 Factorial 함수 만들기: 단, 재귀함수는 Tree 구조 탐색에 유리
  static int Factorial(int n)
  {
    // 종료
    if (n == 0 || n == 1)
    {
      return 1;
    }
    // 재귀 호출
    return n * Factorial(n - 1);
  }

  // 단순한 Factorial은 이 방법이 좋음
  static int FactorialFor(int n)
  {
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
      result *= i; // ((((1 * 1) * 2) * 3) * 4)
    }
    return result;
  }
}