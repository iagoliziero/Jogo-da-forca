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
		int erros;
		
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
			string palavra = textBox1.Text;
			string letra;
			int vezesEncontradas = 0;

			
			letra = textBox2.Text.Trim().ToLower(); // Remove espaços e converte para minúsculo;
			textBox2.Focus();
			
			// Verifica se o usuário inseriu apenas uma letra
			if(string.IsNullOrWhiteSpace(textBox2.Text) || letra.Length > 1) {
				MessageBox.Show("Insira apenas uma letra");
				return;
			}
			
			for(int i = 0; i < palavra.Length; i++) {
				if (letra[0] == char.ToLower(palavra[i])) {
			        vezesEncontradas++;
			        
				} 
			}
			
			// Verifica se a letra foi encontrada e exibe a mensagem no listBox1
			if(vezesEncontradas >= 1) {
				listBox1.Items.Add(letra + ": aparece " + vezesEncontradas + " vez(es)");
			} 
			else
			{ 
				erros++;
				listBox1.Items.Add(letra + ": não aparece." + " Erros: " + erros);				
			}
			if(erros == 6) {
				textBox2.Enabled = false;
				button3.Enabled = false;
				 MessageBox.Show("Você atingiu o número máximo de erros.");
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			string palavra = textBox1.Text;
			string resposta = textBox3.Text;
			if(palavra == resposta) {
				label6.Text = "Resposta Correta";
				label6.ForeColor = Color.Green;
			} else {
				label6.Text = "Resposta Errada";
				label6.ForeColor = Color.Red;
				return;
			}
		}
	}
}
