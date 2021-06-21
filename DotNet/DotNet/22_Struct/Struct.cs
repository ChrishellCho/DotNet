using System;
using System.Collections.Generic;
using System.Text;


struct Point
{
	// Access Modifier (엑세스 한정자)
	public int X; // public(공용)
	public int Y;
	private int Z; // private(전용)
}

namespace DotNet._22_Struct
{
	class Struct
	{
		static void Main()
		{
			Point point;
			point.X = 100;
			point.Y = 200;
			System.Console.WriteLine($"{point.X}, {point.Y}");
		}
		//var days = Math.Ceiling((DateTime.Now - (new DateTime(2020, 1, 1))).TotalDays);
		//days


		static void DateTimeDemo()
		{
			//[1] 현재 시간 출력: DateTime 구조체
			Console.WriteLine($"현재 시간: {DateTime.Now}");

			//[2] 년, 월, 일, 시, 분, 초 출력
			Console.WriteLine(DateTime.Now.Year);
			Console.WriteLine(DateTime.Now.Month);
			Console.WriteLine(DateTime.Now.Day);
			Console.WriteLine(DateTime.Now.Hour);
			Console.WriteLine(DateTime.Now.Minute);
			Console.WriteLine(DateTime.Now.Second);
			Console.WriteLine(DateTime.Now.Millisecond);

			//[3] DateTime 형식의 변수 선언 후 속성 또는 메서드 호출
			DateTime now = DateTime.Now;
			Console.WriteLine(now.Date);
			Console.WriteLine(now.ToLongTimeString());
		}


		static void TimeSpanDemo()
		{
			// 시간차(D-Day) 구하기: TimeSpan 구조체
			TimeSpan dday = Convert.ToDateTime("2018-12-25") - DateTime.Now;
			Console.WriteLine(
					$"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");

			// 지난 시간 구하기
			TimeSpan times = DateTime.Now - Convert.ToDateTime("2005-05-27");
			Console.WriteLine($"내가 지금까지 며칠 살아왔는지? {(int)times.TotalDays}");
		}

		static void GuidDemo()
		{
			string unique = Guid.NewGuid().ToString();
			Console.WriteLine($"유일한 값: {unique}");

			Console.WriteLine($"유일한 값: {Guid.NewGuid().ToString("D")}");
		}
	}
}
	
	