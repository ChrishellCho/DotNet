// 컬렉션(Collection): 배열, 리스트, 사전을 사용해 관련 개체의 그룹을 만들고 관리

using System;
using System.Collections;

class ListDemo
{
	static void Main()
	{
		string[] colors = { "red", "green", "blue" };
		Console.WriteLine(colors[0]);
		Console.WriteLine(colors[1]);
		Console.WriteLine(colors[2]);

		Console.WriteLine("요소 수 : {0}", colors.Length);
		for (int i = 0; i<colors.Length; i++)
		{
			Console.WriteLine(colors[i]);
		}
	}
}


class ArraySort
{
	static void Main()
	{
		int[] arr = { 3, 2, 1, 4, 5 };
		Array.Sort(arr); // 오름차순 정렬: 1, 2, 3 순서
		foreach (var item in arr)
		{
			Console.WriteLine(item);
		}
	}
}


class ArrayClassDemo
{
	static void Main()
	{
		int[] arr = { 1, 2, 3 };

		Array.Reverse(arr); // 배열을 역순으로 변환

		foreach (var item in arr)
		{
			Console.WriteLine(item);
		}
	}
}


class ArrayConvertAll
{
	static void Main()
	{
		string[] strArr = { "10", "20", "30" };

		// 문자열 배열을 정수형 배열로 변경
		int[] intArr = Array.ConvertAll(strArr, int.Parse);

		foreach (var number in intArr)
		{
			Console.WriteLine(number);
		}
	}
}


class StackClass
{
	static void Main()
	{
		Stack stack = new Stack();
		stack.Push("First");
		stack.Push("Second");

		Console.WriteLine(stack.Pop());
		Console.WriteLine(stack.Pop());
		// Console.WriteLine(stack.Pop());
	}
}


class StackDemo
{
	static void Main()
	{
		//[1] Stack 개체 만들기 
		Stack stack = new Stack();

		//[2] Push()로 데이터 저장
		stack.Push("닷넷노트");
		stack.Push("닷넷코리아");
		stack.Push("비주얼아카데미");

		//[3] Peek()로 제일 상단(마지막)의 데이터 반환
		Console.WriteLine($"{stack.Peek()}, {stack.Count}");

		//[4] Pop()로 현재 스택의 가장 마지막 데이터 제거
		stack.Pop();

		//[5] 스택의 마지막 데이터 반환: 만약 스택이 비어있을 때에는 에러 발생
		Console.WriteLine($"{stack.Peek()}, {stack.Count}");

		//[6] Count로 스택의 데이터 개수를 확인
		if (stack.Count > 0)
		{
			stack.Pop(); // 가장 마지막 데이터 제거 
			Console.WriteLine($"{stack.Peek()}, {stack.Count}");
		}

		//[7] Clear()로 스택 비우기
		stack.Clear(); // 비우기
		Console.WriteLine($"{stack.Count}");
	}
}


//[?] Queue: FIFO(First In First Out) 형태의 데이터 보관: 대기행렬(은행 줄서기)
// Enqueue(): 큐에 데이터 저장(QueueIn)
// Dequeue(): 큐에서 데이터 출력(QueueOut)

class QueueDemo
{
	static void Main()
	{
		//[1] Queue 클래스의 인스턴스 생성
		var queue = new Queue();

		//[2] 큐(대기행렬)에 데이터 입력: Enqueue()
		queue.Enqueue(10);
		queue.Enqueue(20);
		queue.Enqueue(30);

		//[3] 큐에서 데이터 출력: Dequeue()
		Console.WriteLine(queue.Dequeue()); // 10
		Console.WriteLine(queue.Dequeue()); // 20
		Console.WriteLine(queue.Dequeue()); // 30
	}
}



//[?] Hashtable 클래스를 사용하여 정수 형식 또는 문자열 형식 인덱스 사용하여 값 저장하기
class HashtableDemo
{
	static void Main()
	{
		//[1] Hashtable의 인스턴스 생성
		Hashtable hash = new Hashtable();

		//[2] 배열형 인덱서를 사용 가능한 구조 및 문자열 인덱스 사용 가능
		hash[0] = "닷넷코리아"; //[A] 배열과 같은 n번째 형태 사용 가능
		hash["닉네임"] = "레드플러스"; //[B] 문자열 인덱스 사용 가능
		hash["사이트"] = "비주얼아카데미";

		//[3] 직접 출력
		Console.WriteLine(hash[0]);
		Console.WriteLine(hash["닉네임"]);
		Console.WriteLine(hash["사이트"]);

		//[4] key와 value 쌍으로 출력 가능
		foreach (object o in hash.Keys)
		{
			Console.WriteLine(hash[o]);
		}
	}
}