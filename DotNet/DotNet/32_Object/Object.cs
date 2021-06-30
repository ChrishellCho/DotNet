// 개체(Object, 오브젝트): 설계도인 클래스로부터 만들어진 하나의 인스턴스(실체, 구성 요소)

using System;

//[1] ClassCode 이름의 클래스(Class) 만들기
public class ClassCode
{
	// Empty
}

class ClassAndObject
{
	static void Main()
	{
		//[2] 특정 클래스로부터 objectCode1, objectCode2 이름의 개체(object) 만들기
		ClassCode objectCode1 = new ClassCode();
		Console.WriteLine(objectCode1.GetHashCode());
		var objectCode2 = new ClassCode();
		Console.WriteLine(objectCode2.GetHashCode());
	}
}


// ObjectNote
namespace ObjectNote
{
	// [1] 클래스 생성
	public class Counter
	{
		//[2] 메서드(인스턴스 멤버) 생성
		public void GetTodayVisitCount()
		{
			Console.WriteLine("오늘 1234명이 접속했습니다.");
		}
	}
	class ObjectNote
	{
		static void Main()
		{
			//[A] 클래스의 인스턴스 생성
			Counter counter = new Counter();
			//[B] 개체(인스턴스) 이름, 멤버이름으로 클래의 멤버 호출
			counter.GetTodayVisitCount();
		}
	}
}


//[?] 인스턴스 메서드 만들기
namespace ClassMethod
{
	public class MyMath
	{
		//[1] 인스턴스 메서드 생성
		public void Sum(int x, int y)
		{
			int sum = x + y;
			Console.WriteLine($"합계:{sum}");
		}
	}
	public class ClassMethod
	{
		public static void Main()
		{
			//[2] MyMath 클래스의 인스턴스 생성
			MyMath myMath = new MyMath();
			//[3] 개체.인스턴스메서드이름 형태로 호출
			myMath.Sum(3, 5);
		}
	}
}


//[?] 익명 형식(Anonymous Type): 클래스 없이 개체를 만드는 방법
class ObjectDemo
{
	static void Main()
	{
		//[1] 개체(object) 만들기 : 익명 형식(Anonymous Type)
		var hong = new { Name = "홍길동", Age = 21 };
		var park = new { Name = "박문수", Age = 30 };

		//[2] 개체 사용하기
		Console.WriteLine($"이름: {hong.Name}, 나이: {hong.Age}");
		Console.WriteLine($"이름: {park.Name}, 나이: {park.Age}");
	}
}


//[?] 정적(Static,Shared) 멤버와 인스턴스(Instance) 멤버
namespace StaticAndInstance
{
	//[1] 클래스 생성
	class SharedAndInstance
	{
		//[1][1] static(shared) 멤버
		public static void StaticMember() => Console.WriteLine("[1] Static Member");

		//[1][2] instance 멤버
		public void InstanceMember() => Console.WriteLine("[2] Instance Member");
	}

	class StaticAndInstance
	{
		static void Main()
		{
			//[2] 클래스 사용
			//[2][1] 정적 멤버 사용
			SharedAndInstance.StaticMember(); // 정적 멤버 => 클래스.멤버 형태

			//[2][2] 인스턴스 멤버 사용
			SharedAndInstance obj = new SharedAndInstance();
			obj.InstanceMember(); // 인스턴스 멤버 => 개체.멤버 형태
		}
	}
}


//[!] 메인 클래스: ClassOne과 ClassTwo 클래스를 사용
	class ClassDemo
	{
		static void Main()
		{
			//[!] 다른 클래스의 멤버 호출
			//[a] 스태틱 멤버 호출
			ClassOne.Hi();  // "안녕하세요." 출력
			ClassTwo.Hi();  // "반갑습니다." 출력

			//[b] 인스턴스 멤버 호출: 클래스의 인스턴스 생성 => 개체(객체)
			ClassTwo ct = new ClassTwo();
			ct.Hello();     // "또 만나요." 출력
		}
	}
	//[1] ClassOne 클래스
	public class ClassOne
	{
		// 정적(static) 메서드: 클래스명.메서드명();
		public static void Hi()
		{
			Console.WriteLine("안녕하세요.");
		}
	}
	//[2] ClassTwo 클래스
	public class ClassTwo
	{
		// 정적(static) 멤버
		public static void Hi()
		{
			Console.WriteLine("반갑습니다.");
		}

		// 인스턴스(instance) 멤버: static 없는 인스턴스 메서드
		public void Hello()
		{
			Console.WriteLine("또 만나요.");
		}
	}


// 특정 클래스 형식의 배열을 선언 후 각 배열의 인스턴스 생성 후 사용

public class CategoryClass
{
	public void Print(int i) => Console.WriteLine($"카테고리 {i}");
}

class ClassArray
{
	static void Main()
	{
		//[1] 클래스 배열 생성
		CategoryClass[] categories = new CategoryClass[3];
		//[2] 각각의 요소에 인스턴스 생성
		categories[0] = new CategoryClass();
		categories[1] = new CategoryClass();
		categories[2] = new CategoryClass();
		for (int i=0; i<categories.Length; i++)
		{
			categories[i].Print(i);
		}
	}
}


//InstanceWithVar
public class ExamClass { }

class OnstanceWithVar
{
	static void Main()
	{
		//[1] 클래스를 사용하기 위해 인스턴스 생성
		ExamClass exam1 = new ExamClass(); //기본 방식
		Console.WriteLine($"{exam1}");
		//[2] var 키워드를 사용해 인스턴스 생성
		var exam2 = new ExamClass(); //축약 방식
		Console.WriteLine($"{exam2}");
	}
}


//ClassPass
namespace ClassPass
{
	// 클래스 선언: 설계도
	class Car
	{
		// Empty
	}

	class ClassPass
	{
		static void Main()
		{
			//[1] 개체 선언: 클래스의 인스턴스 생성: (예)자동차 설계도로부터 하나의 자동차 생성
			Car car1 = new Car();
			//[2] 개체의 GetHashCode 메서드로 고유 키 값 출력
			Console.WriteLine(car1.GetHashCode());

			Car car2 = new Car();
			Console.WriteLine(car2.GetHashCode());
		}
	}
}