using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			string name = nameTextBox.Text;

			// todo驗證帳密是否正確

			// new Form1,將帳號傳過去
			var frm = new Form1(name);
			frm.Show();
		}
	}
}
