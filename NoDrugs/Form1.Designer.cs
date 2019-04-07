namespace NoDrugs
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.VocabularyMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.LookVocabularyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.InformationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SourceText = new System.Windows.Forms.RichTextBox();
			this.WriteTextBelowLabel = new System.Windows.Forms.Label();
			this.CheckTextBtn = new System.Windows.Forms.Button();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VocabularyMenu,
            this.AboutMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// VocabularyMenu
			// 
			this.VocabularyMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LookVocabularyMenuItem});
			this.VocabularyMenu.Name = "VocabularyMenu";
			this.VocabularyMenu.Size = new System.Drawing.Size(66, 20);
			this.VocabularyMenu.Text = "Словарь";
			// 
			// LookVocabularyMenuItem
			// 
			this.LookVocabularyMenuItem.Name = "LookVocabularyMenuItem";
			this.LookVocabularyMenuItem.Size = new System.Drawing.Size(180, 22);
			this.LookVocabularyMenuItem.Text = "Просмотр словаря";
			this.LookVocabularyMenuItem.Click += new System.EventHandler(this.LookVocabularyMenuItem_Click);
			// 
			// AboutMenu
			// 
			this.AboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformationMenuItem});
			this.AboutMenu.Name = "AboutMenu";
			this.AboutMenu.Size = new System.Drawing.Size(94, 20);
			this.AboutMenu.Text = "О программе";
			// 
			// InformationMenuItem
			// 
			this.InformationMenuItem.Name = "InformationMenuItem";
			this.InformationMenuItem.Size = new System.Drawing.Size(180, 22);
			this.InformationMenuItem.Text = "Сведения";
			this.InformationMenuItem.Click += new System.EventHandler(this.InformationMenuItem_Click);
			// 
			// SourceText
			// 
			this.SourceText.Location = new System.Drawing.Point(12, 50);
			this.SourceText.Name = "SourceText";
			this.SourceText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.SourceText.Size = new System.Drawing.Size(1195, 476);
			this.SourceText.TabIndex = 1;
			this.SourceText.Text = "";
			// 
			// WriteTextBelowLabel
			// 
			this.WriteTextBelowLabel.AutoSize = true;
			this.WriteTextBelowLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WriteTextBelowLabel.Location = new System.Drawing.Point(13, 28);
			this.WriteTextBelowLabel.Name = "WriteTextBelowLabel";
			this.WriteTextBelowLabel.Size = new System.Drawing.Size(242, 19);
			this.WriteTextBelowLabel.TabIndex = 2;
			this.WriteTextBelowLabel.Text = "Введите текст для проверки ниже:";
			// 
			// CheckTextBtn
			// 
			this.CheckTextBtn.Location = new System.Drawing.Point(12, 532);
			this.CheckTextBtn.Name = "CheckTextBtn";
			this.CheckTextBtn.Size = new System.Drawing.Size(116, 23);
			this.CheckTextBtn.TabIndex = 3;
			this.CheckTextBtn.Text = "Проверить текст";
			this.CheckTextBtn.UseVisualStyleBackColor = true;
			this.CheckTextBtn.Click += new System.EventHandler(this.CheckTextBtn_Click);
			// 
			// ClearBtn
			// 
			this.ClearBtn.Location = new System.Drawing.Point(135, 532);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(75, 23);
			this.ClearBtn.TabIndex = 4;
			this.ClearBtn.Text = "Очистить";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1225, 566);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.CheckTextBtn);
			this.Controls.Add(this.WriteTextBelowLabel);
			this.Controls.Add(this.SourceText);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Стоп-наркотик";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem VocabularyMenu;
		private System.Windows.Forms.ToolStripMenuItem LookVocabularyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutMenu;
		private System.Windows.Forms.ToolStripMenuItem InformationMenuItem;
		private System.Windows.Forms.RichTextBox SourceText;
		private System.Windows.Forms.Label WriteTextBelowLabel;
		private System.Windows.Forms.Button CheckTextBtn;
		private System.Windows.Forms.Button ClearBtn;
	}
}

