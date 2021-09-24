using System;
					
public class Program
{
	public static void Main()
	{
		StringCalculator sc = new StringCalculator();
		Console.WriteLine(sc.add(""));
		Console.WriteLine(sc.add("1"));
		Console.WriteLine(sc.add("1,2"));
		Console.WriteLine(sc.add("1\n2,3"));
		Console.WriteLine(sc.add("hello,\n1,2"));
		Console.WriteLine(sc.add("o"));
		Console.WriteLine(sc.add("2\n1"));
	}
}

public class StringCalculator{
		
	public int add (string numbers){
		if (numbers.Length == 0){
			return 0;
		}
		String[] seperator = {",", "\n"};
		String[] number = numbers.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
		int n, sum = 0;
		foreach (string num in number)
		{
			//Console.WriteLine(num);
			bool isNumber = int.TryParse(num, out n);
			if (isNumber)
				sum += n;
		}
		return sum;
	}
}