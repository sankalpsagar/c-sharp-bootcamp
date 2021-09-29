using System;
					
public abstract class Document{
	Pages p = new Pages();
}

public class Header{
}

public class Footer{
}

public class Text{
}

public class Heading{
}

public class Pages{
	Header head = new Header();
	Footer f = new Footer();
	Text t = new Text();
	Heading h = new Heading();
}

public class MSWord : Document{
	public MSWord(){
		Console.WriteLine("New document started!");
	}
}

public class Program{
	public static void Main (String[] args){
		MSWord ms = new MSWord();
	}
}
