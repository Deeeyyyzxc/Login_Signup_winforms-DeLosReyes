/*
 * Created by SharpDevelop.
 * User: Admin-PC
 * Date: 13 May 2024
 * Time: 1:43 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;

namespace winforms_DeLosReyes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string CorrectUsername = "admin";
        private string CorrectPassword = "password";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			textBox2.UseSystemPasswordChar = true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
 			string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == CorrectUsername && password == CorrectPassword)
            {
                Form1 welcome = new Form1();
                welcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.");
            }
            
		}

		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			 Form2 signup = new Form2();
            signup.CredentialsSaved += (username, password) =>
            {
                // Update the CorrectUsername and CorrectPassword variables
                CorrectUsername = username;
                CorrectPassword = password;
            };
            signup.Show();
		}
	}

}
