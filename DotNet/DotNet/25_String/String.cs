
// String 클래스와 StringBuilder 클래스를 사용하여 문자열 다루기 

using System;
using System.Text;

class StringFunction
{
  static void Main()
  {
    string message = "hello, World!";

    Console.WriteLine(message.ToUpper()); // 대문자
    Console.WriteLine(message.ToLower()); // 소문자

    // 바꾸기
    Console.WriteLine(
        message.Replace("hello", "안녕하세요.").Replace("World", "세계."));
  }
}

class StringClass
{
  static void Main()
  {
    String s1 = "안녕하세요."; // String 클래스
    string s2 = "반갑습니다."; // string 키워드

    Console.WriteLine($"{s1} {s2}");
  }
}

// 문자 배열을 문자열로 변환하기
class CharArrayToString
{
  static void Main()
  {
    char[] charArray = { 'A', 'B', 'C' };

    String str = new String(charArray);

    Console.WriteLine(str); // "ABC"
  }
}


class StringLength
{
  static void Main()
  {
    string s1 = "Hello.";
    string s2 = "안녕하세요.";
    Console.WriteLine($"{s1.Length}, {s2.Length}");
  }
}


// [?] 문자열 연결 : 더하기 연산자, String.Concat() 메서드
class StringConcat
{
  static void Main()
  {
    string s1 = "안녕" + "하세요.";
    string s2 = String.Concat("반갑", "습니다.");
    Console.WriteLine($"{s1} {s2}");
  }
}



// 문자열 묶는 3가지 표현 방법
class StringDisplay
{
  static void Main()
  {
    var displayName = "";
    var firstName = "길동";
    var lastName = "홍";

    //[1] 더하기(+) 연산자 사용
    displayName = "이름: " + lastName + firstName;
    Console.WriteLine(displayName); // 이름: 홍길동

    //[2] string.Format(), String.Format() 메서드 사용
    displayName = string.Format("이름: {0}{1}", lastName, firstName);
    Console.WriteLine(displayName); // 이름: 홍길동

    //[3] 문자열 보간법 사용
    displayName = $"이름: {lastName}{firstName}";
    Console.WriteLine(displayName); // 이름: 홍길동 
  }
}


// 문자열 비교하는 2가지 방법
class StringEquals
{
  static void Main()
  {
    string userName = "RedPlus";
    string userNameInput = "redPlus";

    //[1] == 연산자 사용
    if (userName.ToLower() == userNameInput.ToLower())
    {
      Console.WriteLine("[1] 같습니다.");
    }

    //[2] string.Equals() 메서드 사용
    if (string.Equals(userName, userNameInput,
        StringComparison.InvariantCultureIgnoreCase))
    {
      Console.WriteLine("[2] 같습니다.");
    }
  }
}


// 문자열 값 비교: 대소문자 비교
class StringCompareValue
{
  static void Main()
  {
    string s1 = "Gilbut";
    string s2 = "gilbut";

    //[1] 문자열의 값의 대소문자를 구분
    if (s1 == s2)
    {
      Console.WriteLine("같다.");
    }
    else
    {
      Console.WriteLine("다르다."); // "다르다." 출력됨
    }

    //[2] 문자열의 대소문자를 구분하지 않고 비교 
    if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
    {
      Console.WriteLine("같다."); // "같다." 출력됨
    }
  }
}


// ToCharArray() 메서드로 문자열을 문자 배열로 변환하기
class StringToCharArray
{
	static void Main()
	{
    string s = "Hello";
    char[] ch = s.ToCharArray();
    for (int i=0; i<ch.Length; i++)
		{
      Console.Write($"{ch[i]}\t");
		}
    Console.WriteLine();
	}
}


// Split() 메서드로 문자열 분리하기

class StringSplit
{
  static void Main()
	{
    string src = "Red,Green,Blue";

    //문자열에서 특정 구분자를 사용해 문자열 배열 만들기
    string[] colors = src.Split(',');

    for (int i = 0; i < colors.Length; i++)
		{
      Console.WriteLine(colors[i]);
		}
	}
}


// 문자열의 null값 및 빈 값 체크
class StringIsNullOrEmptyDemo
{
  static void Main()
	{
    var str = "";

    // [1] null 비교와 ""값 비교룰 사용해 처리
    if (str == null || str == "")
		{
      Console.WriteLine($"{ nameof(str)} 변수의 값은 null 또는 빈(Empty)값입니다.");
		}

		// [2] String.IsNullOrEmpty() 메서드를 사용해 처리
		if (string.IsNullOrEmpty(str))
		{
      Console.WriteLine($"{nameof(str)} 변수의 값은 null 또는 빈(Empty)값입니다.");
		}
	}
}


// 문자열 변수에 대한 유효성 검사를 진행하는 3가지 방법 정리
class StringValidation
{
  static void Main()
	{
    //[!] 문자열 유효성 검사
    string userName = "a_b_c";

    //[1] 빈값(Empty)과 널값(null) 확인
    userName = null;
    if(userName != "" && userName != null)
		{
      var s = userName.Split('_'); // null일 떄 에러 발생
		}

    //[2] [1]번과 동일한 표현 방법
    userName = "";
		if (!string.IsNullOrEmpty(userName))
		{
      var s = userName.Split('_');
		}

    //[3] ([1][2]) + "공벡"까지 처리
    userName = " ";
		if (!string.IsNullOrWhiteSpace(userName))
		{
      var s = userName.Split('_');
		}
  }
}


class StringClassNote
{
  static void Main()
  {
    // str 변수에 테스트 문자열 설정
    string str = "";        // 빈 값으로 초기화
    str = String.Empty;     // 빈 값으로 초기화
    str = " Abc Def Fed Cba "; // 앞뒤 공백 한자씩 추가하여 17자

    Console.WriteLine(str); // 전체 문자열 출력
    Console.WriteLine(str.Length); // 17
    Console.WriteLine(str[6 - 1]); // D
    Console.WriteLine(str.ToUpper()); // 대문자
    Console.WriteLine(str.ToLower()); // 소문자

    // 공백 제거 
    Console.WriteLine(str.Trim());      // 양쪽 공백 제거
    Console.WriteLine(str.TrimStart()); // 왼쪽 공백 제거
    Console.WriteLine(str.TrimEnd());   // 오른쪽 공백 제거

    // 변환
    Console.WriteLine(str.Replace("Def", "디이에프"));

    // 메서드 체이닝(체인)
    Console.WriteLine(
        str.Replace("Def", "디이에프").Replace("Fed", "XYZ").ToLower());

    // 검색
    Console.WriteLine(str.IndexOf('e')); // 6번째 인덱스에 위치
    Console.WriteLine(str.LastIndexOf('e')); // 10번째 인덱스에 위치
    Console.WriteLine(str.Substring(5, 3)); // 5번째 인덱스에서부터 3자 반환
    Console.WriteLine(str.Substring(5)); // 5번째이후로 모두 가져오기 
    Console.WriteLine(str.Remove(5, 3)); // 5번째 인덱스에서부터 3자 삭제하고 출력

    // 비교
    Console.WriteLine(str[2 - 1] == str[16 - 1]); // A == a => false
    Console.WriteLine(String.Compare("A", "C")); // 0(같음), 1(다름>), -1(다름<)
    Console.WriteLine("A".CompareTo("C")); // A < C : -1
    Console.WriteLine("Abc".Equals("Abc")); // True
    Console.WriteLine(String.Equals("Abc", "aBC")); // False

    Console.WriteLine("http://www.dotnetkorea.com".StartsWith("http")); // true
    Console.WriteLine("http://www.dotnetkorea.com".EndsWith(".com")); // true

    var hi1 = "안녕";
    var hi2 = "하세요.";

    Console.WriteLine(hi1 + hi2);
    Console.WriteLine(String.Concat(hi1, hi2));
    Console.WriteLine(String.Format("{0} {1} {0}", hi1, hi2));
    Console.WriteLine($"{hi1} {hi2}");

    Console.WriteLine(String.Format("{0:C}", 1000)); // 통화량
    Console.WriteLine(String.Format("{0:#,###}", 1000)); // 세자리 콤마

    string[] strArray = str.Trim().Split(' ');
    foreach (string s in strArray)
    {
      Console.WriteLine($"{s}");
    }
  }
}


// StringBuilder 클래스: 문자열 처리 관련 여러 메서드 제공
class StringBuilderDemo
{
  static void Main()
	{
    //[!] StringBuilder 클래스: 긴 문자열 묶을 때 효과적
    StringBuilder sb = new StringBuilder();

    sb.Append("<script>");
    sb.AppendFormat("window.alert(\"{0}\");", DateTime.Now.Year);
    sb.AppendLine("</script>");

    Console.WriteLine(sb.ToString());
  }
}



// StringBuilder 클래스의 Append() 메서드로 문자열 연결
class StringBuilderClass
{
  static void Main()
	{
    //[1] StringBuilder 클래스의 인스턴스 생성
    StringBuilder sb = new StringBuilder();

    //[2] Append() 메서드로 문자열 추가
    sb.Append("January\n");
    sb.Append("February\n");
    sb.AppendLine("March");

    //[3] ToString() 메서드로 문자열로 출력
    Console.Write(sb.ToString());
  }
}


// 메서드 체이닝으로 StringBuilder 클래스의 여러 메서드 호출하기

class MethodChaining
{
  static void Main()
	{
    var message = new StringBuilder()
      .AppendFormat("{0} 클래스를 사용한 ", nameof(StringBuilder))
      .Append("메서드 ")
      .Append("체이닝 ")
      .ToString()
      .Trim();
    Console.WriteLine(message);
	}
}