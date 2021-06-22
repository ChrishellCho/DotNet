using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet._24_Class
{

	struct Point { public int X; public int Y; }
	class Class
	{
	}

  class ClassNote
  {
    static void Run()
    {
      Console.WriteLine("ClassNote 클래스의 Run 메서드");
    }

    static void Main()
    {
      Run(); //[1] 메서드 레벨: 같은 클래스의 메서드 호출
      ClassNote.Run(); //[2] 클래스 레벨: 클래스.메서드() 형태로 호출
    }
  }


  //[1] Square.cs
  public class Square
  {
    public static string GetName()
    {
      return "정사각형";
    }
  }

  //[2] SquareClass.cs 
  class SquareClass
  {
    static void Main()
    {
      // Square 클래스의 정적(static) 멤버인 GetName() 메서드 호출
      string square = Square.GetName();
      Console.WriteLine(square); // 정사각형
    }
  }
}
