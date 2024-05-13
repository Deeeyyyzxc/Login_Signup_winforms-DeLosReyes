/*
 * Created by SharpDevelop.
 * User: Admin-PC
 * Date: 13 May 2024
 * Time: 3:04 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;

namespace winforms_DeLosReyes
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public delegate void CredentialsSavedHandler(string username, string password);
        public event CredentialsSavedHandler CredentialsSaved;

        // Dictionary to store username and password
        private IDictionary userCredentials = new Hashtable();
		
		public Form2()
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

            if (userCredentials.Contains(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
            }
            else
            {
                userCredentials[username] = password;
				MessageBox.Show("Username and password saved successfully.");
				CredentialsSaved.Invoke(username, password);
					this.Close();
            }
		}
	}
}
