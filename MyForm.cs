using System.Windows.Forms;
public class MyForm:Form
{
	int XButtonPosition {get; set;}
	int YButtonPosition {get; set;}
	Button MyButton = new Button();
	Label label  = new Label();
	public TextBox textBox = new TextBox();
	 
	public MyForm()
    {
        InitializeComponent();
		
		MyButton.Click += delegate {MyMessage();};
		ResizeBegin += delegate{MyResize();};
		ResizeEnd += delegate{MyResize();};
    }

    void InitializeComponent()
    {
		this.Text="Это моя первая форма";
		StartPosition = FormStartPosition.CenterScreen;
		Size= new Size(1200,800);
		MinimumSize = new Size(600,400);
		 //myform.Opacity = .95;
		 
		 //MyButton
		 MyButton.Size = new Size(100,50);
		 MyResize();
		 MyButton.Text="Нажми меня!";
		 
		 

		 label.Text="Введите текст:";
		 textBox.Location = new Point(label.Size.Width+10,0);
		 
		 Controls.Add(MyButton);
		 Controls.Add(label);
		 Controls.Add(textBox);
		
		
	}
	void MyMessage()
	{
		MessageBox.Show("Кнопка нажата!Ура!",DateTime.Now.ToString());
		
	}
	void MyResize()
	{
		XButtonPosition = this.Size.Width/2 - MyButton.Size.Width/2;
		YButtonPosition = this.Size.Height/2 - MyButton.Size.Height/2;
		MyButton.Location = new Point(XButtonPosition,YButtonPosition);
	}
}