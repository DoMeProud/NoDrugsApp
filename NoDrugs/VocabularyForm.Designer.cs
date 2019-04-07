namespace NoDrugs
{
	partial class VocabularyForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.VocabularyBox = new System.Windows.Forms.ListBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// VocabularyBox
			// 
			this.VocabularyBox.FormattingEnabled = true;
			this.VocabularyBox.Location = new System.Drawing.Point(12, 12);
			this.VocabularyBox.Name = "VocabularyBox";
			this.VocabularyBox.Size = new System.Drawing.Size(776, 303);
			this.VocabularyBox.TabIndex = 0;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(13, 322);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 1;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(713, 321);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 2;
			this.DeleteBtn.Text = "Удалить";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// VocabularyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 356);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.VocabularyBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "VocabularyForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Словарь";
			this.Load += new System.EventHandler(this.VocabularyForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox VocabularyBox;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button DeleteBtn;
	}
}