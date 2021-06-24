// null : 아무 것도 없음을 의미하는 리터럴, 개체가 아무 것도 참조하지 않음을 null 참조라 함
// null : 아무런 가치가 없음. 참조형 변수에 아무런 값을 설정하지 않음

using System;
using static System.Console;
using System.Collections.Generic;

class NullDemo
{
  static void Main()
  {
    int i = 0;              // 값형(Value Type)
    string s = null;        // 참조형(Reference Type)
    s = "안녕하세요.";
    string empty = "";      // 빈값(Empty)은 null과는 다름

    WriteLine(i);           // 0
    WriteLine(s);           // null -> "안녕하세요."
    WriteLine(empty);       // ""
  }
}


class NullableOf
{
  static void Main()
	{
    //Nullable<T> 구조체를 사용해 널 가능 형식 변수 만들기
    Nullable<bool> bin = null;

    if(bin.HasValue == true)
		{
      Console.WriteLine($"bin 변수의 값은 {bin.Value}입니다.");
		}
		else
		{
      Console.WriteLine("bin 변수의 값은 null입니다.");
		}
	}
}


// Nullable 형식 : null(값이 없음을 의미)이 할당될 수 있는 형식
// 널가능형식, 널가능자 (값타입 뒤에 ? 붙이면 => nullable 형식이다)

public class NullableTypeDemo
{
  static void Main()
	{
    // 참조 형식 : null 할당 가능
    string s = null;
    Console.WriteLine(s);

    // 값 형식 : null 할당 불가능 -> 에러
    // int i = null; Console.WriteLine(i);

    // Nullable 형식 : null 할당할 수 있는 형식
    int? i = null;
    Console.WriteLine(i);
    double? d = null;
    Console.WriteLine(d);

    // System.Nullable<T> 제네릭 클래스: int?, double? 사용을 권장함
    Nullable<int> ii = null;
    Console.WriteLine(ii);
    Nullable<double> dd = null;
    Console.WriteLine(dd);
	}
}


// 널 병합 연사자 : ??
class NullableTypeCheck
{
  static void Main()
	{
    int? x = null;
    int y = x ?? 100;
    int z = x ?? default(int);

    Console.WriteLine($" y: {y}, z: {z}"); // y: 100, z:0
	}
}


class NullableTypes
{
  static void Main()
	{
    bool? unknown = null;
    if (unknown ?? true) Console.WriteLine("출력됨");
    unknown = false;
    if (!unknown ?? false) Console.WriteLine("출력됨");
	}
}


// 널 조건부 연산자(Null Conditional)
class QuestionMarkDot
{
  static void Main()
  {
		double? d = null;
    d?.ToString();

		//null

		//double? d = 1.0;
  //  d?.ToString();

		////"1"

		//double? d = 1.0;
  //  d?.ToString("#.00");

		////"1.00"

	}
}


// 널 조건부 연산자 (Null Conditional Operator);
class NullConditional
{
  static void Main()
	{
    int? len;
    string message;

    message = null;
    len = message?.Length;
		if (len == null)
		{
			Console.WriteLine( "[1] massage는 null입니다.");
		}

    message = "안녕";
    len = message?.Length;
    if(len != null)
		{
			Console.WriteLine( $"[2] message는 {len}자입니다.");
		}
	}
}


// ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환
// ?. 연산자는 엘비스의 머리 모양과 비슷하다고 하여 Elvis 연산자라고도 함
class NullConditionalWirhCollection
{
  static void Main()
	{
    List<string> list = null;
    int? numberOfList;

    //[1] 리스트가 null이면 null 반환
    numberOfList = list?.Count;
    if (numberOfList == null)
		{
			Console.WriteLine($"[1] 리스트 카운트: null");
		}

    list = new List<string>();
    list.Add("안녕하세요."); list.Add("반갑습니다.");

    //[2] 리스트가 null이 아니므로 Count 속성의 값인 2 반환
    numberOfList = list?.Count;
    if (numberOfList != null)
		{
			Console.WriteLine($"[2] 리스트 카운트: {numberOfList}");
		}
	}
}


// 널 병합 연산자와 널 조건부 연산자 함께 사용하기 
// ?? 연산자: 컬렉션이 null이 아니면 해당 값 반환, null이면 뒤에 지정한 값 반환
// ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환
class NullCoalescingWithCollection
{
  static void Main()
  {
    int num;
    List<string> list;

    //[1] 컬렉션 리스트가 null이면 Count를 읽을 수 없기에 0으로 초기화
    list = null;
    num = list?.Count ?? 0; // null이면 0 반환, 오른쪽 값 사용
    Console.WriteLine($"[1] 컬렉션 카운트: {num}"); // 0

    //[2] 컬렉션 리스트가 null이 아니면 Count 속성의 값을 사용 
    list = new List<string>(); list.Add("또 만나요.");
    num = list?.Count ?? 0; // null이 아니기 때문에 왼쪽 값 사용
    Console.WriteLine($"[2] 컬렉션 카운트: {num}"); // 1
  }
}