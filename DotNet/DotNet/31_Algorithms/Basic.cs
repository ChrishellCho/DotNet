using System;


namespace DotNet._31_Algorithms
{
	public class 합계
	{
		public static void Main()
		{
			//[1] Input : n명의 국어 점수로 가정
			int[] score = { 100, 75, 47, 36, 90, 95 };
			int sum = 0;
			//[2] Process : Sum : 주어진 범위에 주어진 조건
			for (int i = 0; i < score.Length; i++)
			{
				if (score[i] >= 80)
				{
					sum += score[i];
				}
			}
			//[3] Output
			Console.WriteLine($"{0}명의 점수 중 80점 이상의 총점 : {1}", score.Length, sum);
		}
	}

	public class 카운트
	{
		public static void Main()
		{
			//[1] Input
			int[] data = { 10, 9, 8, 7, 6, 7, 4};
			int count = 0;
			//[2] Process : COUNT
			for (int i=0; i < data.Length; i++)
			{
				if (data[i] % 2 == 0)
				{
					count++;
				}
			}
			//[3] Output
			Console.WriteLine("짝수의 건수 : {0}", count);
		}
	}

	public class 평균
	{
		public static void Main()
		{
			//[1] 입력
			int[] data = { 50, 65, 78, 90, 95 };
			int sum = 0;
			int count = 0;
			double avg = 0.0;
			//[2] 처리
			for(int i = 0; i < data.Length; i++)
			{
				if (data[i] >= 80 && data[i] <= 95)
				{
					sum += data[i];
					count++;
				}
			}
			avg = sum / (double)count; //캐스팅(형식변환) 필요 : 3 -> 3.0
			//[3] 출력
			Console.WriteLine("80점 이상 95점 이하인 자료의 평균 : {0}", avg);
		}
	}

	public class 최댓값
	{
		public static void Main()
		{
			//[1] Init
			int max = Int32.MinValue; // 정수형 데이터 중 작은 값으로 초기화
			//[2] Input
			int[] data = { -2, -3, -5, -7, -1 };
			//[2] Process
			for (int i =0; i < data.Length; i++)
			{
				if (data[i] > max)
				{
					max = data[i]; //MAX
				}
			}
			//[4] Output
			Console.WriteLine("최댓값: {0}", max);
			//[5] Dispose
			max = 0;
		}
	}

	public class 최솟값
	{
		public static void Main()
		{
			//[1] Init
			int min = Int32.MaxValue;
			//[2] input
			int[] data = { -2, -5, -3, -7, -1 };
			//[3] Process : MIN
			for (int i =0; i <data.Length; i++)
			{
				if (data[i] < min)
				{
					min = data[i]; // MIN
				}
			}
			//[4] Output
			Console.WriteLine("최솟값 : {0}", min);
			//[5] Dispose
			min = 0;
		}
	}
	
	public class 가까운값
	{
		public static void Main()
		{
			//[1] Input
			int[] data = { 10, 20, 30, 27, 17 };
			int target = 25;
			int near = 0;
			int min = Int32.MaxValue;
			//[2] Process : NEAR
			for (int i =0; i <data.Length; i++)
			{
				if(Abs(data[i]-target)< min)
				{
					min = Abs(data[i] - target);
					near = data[i];
				}
			}
			//[3] Output
			Console.WriteLine("{0}와 가까운값 : {1}", target, near);
		}
		public static int Abs(int num)
		{
			return (num < 0) ? -num : num;
		}
	}
}
	