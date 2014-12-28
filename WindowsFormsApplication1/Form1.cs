using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1 ( )
		{
			InitializeComponent ( );
		}

		private void button1_Click ( object sender , EventArgs e )
		{
			label5 . Text = "學號:" + textBox1 . Text + System . Environment . NewLine + "姓名:" + textBox2 . Text + System . Environment . NewLine + "年齡:" + textBox3 . Text + System . Environment . NewLine + "電話:" + textBox4 . Text;
			label5 . ForeColor = Color . BurlyWood;
			label5 . BackColor = Color . DarkCyan;
		}
	}
}
