/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 14/07/2020
 * Time: 22:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace mediaFrotaVeiculos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnMedia;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnListar;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button btnGravar;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnMedia = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnListar = new System.Windows.Forms.Button();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.btnGravar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(624, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(184, 147);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(101, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Frota de Veículos";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 47);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(314, 173);
			this.listBox1.TabIndex = 2;
			// 
			// btnMedia
			// 
			this.btnMedia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnMedia.Location = new System.Drawing.Point(13, 227);
			this.btnMedia.Name = "btnMedia";
			this.btnMedia.Size = new System.Drawing.Size(75, 23);
			this.btnMedia.TabIndex = 3;
			this.btnMedia.Text = "Listar";
			this.btnMedia.UseVisualStyleBackColor = true;
			this.btnMedia.Click += new System.EventHandler(this.BtnMediaClick);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(332, 138);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(216, 82);
			this.listBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(332, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Veiculos que mais gatam por Km/L";
			// 
			// btnListar
			// 
			this.btnListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnListar.Location = new System.Drawing.Point(332, 226);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(75, 23);
			this.btnListar.TabIndex = 6;
			this.btnListar.Text = "Listar";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.BtnListarClick);
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(624, 176);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(184, 147);
			this.richTextBox2.TabIndex = 7;
			this.richTextBox2.Text = "";
			// 
			// btnGravar
			// 
			this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnGravar.Location = new System.Drawing.Point(413, 226);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(75, 23);
			this.btnGravar.TabIndex = 8;
			this.btnGravar.Text = "Gravar";
			this.btnGravar.UseVisualStyleBackColor = true;
			this.btnGravar.Click += new System.EventHandler(this.BtnGravarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(586, 276);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.btnListar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.btnMedia);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Name = "MainForm";
			this.Text = "mediaFrotaVeiculos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
