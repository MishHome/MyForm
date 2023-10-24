using System.Windows.Forms;
public class MyForm:Form
{
	
	
	Button MyButton = new Button();
	ComboBox MycomboBox = new ComboBox();
	Label label2 = new Label();
	Label label  = new Label();
	public TextBox textBox = new TextBox();
	public TextBox textBox2 = new TextBox();
	 
	public MyForm()
    {
        InitializeComponent();
		
		MyButton.Click += delegate{MyMessage();};
		Resize += delegate{MyResize();};
    }

    void InitializeComponent()
    {
		Font = new Font("Arial", 13f);
		this.Text="Это моя первая форма";
		StartPosition = FormStartPosition.CenterScreen;
		Size= new Size(600,400);
		MinimumSize = new Size(600,400);
		 //myform.Opacity = .95;
		 
		 //MyButton
		 MyButton.Size = new Size(100,50);
		 MyResize();
		 MyButton.Text="Нажми меня!";
		 
		 

		 label.Text="Введите число:";
		 textBox.Location = new Point(label.Size.Width+10,0);
		 textBox.Text = "";
		 
		 label2.Text="Введите число:";
		 label2.Location = new Point(210,0);
		 textBox2.Location = new Point(textBox.Size.Width+210,0);
		 textBox2.Text = "";
		 
		 MycomboBox.Location = new Point(0,200);
		 MycomboBox.Items.Add("+");
		 MycomboBox.DropDownStyle= ComboBoxStyle.DropDownList;
		MycomboBox.SelectedIndex = 0;
		 
		 Controls.Add(MyButton);
		 Controls.Add(label);
		 Controls.Add(label2);
		 Controls.Add(textBox);
		 Controls.Add(textBox2);
		 Controls.Add(MycomboBox);
		
		
	}
	
	void MyMessage()
	{
		int x=0,y=0;
	
		Int32.TryParse(textBox.Text, out x);
		Int32.TryParse(textBox2.Text,out y);

		MessageBox.Show($"{x}+{y}={x+y}","результат");
		
	}
	void MyResize()
	{
		int XButtonPosition = this.Size.Width/2 - MyButton.Size.Width/2;
		int YButtonPosition = this.Size.Height/2 - MyButton.Size.Height/2;
		MyButton.Location = new Point(XButtonPosition,YButtonPosition);
	}
}