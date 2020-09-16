using System;
using System.Drawing;
using System.Windows.Forms;


public class mytictactoeframe : Form
{  
   private const int formwidth = 900;                 //test sizes for the box that houses the game
   private const int formheight = 900;                 // 900x900 size screen to fit in a square
   private const int penwidth = 5;
   private Label title = new Label();
   private Button new_game_button = new Button();    // create button to clear board
   private Button exit_button = new Button();        // create button to exit from the program
   private Pen ballpointpen1 = new Pen(Color.Blue,penwidth);  // pen used to draw out icons
   private Point location_title = new Point(375,20);     
   private Point location_new_game = new Point(650,820);          
   private Point location_exit = new Point(750,820);
   private RadioButton player_1 = new System.Windows.Forms.RadioButton();      //button selections for switch player
   private RadioButton player_2 = new System.Windows.Forms.RadioButton();
   private GroupBox players = new GroupBox();   //create group box to handle both players
   
   //private int cursor_x = 0;// mouse coordinates
   //private int cursor_y = 0;// mouse coordinates
   
   //private bool x_1 =false;      //we will attempt to have theshapes pre drawn 
   //private bool x_2 =false;      // so that they will activate by a mixture of boolean
   //private bool x_3 =false;      //values that are set by the group box
   //private bool x_4 =false;
   //private bool x_5 =false;
   //private bool x_6 =false;
  // private bool x_7 =false;
  // private bool x_8 =false;
  // private bool x_9 =false;
   
  // private bool o_1 =false;
  // private bool o_2 =false;
  // private bool o_3 =false;
  // private bool o_4 =false;
  // private bool o_5 =false;
  // private bool o_6 =false;
  // private bool o_7 =false;
  // private bool o_8 =false;
  // private bool o_9 =false;
   
   public mytictactoeframe()
   { 
      
      Size = new Size(formwidth,formheight);

      Text = "Tic-Tac-Toe";                             // initialize title
      BackColor = Color.Black;
      title.Text = "Tic Tac Toe by Juan Linares";
      title.Size = new Size(170,20);
      title.Location = location_title;
      title.BackColor = Color.Red;

      new_game_button.Text = "New Game";                 //button for new game is created and placed here
      new_game_button.Size = new Size(85,25); 
      new_game_button.Location = location_new_game;
      new_game_button.BackColor = Color.White;

      exit_button.Text = "Exit";                           // button to terminate program
      exit_button.Size = new Size(85,25);
      exit_button.Location = location_exit;
      exit_button.BackColor = Color.White;

      //initialize radiobuttons
      player_1.Text = "Player_X";
      player_1.Size = new System.Drawing.Size(60,16);          //player one is assigned X
     // player_1.BackColor = Color.Green;
      player_2.Text = "Player_O";
      player_2.Size = new System.Drawing.Size(60,16);          //player two is assigned O
     // player_2.BackColor = Color.Green;
      
      //initialize group that contains the radiobuttons
      players.Text = "Players";
      players.Size = new System.Drawing.Size(210,42);
      players.Location = new System.Drawing.Point(90,800);
      players.BackColor = Color.Yellow;
      
      players.Controls.Add(player_1);
      player_1.Location = new System.Drawing.Point(10,16);
      players.Controls.Add(player_2);
      player_2.Location = new System.Drawing.Point(130,16); 


      Controls.Add(title);
      Controls.Add(players);
      Controls.Add(new_game_button);
      Controls.Add(exit_button);
      

     // player_1.Click += new EventHandler(player_1_turn);
     // player_2.click += new EventHandler(player_2_turn);
     // new_game_button.Click += new EventHandler(reset_game);
      exit_button.Click += new EventHandler(close_game);
   } // end of constructor   
    
   protected override void OnPaint(PaintEventArgs ee)
    {
      Graphics graph = ee.Graphics;

     graph.DrawLine(ballpointpen1,0,300,900,300);
     graph.DrawLine(ballpointpen1,0,550,900,550);
     graph.DrawLine(ballpointpen1,300,0,300,900);
     graph.DrawLine(ballpointpen1,600,0,600,900);

     graph.FillRectangle(Brushes.Green,0,790,900,80);
     graph.FillRectangle(Brushes.Orange,0,0,900,80);
    
       graph.DrawEllipse(ballpointpen1,95,125,100,100);     //all circles for player 2
       graph.DrawEllipse(ballpointpen1,395,125,100,100);    // arranged by respective
       graph.DrawEllipse(ballpointpen1,695,125,100,100);    // quadrants
       graph.DrawEllipse(ballpointpen1,95,375,100,100);     //   1   2   3
       graph.DrawEllipse(ballpointpen1,395,375,100,100);    //   4   5   6
       graph.DrawEllipse(ballpointpen1,695,375,100,100);    //   7   8   9
       graph.DrawEllipse(ballpointpen1,95,625,100,100);
       graph.DrawEllipse(ballpointpen1,395,625,100,100);
       graph.DrawEllipse(ballpointpen1,695,625,100,100);

       graph.DrawLine(ballpointpen1,95,125,195,225);
       graph.DrawLine(ballpointpen1,95,225,195,125);

       graph.DrawLine(ballpointpen1,395,125,495,225);
       graph.DrawLine(ballpointpen1,395,225,495,125);

       graph.DrawLine(ballpointpen1,695,125,795,225);
       graph.DrawLine(ballpointpen1,695,225,795,125);

       graph.DrawLine(ballpointpen1,95,375,195,475);
       graph.DrawLine(ballpointpen1,95,475,195,375);

       graph.DrawLine(ballpointpen1,395,375,495,475);
       graph.DrawLine(ballpointpen1,395,475,495,375);

       graph.DrawLine(ballpointpen1,695,375,795,475);
       graph.DrawLine(ballpointpen1,695,475,795,375);

       graph.DrawLine(ballpointpen1,695,375,795,475);
       graph.DrawLine(ballpointpen1,695,475,795,375);


    }   
 
 //  protected void reset_game(Object sender, EventArgs events)
//  {
//      x_1 =false;      //we will attempt to have theshapes pre drawn 
//      x_2 =false;      // so that they will activate by a mixture of boolean
//      x_3 =false;      //values that are set by the group box
//      x_4 =false;
//      x_5 =false;
//      x_6 =false;
//      x_7 =false;
//      x_8 =false;
//      x_9 =false;
			         
//      o_1 =false;
//      o_2 =false;
//      o_3 =false;
//      o_4 =false;
//      o_5 =false;
//      o_6 =false;
//      o_7 =false;
//      o_8 =false;
//      o_9 =false;
    
//      Invalidate();
//      System.Console.WriteLine("The game has been Reset");
    
//  }	   
  protected void close_game(Object sender,EventArgs events)
  { 
	  System.Console.WriteLine("This program will end execution.");
	  Close();
  } 
  
}
