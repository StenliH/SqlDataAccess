namespace DapperDemo
{
	partial class Dashboard
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
			this.peopleFoundListBox = new System.Windows.Forms.ListBox();
			this.searchByLastNameButton = new System.Windows.Forms.Button();
			this.lastNameText = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameInsLabel = new System.Windows.Forms.Label();
			this.firstNameInsText = new System.Windows.Forms.TextBox();
			this.lastNameInsLabel = new System.Windows.Forms.Label();
			this.lastNameInsText = new System.Windows.Forms.TextBox();
			this.phoneNumberInsLabel = new System.Windows.Forms.Label();
			this.phoneNumberInsText = new System.Windows.Forms.TextBox();
			this.emailAddressInsLabel = new System.Windows.Forms.Label();
			this.emailAddressInsText = new System.Windows.Forms.TextBox();
			this.insertRecordButton = new System.Windows.Forms.Button();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.firstNameText = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.searchByFirstNameButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// peopleFoundListBox
			// 
			this.peopleFoundListBox.FormattingEnabled = true;
			this.peopleFoundListBox.ItemHeight = 25;
			this.peopleFoundListBox.Location = new System.Drawing.Point(68, 179);
			this.peopleFoundListBox.Margin = new System.Windows.Forms.Padding(6);
			this.peopleFoundListBox.Name = "peopleFoundListBox";
			this.peopleFoundListBox.Size = new System.Drawing.Size(670, 179);
			this.peopleFoundListBox.TabIndex = 0;
			// 
			// searchByLastNameButton
			// 
			this.searchByLastNameButton.Location = new System.Drawing.Point(533, 74);
			this.searchByLastNameButton.Name = "searchByLastNameButton";
			this.searchByLastNameButton.Size = new System.Drawing.Size(163, 39);
			this.searchByLastNameButton.TabIndex = 1;
			this.searchByLastNameButton.Text = "By Last Name";
			this.searchByLastNameButton.UseVisualStyleBackColor = true;
			this.searchByLastNameButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// lastNameText
			// 
			this.lastNameText.Location = new System.Drawing.Point(208, 78);
			this.lastNameText.Name = "lastNameText";
			this.lastNameText.Size = new System.Drawing.Size(298, 31);
			this.lastNameText.TabIndex = 2;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(63, 81);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
			this.lastNameLabel.TabIndex = 3;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameInsLabel
			// 
			this.firstNameInsLabel.AutoSize = true;
			this.firstNameInsLabel.Location = new System.Drawing.Point(63, 406);
			this.firstNameInsLabel.Name = "firstNameInsLabel";
			this.firstNameInsLabel.Size = new System.Drawing.Size(116, 25);
			this.firstNameInsLabel.TabIndex = 5;
			this.firstNameInsLabel.Text = "First Name";
			// 
			// firstNameInsText
			// 
			this.firstNameInsText.Location = new System.Drawing.Point(224, 403);
			this.firstNameInsText.Name = "firstNameInsText";
			this.firstNameInsText.Size = new System.Drawing.Size(298, 31);
			this.firstNameInsText.TabIndex = 4;
			// 
			// lastNameInsLabel
			// 
			this.lastNameInsLabel.AutoSize = true;
			this.lastNameInsLabel.Location = new System.Drawing.Point(63, 444);
			this.lastNameInsLabel.Name = "lastNameInsLabel";
			this.lastNameInsLabel.Size = new System.Drawing.Size(115, 25);
			this.lastNameInsLabel.TabIndex = 7;
			this.lastNameInsLabel.Text = "Last Name";
			// 
			// lastNameInsText
			// 
			this.lastNameInsText.Location = new System.Drawing.Point(224, 441);
			this.lastNameInsText.Name = "lastNameInsText";
			this.lastNameInsText.Size = new System.Drawing.Size(298, 31);
			this.lastNameInsText.TabIndex = 6;
			// 
			// phoneNumberInsLabel
			// 
			this.phoneNumberInsLabel.AutoSize = true;
			this.phoneNumberInsLabel.Location = new System.Drawing.Point(63, 519);
			this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
			this.phoneNumberInsLabel.Size = new System.Drawing.Size(155, 25);
			this.phoneNumberInsLabel.TabIndex = 11;
			this.phoneNumberInsLabel.Text = "Phone Number";
			// 
			// phoneNumberInsText
			// 
			this.phoneNumberInsText.Location = new System.Drawing.Point(224, 516);
			this.phoneNumberInsText.Name = "phoneNumberInsText";
			this.phoneNumberInsText.Size = new System.Drawing.Size(298, 31);
			this.phoneNumberInsText.TabIndex = 10;
			// 
			// emailAddressInsLabel
			// 
			this.emailAddressInsLabel.AutoSize = true;
			this.emailAddressInsLabel.Location = new System.Drawing.Point(63, 481);
			this.emailAddressInsLabel.Name = "emailAddressInsLabel";
			this.emailAddressInsLabel.Size = new System.Drawing.Size(150, 25);
			this.emailAddressInsLabel.TabIndex = 9;
			this.emailAddressInsLabel.Text = "Email Address";
			// 
			// emailAddressInsText
			// 
			this.emailAddressInsText.Location = new System.Drawing.Point(224, 478);
			this.emailAddressInsText.Name = "emailAddressInsText";
			this.emailAddressInsText.Size = new System.Drawing.Size(298, 31);
			this.emailAddressInsText.TabIndex = 8;
			// 
			// insertRecordButton
			// 
			this.insertRecordButton.Location = new System.Drawing.Point(224, 575);
			this.insertRecordButton.Name = "insertRecordButton";
			this.insertRecordButton.Size = new System.Drawing.Size(147, 39);
			this.insertRecordButton.TabIndex = 12;
			this.insertRecordButton.Text = "Insert";
			this.insertRecordButton.UseVisualStyleBackColor = true;
			this.insertRecordButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(63, 34);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
			this.firstNameLabel.TabIndex = 14;
			this.firstNameLabel.Text = "First Name";
			// 
			// firstNameText
			// 
			this.firstNameText.Location = new System.Drawing.Point(208, 31);
			this.firstNameText.Name = "firstNameText";
			this.firstNameText.Size = new System.Drawing.Size(298, 31);
			this.firstNameText.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(208, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 39);
			this.button1.TabIndex = 15;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// searchByFirstNameButton
			// 
			this.searchByFirstNameButton.Location = new System.Drawing.Point(533, 27);
			this.searchByFirstNameButton.Name = "searchByFirstNameButton";
			this.searchByFirstNameButton.Size = new System.Drawing.Size(163, 39);
			this.searchByFirstNameButton.TabIndex = 16;
			this.searchByFirstNameButton.Text = "By First Name";
			this.searchByFirstNameButton.UseVisualStyleBackColor = true;
			this.searchByFirstNameButton.Click += new System.EventHandler(this.searchByFirstNameButton_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 772);
			this.Controls.Add(this.searchByFirstNameButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.firstNameText);
			this.Controls.Add(this.insertRecordButton);
			this.Controls.Add(this.phoneNumberInsLabel);
			this.Controls.Add(this.phoneNumberInsText);
			this.Controls.Add(this.emailAddressInsLabel);
			this.Controls.Add(this.emailAddressInsText);
			this.Controls.Add(this.lastNameInsLabel);
			this.Controls.Add(this.lastNameInsText);
			this.Controls.Add(this.firstNameInsLabel);
			this.Controls.Add(this.firstNameInsText);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.lastNameText);
			this.Controls.Add(this.searchByLastNameButton);
			this.Controls.Add(this.peopleFoundListBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Dashboard";
			this.Text = "SQL Data Access Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox peopleFoundListBox;
		private System.Windows.Forms.Button searchByLastNameButton;
		private System.Windows.Forms.TextBox lastNameText;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label firstNameInsLabel;
		private System.Windows.Forms.TextBox firstNameInsText;
		private System.Windows.Forms.Label lastNameInsLabel;
		private System.Windows.Forms.TextBox lastNameInsText;
		private System.Windows.Forms.Label phoneNumberInsLabel;
		private System.Windows.Forms.TextBox phoneNumberInsText;
		private System.Windows.Forms.Label emailAddressInsLabel;
		private System.Windows.Forms.TextBox emailAddressInsText;
		private System.Windows.Forms.Button insertRecordButton;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox firstNameText;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button searchByFirstNameButton;
	}
}