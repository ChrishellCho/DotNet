// 제네릭: Cup<T>를 Cup of T로 발음하여 형식 매개 변수인 T에 따른 Cup 클래스의 개체 생성

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class StackOfType
{
	static void Main()
	{
		Stack<string> stack = new Stack<string>();
		stack.Push("First"); // Push() 메서드는 문자열만 입력 가능
		Console.WriteLine(stack.Pop()); // 문자열로 바로 출력
	}
}


/// <summary>
/// 제네릭 클래스 사용의 장점
/// </summary>
class GenericPros
{
  static void Main()
  {
    //[1] 제네릭 사용 전
    Stack s1 = new Stack();
    s1.Push(1234);
    int i1 = (int)s1.Pop(); // Convert 필요
    Console.WriteLine(i1);

    //[2] 제네릭 사용 후
    Stack<int> s2 = new Stack<int>();
    s2.Push(2345);
    int i2 = s2.Pop(); // Convert 필요없음
    Console.WriteLine(i2);

    //[3] 제네릭의 장점: 형식 안정성과 성능 향상
    //[A] 장점 1: 타입 안정성
    Stack o = new Stack();
    o.Push(1234);
    o.Push("Hello");
    Console.WriteLine(o.Pop());
    Console.WriteLine(o.Pop());

    Stack<int> i = new Stack<int>();
    i.Push(1234);
    //i.Push("Bye"); // 컴파일 타임 에러
    Console.WriteLine(i.Pop());

    //[B] 장점 2: 성능 향상
    Stack stack = new Stack();
    stack.Push(1234); // 1234(값형) to object(참조형): 박싱(Boxing): 포장
    int iStack = (int)stack.Pop(); // 참조형 to 값형: 언박싱(UnBoxing): 포장 풀기
    Console.WriteLine(iStack);
  }
}


// 제네릭 리스트 : 배열과 제네릭 리스트
class ListOfInt
{
  static void Main()
  {
    //[1] 배열 사용
    int[] arrNumbers = new int[2];
    arrNumbers[0] = 10;
    arrNumbers[1] = 20;
    for (int i = 0; i < arrNumbers.Length; i++)
    {
      Console.WriteLine(arrNumbers[i]); // 10, 20
    }

    //[2] 제네릭 리스트 사용: List<T>
    List<int> lstNumbers = new List<int>();
    lstNumbers.Add(30);
    lstNumbers.Add(40);
    for (int i = 0; i < lstNumbers.Count; i++)
    {
      Console.WriteLine(lstNumbers[i]); // 30, 40
    }
  }
}


// 리스트 제네릭 클래스: List<T> => List<int>, List<string>, List<object>
class ListOfString
{
  static void Main()
  {
    //[0] 제네릭 리스트 사용을 위한 인스턴스 생성 및 샘플 데이터 입력
    List<string> colors = new List<string>();
    colors.Add("Red");
    colors.Add("Green");
    colors.Add("Blue");

    //[1] for 문으로 출력 예
    for (int i = 0; i < colors.Count; i++)
    {
      Console.Write($"{colors[i]}\t");
    }
    Console.WriteLine();

    //[2] foreach 문으로 출력 예
    foreach (var color in colors)
    {
      Console.Write($"{color}\t");
    }
    Console.WriteLine();
  }
}


class EnumerableDemo
{
  static void Main()
  {
    // 1부터 5까지
    var numbers = Enumerable.Range(1, 5);
    foreach (var n in numbers)
      Console.Write("{0}\t", n);
    Console.WriteLine();

    // -1을 5개
    var sameNumbers = Enumerable.Repeat(-1, 5);
    foreach (var n in sameNumbers)
      Console.Write("{0}\t", n);
    Console.WriteLine();
  }
}


class DictionaryGenericClassDemo
{
  static void Main()
  {
    //[1] Dictionary 클래스의 인스턴스 생성: IDictionary 인터페이스로 받기
    IDictionary<string, string> data = new Dictionary<string, string>();

    //[2] 데이터 입력
    data.Add("cs", "C#");
    data.Add("aspx", "ASP.NET");

    //[3] 데이터 삭제
    data.Remove("aspx");

    //[4] 인덱서를 사용해서 데이터 입력
    data["cshtml"] = "ASP.NET MVC";

    //[5] 키 값 중복 불가: 에러 발생
    try
    {
      data.Add("cs", "CSharp");
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    //[6] 출력: foreach (var item in data)로 줄여 표현 가능
    foreach (KeyValuePair<string, string> item in data)
    {
      Console.WriteLine("{0}은(는) {1}의 확장자입니다.", item.Key, item.Value);
    }

    //[7] 인덱서를 사용해서 출력 가능
    Console.WriteLine(data["cs"]);

    //[8] 없는 키 요청: 에러 발생
    try
    {
      Console.WriteLine(data["vb"]);
    }
    catch (KeyNotFoundException knfe) 
    {
      Console.WriteLine(knfe.Message);
    }

    //[9] cs 키가 있으면 csharp 변수에 담아서 출력 
    if (data.TryGetValue("cs", out var csharp))
    {
      Console.WriteLine(csharp);
    }
    else
    {
      Console.WriteLine("cs 키가 없습니다.");
    }

    //[10] 키 값이 없으면 입력하고 출력
    if (!data.ContainsKey("json"))
    {
      data.Add("json", "JSON");
      Console.WriteLine(data["json"]);
    }

    //[11] Value 값을 따로 뽑아서 출력
    var values = data.Values;
    foreach (string item in values)
    {
      Console.WriteLine(item);
    }

    //[12] Key 값을 따로 뽑아서 출력
    var keys = data.Keys;
    foreach (string item in keys)
    {
      Console.WriteLine(item);
    }
  }
}