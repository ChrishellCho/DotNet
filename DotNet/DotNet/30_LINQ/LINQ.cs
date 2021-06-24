// Language INtegrated Query
// LINQ: C# 언어에 직접 쿼리(Query) 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class LinqSum
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3 };
		int sum = numbers.Sum();
		Console.WriteLine($"numbers 배열 요소의 합: {sum}");
	}
}

class LinqCount
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3 };

		int count = numbers.Count();

		Console.WriteLine($"{nameof(numbers)} 배열 개수: {count}");
	}
}

class LinqAverage
{
	static void Main()
	{
		int[] numbers = { 1, 3, 4 };

		double average = numbers.Average();

		Console.WriteLine($"{nameof(numbers)} 배열 요소의 평균: {average:#,###.##}");
	}
}

class MinAndMax
{
	static void Main()
	{
		int[] arr = { 1, 2, 3 };
		int min = arr.Min();
		int max = arr.Max();

		Console.WriteLine($"최솟값: {min}, 최댓값: {max}");
	}
}


class LinqWhere
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3, 4, 5 };

		IEnumerable<int> newNumbers = numbers.Where(number => number > 3);

		foreach (var n in newNumbers)
		{
			Console.WriteLine(n);
		}
	}
}

class LinqWhereToList
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3, 4, 5 };

		List<int> newNumbers = numbers.Where(number => number > 3).ToList();

		foreach (var number in newNumbers)
		{
			Console.WriteLine(number);
		}
	}
}

class LinqSumEven
{
	static void Main()
	{
		var numbers = new List<int> { 1, 2, 3 };

		int sum = numbers.Where(number => number % 2 == 0).Sum();

		Console.WriteLine($"{nameof(numbers)} 배열 요소 중 짝수의 합: {sum}");
	}
}

class LinqSumOdd
{
	static void Main()
	{
		var numbers = new List<int> { 1, 2, 3 };

		int sum = numbers.Where(n => n % 2 == 1).Sum();

		Console.WriteLine($"{nameof(numbers)} 배열 요소 중 홀수의 합: {sum}");
	}
}

class LinqWhereMethod
{
	static void Main()
	{
		int[] arr = { 1, 2, 3, 4, 5 };

		// 배열에서 홀수만 추출: 람다 식 사용
		var q = arr.Where(num => num % 2 == 1);

		foreach (var n in q)
		{
			Console.WriteLine(n); // 1, 3, 5
		}
	}
}


class Filter
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3, 4, 5 };

		// Where() 확장 메서드를 사용한 필터링
		var nums = numbers.Where(it => it % 2 == 0 && it > 3); // 짝수 && 3보다 큰

		foreach (var num in nums)
		{
			Console.WriteLine(num);
		}
	}
}

class CountFunc
{
	static void Main()
	{
		bool[] blns = { true, false, true, false, true };

		Console.WriteLine(blns.Count()); // 5
		Console.WriteLine(blns.Count(bln => bln == true)); // 3
		Console.WriteLine(blns.Count(bln => bln == false)); // 2
	}
}


// All() 확장 메서드: 시퀀스의 모든 요소가 조건을 만족 하는지 여부
class LinqAll
{
	static void Main()
	{
		bool[] completes = { true, true, true };

		// 배열 또는 컬렉션의 모든 항목이 true일때에만 true을 반환
		Console.WriteLine(completes.All(c => c == true));
	}
}

// Any() 확장 메서드: 시퀀스의 하나의 요소라도 조건을 만족 하는지 여부
class LinqAny
{
	static void Main()
	{
		bool[] completes = { true, false, true };

		// 배열 또는 컬렉션의 하나의 항목이라도 조건을 만족하면 true
		Console.WriteLine(completes.Any(c => c == false));
	}
}

// LINQ Take(): 컬렉션(시퀀스)에서 지정한 수만큼의 테이터 가져오기
class LinqTake
{
	static void Main()
	{
		var data = Enumerable.Range(0, 100); // 0~99

		Console.WriteLine("앞에서 5개:");
		var five = data.Take(5); // 앞에서 5개
		foreach(var f in five)
		{
			Console.Write("{0}\t", f);
		}
		Console.WriteLine("\n짝수 5개: ");
		var even = data.Where(n => n % 2 == 0).Take(5); // 짝수 5개
		foreach(var e in even)
		{
			Console.Write("{0}\t", e);
		}
		Console.WriteLine();
	}
}

// LINQ Skip(): 컬렉션(시퀀스)에서 지정한 수만큼의 데이터 제외하기 
class LinqSkipTake
{
	static void Main()
	{
		var data = Enumerable.Range(0, 100); // 0~99

		var next = data.Skip(10).Take(5); // 10개 제외하고 5개 가져오기

		foreach (var n in next)
		{
			Console.WriteLine(n);
		}
	}
}

// LINQ Distinct(): 컬렉션(시퀀스)에서 중복 제거
class LinqDistinct
{
	static void Main()
	{
		var data = Enumerable.Repeat(3, 5); // 3을 5개 저장
		var result = data.Distinct(); // Distinct()로 중복 제거
		foreach (var num in result)
		{
			Console.Write("{0}\t", num);
		}
		Console.WriteLine();

		int[] arr = { 2, 2, 3, 3, 3 }; // 2와 3을 중복해서 배열에 저장
		var r = arr.Distinct();
		foreach (var num in r)
		{
			Console.Write($"{num}\t"); // 2와 3만이 중복이 제거되어 출력
		}
		Console.WriteLine();
	}
}



// 확장 메서드 체이닝
class LinqChaining
{
	static void Main()
	{
		List<string> names = new List<string> { ".NET", "C#", "TypeScript" };

		// 체이닝: 확장 메서드를 여러 개 사용
		var results = names.Where(name => name.Length > 2).OrderBy(n => n);

		foreach (var name in results)
		{
			Console.WriteLine(name);
		}
	}
}


class Map
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3, 4, 5 };

		// Select() 확장 메서드를 사용하여 새로운 형태로 가공
		var nums = numbers.Select(it => it * it);

		foreach (var num in nums)
		{
			Console.WriteLine(num);
		}
	}
}

// LINQ Zip() 확장 메서드: 관련있는 2개의 시퀀스(컬렉션)를 묶어서 출력
class LinqZip
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3 };
		string[] words = { "하나", "둘" };

		var numbersAndWords = numbers.Zip(words, (first, second) => first + "-" + second);

		foreach(var item in numbersAndWords)
		{
			Console.WriteLine(item); // 1-하나, 2-둘
		}
	}
}