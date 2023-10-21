using System.Windows.Forms;
static class Program
{
	 static int XButtonPosition {get; set;}
	 static int YButtonPosition {get; set;}
	public static void Main()
	{
		 Form myform=new Form();
		 myform.Text="Это моя первая форма";
		 myform.StartPosition = FormStartPosition.CenterScreen;
		 myform.Size= new Size(1200,800);
		 myform.MinimumSize = new Size(600,400);
		 myform.Opacity = .95;
		 Button button= new Button();
		 
		 button.Size = new Size(100,50);
			Resize(myform,button);
		 button.Text="Нажми меня!";
		 myform.Controls.Add(button);
		 button.Click += delegate {MyMessage();};
		 myform.ResizeBegin += delegate{Resize(myform,button);};
		 myform.ResizeEnd += delegate{Resize(myform,button);};
		
		 
		 myform.ShowDialog();
  
	}
	
	public static void MyMessage()
	{
		MessageBox.Show("Кнопка нажата!",DateTime.Now.ToString());
		
	}
	public static void Resize(Form form,Button button)
	{
		XButtonPosition=form.Size.Width/2 - button.Size.Width/2;
		YButtonPosition=form.Size.Height/2 - button.Size.Height/2;
		button.Location = new Point(XButtonPosition,YButtonPosition);
		
	}

}


