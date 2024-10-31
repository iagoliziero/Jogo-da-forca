/*
 * Created by SharpDevelop.
 * User: Iago Liziero
 * Date: 31/10/2024
 * Time: 15:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogoDaForcacs
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			string palavra;
			string letra;
			string resposta;
			int erros;
			
			//desabilitar botões
			button2.Enabled = false;
			button3.Enabled = false;
			textBox3.Enabled = false;
			textBox2.Enabled = false;
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			string palavra;
			palavra = textBox1.Text;
			
			//trazer a txtbox1 como foco
			textBox1.Focus();
			
			// if para ver se o valor é válido
			if(string.IsNullOrWhiteSpace(textBox1.Text)) {
			   MessageBox.Show("Insira um texto válido");
			   return;
			}
			
			label1.Text = ("A palavra contém " + palavra.Length + " letras.");
			
			// habilitar caixas
			button2.Enabled = true;
			button3.Enabled = true;
			textBox3.Enabled = true;
			textBox2.Enabled = true;
			textBox1.Visible = false;
			button1.Visible = false;
			
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			string palavra;
			string letra;
			int vezesEncontradas = 0;
			letra = textBox2.Text;
			textBox2.Focus();
			
			if(string.IsNullOrWhiteSpace(textBox2.Text) || letra.Length > 1) {
				MessageBox.Show("Insira apenas uma letra");
				return;
			}
			for(int i = 0; i < palavra.Length; i++) 
			{
				if(letra[0] == palavra[i]) 
				{
					vezesEncontradas++;
				}
					if(vezesEncontradas >= 1)
					{
						listBox1.Items.Add("A letra" + letra + "aparece" + vezesEncontradas + "vez(es)");
					}
			}
			
			
		}
	}
}
