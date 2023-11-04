using MyForm;
using System.Windows.Forms;
namespace MyForm;
public class MyForm : Form
{
	//Определяем контролы
    Button MyButton2 = new Button();
    Button MyButton = new Button();
	ComboBox MycomboBox = new ComboBox();
	Label label = new Label();
	Label label2 = new Label();
	Label label3 = new Label();
	Label labelAnswer = new Label();
	public TextBox textBox = new TextBox();
	public TextBox textBox2 = new TextBox();
	
	//Определение действий
	public MyForm()
	{
		InitializeComponent();

		MyButton.Click += delegate { MyCalculation(); };
		Resize += delegate { MyResize(); };
		MyButton2.Click += delegate { this.Close(); };
	}
	
	//Праметры контролов
	void InitializeComponent()
	{
		//MyForm
		Font = new Font("Arial", 14f);
		this.Text = "Это моя первая форма";
		StartPosition = FormStartPosition.CenterScreen;
		Size = new Size(600, 400);
		MinimumSize = new Size(600, 400);

		//MyButton
		MyButton.Size = new Size(100, 50);
		MyResize();
		MyButton.Text = "Расчёт";
		//MyButton2
		MyButton2.Size = new Size(100, 50);
		MyResize();
        MyButton2.Text = "выход";
		MyButton2.Font = new Font("Arial",16f);
		MyButton2.ForeColor = Color.Red;

		//label
        label.Text = "Введите целое число:";
		label.Size = new(205, 23);
		//textBox
		textBox.Location = new Point(label.Size.Width +0, 0);
		textBox.Text = "";
		//label2
		label2.Text = "Введите целое число:";
		label2.Location = new Point(0,30);
		label2.Size = new(205, 23);
		//textBox2
		textBox2.Location = new Point(label2.Size.Width+0,30);
		textBox2.Text = "";
		//label3
		label3.Text = "Ответ:";
		label3.Location = new Point(0,90);
		label3.Size = new(65,23);
		//labelAnswer
		labelAnswer.Text = "";
		labelAnswer.Location = new Point(label3.Size.Width+0,90);
		labelAnswer.Size = new(370,23);

		//MycomboBox
		MycomboBox.Location = new Point(0,60);
		MycomboBox.Items.Add(MyCacl.Calculation.MyAction.Сложить);
		MycomboBox.Items.Add(MyCacl.Calculation.MyAction.Разделить);
        MycomboBox.Items.Add(MyCacl.Calculation.MyAction.Вычесть);
        MycomboBox.Items.Add(MyCacl.Calculation.MyAction.Умножить);
        MycomboBox.Items.Add(MyCacl.Calculation.MyAction.СуммаПоследовательности);
        MycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
		MycomboBox.SelectedIndex = 0;


		Controls.Add(MyButton);
		Controls.Add(label);
		Controls.Add(label2);
		Controls.Add(label3);
		Controls.Add(labelAnswer);
		Controls.Add(textBox);
		Controls.Add(textBox2);
		Controls.Add(MycomboBox);
		Controls.Add(MyButton2);
	}
	void MyCalculation()
	{
		int x = 0, y = 0;
        Int32.TryParse(textBox.Text, out x);
        Int32.TryParse(textBox2.Text, out y);

		var sel = MycomboBox.SelectedItem;
		
		if(Enum.IsDefined(typeof(MyCacl.Calculation.MyAction),sel))
		{
			labelAnswer.Text = MyCacl.Calculation.ChangeAction((MyCacl.Calculation.MyAction)sel, x, y);
		}
		else
		{
			MessageBox.Show("данный метод не реализован!");
		}
    }

	//Метод определения места кнопок
	void MyResize()
	{
		int XButtonPosition2 = this.Size.Width - MyButton2.Size.Width-15;
		int YButtonPosition2 = this.Size.Height - MyButton2.Size.Height-39;
		int XButtonPosition = this.Size.Width / 2 - MyButton.Size.Width / 2;
		int YButtonPosition = this.Size.Height / 2 - MyButton.Size.Height / 2;
		MyButton.Location = new Point(XButtonPosition, YButtonPosition);
		MyButton2.Location = new Point(XButtonPosition2, YButtonPosition2);
	}
	void MySizelabel()
	{

	}
}