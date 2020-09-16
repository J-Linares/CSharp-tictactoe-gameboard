using System;
using System.Windows.Forms;
public class mytictactoemain
{ public static void Main()
	{  
		System.Console.WriteLine("The Shapes Graphical program will now begin. ");
		mytictactoeframe tictactoeapplication = new mytictactoeframe();
		Application.Run(tictactoeapplication);
		System.Console.WriteLine("This Graphical program is ending. Good Bye. ");
	}
}
