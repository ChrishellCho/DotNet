using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Convert;


namespace DotNet._13_IfElse
{
	class IfElse
	{
    static void Sequence()
		{
      int kor = 100;
      int eng = 90;

      int tot = 0;
      double avg = 0.0;

      tot = kor + eng; // 총점 구하기
      avg = tot / 2.0; // 평균 구하기 

      Console.WriteLine("총점: {0}", tot);
      Console.WriteLine("평균: {0:F1}", avg);
    }

    static void SingleMultiple()
		{
      //[1] 단문: 3가지 스타일
      if (1 == 1) Console.WriteLine("단문 1");
      if (1 == 1)
        Console.WriteLine("단문 2");
			if (1 == 1)
			{
        Console.WriteLine("단문 3");
			}

			//[2] 복문: 반드시 중괄호 사용
			if (1 == 1)
			{
        Console.WriteLine("복문 a");
			}
		}

    static void ConvertClass()
		{
        //[1] Convert.ToXXX()
        WriteLine(ToInt32(3.14)); // 3
        WriteLine(ToDouble("3.14")); // 3.14
        WriteLine(Convert.ToString(3.14)); // 3.14 => "3.14"
        WriteLine(Convert.ToString(3.14).GetType()); // "String"
        WriteLine(3.14.ToString()); // 3.14 => "3.14"

        //[2] XXX.TryParse(,)
        if (double.TryParse("3.14", out var r))
        {
            WriteLine($"{r}: {r.GetType()}"); // 3.14: System.Double
        }
        else
        {
            WriteLine("변환 불가");
        }
        Console.WriteLine(r); // if 문에서 생성된 r 값을 사용 가능
		}

    static void TryParse()
		{
      string data = "1234";

      int result;
      if (int.TryParse(data, out result))
      {
        Console.WriteLine("변환 가능: {0}", result);
      }
      else
      {
        Console.WriteLine("변환 불가");
      }

      double d;
      if (Double.TryParse(data, out d))
      {
        Console.WriteLine("변환 가능: {0}", d);
      }
    }
	}
}
