using System;
using System.Windows.Forms;

public class Gui : Form
{
	static void Main(string[] args)
	{
		Application.Run(new Gui());
	}

	public Gui()
	{
		Button btn = new Button();
		btn.Text = "Click!";
		btn.Click += (sender, e) => MessageBox.Show("Hello, Powershell!");
		Controls.Add(btn);
	}
}
