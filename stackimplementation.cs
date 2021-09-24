using System;
					
public class Program
{
	public static void Main()
	{
		Stack s = new Stack();
		s.push(10);
		s.push(20);
		s.push(30);
		Console.WriteLine(s.pop());
		Console.WriteLine(s.pop());
		Console.WriteLine(s.pop());
		Console.WriteLine(s.pop());
	}
}

public class Stack{
	int max = 1000;
	int[] stack;
	int top;
	
	public Stack(){
		this.stack = new int[max];
		this.top = -1;
	}
	
	public bool isEmpty(){
		return (top<0);
	}
	
	public bool push (int data){
		if (top >= max){
			Console.WriteLine("Stack Overflow");
			return false;
		}
		else{
			stack[++top] = data;
			return true;
		}
	}
	
	public int pop (){
		if (top<=-1){
			Console.WriteLine("Stack Underflow");
			return -1;
		}
		else{
			int value = stack[top--];
			return value;
		}
	}
}