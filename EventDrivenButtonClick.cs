using System;
                    
public class SearchWindow{

 	public SearchWindow(){
		Action _handlerObj = new Action (_clearButton_Click);
		_clearButton.Click += _handlerObj;
	}

    Button _clearButton=new Button();
    TextBox _searchBox=new TextBox();
    
	public void SimulateClearButtonClick(){
        _clearButton.OnClick();
    }
	
	//Button Click Event Handler
	private void _clearButton_Click(){
		_searchBox.Clear();
	}
}
public class Button{
    
    //Declaring Event  Click
	public event Action Click;
    
	//raising event
    public void OnClick(){
    	if (this.Click != null){
			Click.Invoke();
		}
    }
}
public class TextBox{

 

    public void Clear(){
        Console.WriteLine("TextBox Content Cleared");
    }
}
public class Program
{
    public static void Main()
    {
        SearchWindow _searchWindow=new SearchWindow();
        while(true){
            Console.WriteLine("Press Any Key To Click Clear Button");
            System.Threading.Tasks.Task.Delay(1000).Wait();
            _searchWindow.SimulateClearButtonClick();
        }
    }
}
