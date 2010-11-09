using System;
using System.Drawing;
using System.Windows.Forms;
class MyForm : Form
{
	public MyForm ()
	{
		this.Text = "Winform Built with monomac";
		var button1 = new Button ();
		button1.Location = new PointF (100, 70);
		button1.Size = new SizeF (100, 30);
		button1.TabIndex = 10;
		button1.Clicked += delegate {
			MessageBox.Show("I was clicked");
		};
		
		var textBox1 = new TextBox ();
		textBox1.Location = new System.Drawing.Point (109, 40);
		textBox1.Name = "textBox1";
		textBox1.Size = new System.Drawing.Size (236, 20);
		textBox1.TabIndex = 1;
		
		var textBox2 = new TextBox ();
		textBox2.Location = new System.Drawing.Point (109, 100);
		textBox2.Name = "textBox2";
		textBox2.Size = new System.Drawing.Size (236, 20);
		textBox2.TabIndex = 3;
		textBox2.Text = "tb2";
		
		var textBox3 = new TextBox ();
		textBox3.Location = new System.Drawing.Point (109, 140);
		textBox3.Name = "textBox3";
		textBox3.Size = new System.Drawing.Size (236, 20);
		textBox3.TabIndex = 2;
		textBox3.Text = "tb3";
		
		var label1 = new Label ();
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point (28, 44);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size (75, 13);
		label1.TabIndex = 5;
		label1.Text = "My Label:";
		
		Controls.Add (button1);
		Controls.Add (textBox1);
		Controls.Add (textBox2);
		Controls.Add (textBox3);
		Controls.Add (label1);
		
		var test = Controls.Count;
		
		
	}
	public static void Main (string[] args)
	{
		Application.Run (delegate() { return new MyForm (); });
	}
}