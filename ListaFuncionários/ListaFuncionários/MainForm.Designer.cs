/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 01/07/2020
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ListaFuncionários
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnAbrir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnListar;
		private System.Windows.Forms.Button btnSomar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnAbrir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnListar = new System.Windows.Forms.Button();
			this.btnSomar = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 40);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(199, 171);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnAbrir
			// 
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbrir.Location = new System.Drawing.Point(12, 217);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Size = new System.Drawing.Size(75, 23);
			this.btnAbrir.TabIndex = 1;
			this.btnAbrir.Text = "Carregar";
			this.btnAbrir.UseVisualStyleBackColor = true;
			this.btnAbrir.Click += new System.EventHandler(this.BtnAbrirClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Banco de dados Funcionários";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(291, 40);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(326, 199);
			this.listBox1.TabIndex = 3;
			// 
			// btnListar
			// 
			this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListar.Location = new System.Drawing.Point(291, 245);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(75, 23);
			this.btnListar.TabIndex = 4;
			this.btnListar.Text = "Listar";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.BtnListarClick);
			// 
			// btnSomar
			// 
			this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSomar.Location = new System.Drawing.Point(293, 337);
			this.btnSomar.Name = "btnSomar";
			this.btnSomar.Size = new System.Drawing.Size(75, 23);
			this.btnSomar.TabIndex = 5;
			this.btnSomar.Text = "Calcular";
			this.btnSomar.UseVisualStyleBackColor = true;
			this.btnSomar.Click += new System.EventHandler(this.BtnSomarClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(399, 310);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 20);
			this.textBox1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(12, 284);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Seção 1: Gerência";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(12, 310);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Seção 2: Vendas";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(12, 335);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Seção 3: Recursos Humanos";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(12, 363);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Seção 4: Estoque";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(12, 387);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Seção 5: Contabilidade";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.Location = new System.Drawing.Point(293, 313);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 15);
			this.label7.TabIndex = 12;
			this.label7.Text = "Pesquisar Seção:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Location = new System.Drawing.Point(12, 258);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 17);
			this.label9.TabIndex = 14;
			this.label9.Text = "Seções";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label10.Location = new System.Drawing.Point(453, 421);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 15);
			this.label10.TabIndex = 15;
			this.label10.Text = "Salário total da seção:";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(453, 310);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(181, 108);
			this.listBox2.TabIndex = 16;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(291, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(141, 15);
			this.label11.TabIndex = 17;
			this.label11.Text = "Lista de funcionários";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label12.Location = new System.Drawing.Point(291, 283);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(101, 17);
			this.label12.TabIndex = 18;
			this.label12.Text = "Salário total:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.ClientSize = new System.Drawing.Size(657, 449);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnSomar);
			this.Controls.Add(this.btnListar);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.Text = "ListaFuncionários";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
