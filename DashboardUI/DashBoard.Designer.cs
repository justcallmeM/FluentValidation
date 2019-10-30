namespace DashboardUI
{
    partial class DashBoard
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
            this.button_Create = new System.Windows.Forms.Button();
            this.text_FirstName = new System.Windows.Forms.Label();
            this.text_LastName = new System.Windows.Forms.Label();
            this.text_AccountBalance = new System.Windows.Forms.Label();
            this.text_DateOfBirth = new System.Windows.Forms.Label();
            this.text_CreateUser = new System.Windows.Forms.Label();
            this.text_ErrorList = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_AccountBalance = new System.Windows.Forms.TextBox();
            this.listBox_ErrorList = new System.Windows.Forms.ListBox();
            this.picker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(101, 281);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(153, 44);
            this.button_Create.TabIndex = 0;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // text_FirstName
            // 
            this.text_FirstName.AutoSize = true;
            this.text_FirstName.Location = new System.Drawing.Point(98, 156);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(57, 13);
            this.text_FirstName.TabIndex = 1;
            this.text_FirstName.Text = "First Name";
            // 
            // text_LastName
            // 
            this.text_LastName.AutoSize = true;
            this.text_LastName.Location = new System.Drawing.Point(98, 182);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(58, 13);
            this.text_LastName.TabIndex = 2;
            this.text_LastName.Text = "Last Name";
            // 
            // text_AccountBalance
            // 
            this.text_AccountBalance.AutoSize = true;
            this.text_AccountBalance.Location = new System.Drawing.Point(98, 208);
            this.text_AccountBalance.Name = "text_AccountBalance";
            this.text_AccountBalance.Size = new System.Drawing.Size(89, 13);
            this.text_AccountBalance.TabIndex = 3;
            this.text_AccountBalance.Text = "Account Balance";
            // 
            // text_DateOfBirth
            // 
            this.text_DateOfBirth.AutoSize = true;
            this.text_DateOfBirth.Location = new System.Drawing.Point(98, 234);
            this.text_DateOfBirth.Name = "text_DateOfBirth";
            this.text_DateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.text_DateOfBirth.TabIndex = 4;
            this.text_DateOfBirth.Text = "Date of Birth";
            // 
            // text_CreateUser
            // 
            this.text_CreateUser.AutoSize = true;
            this.text_CreateUser.Location = new System.Drawing.Point(101, 115);
            this.text_CreateUser.Name = "text_CreateUser";
            this.text_CreateUser.Size = new System.Drawing.Size(63, 13);
            this.text_CreateUser.TabIndex = 5;
            this.text_CreateUser.Text = "Create User";
            // 
            // text_ErrorList
            // 
            this.text_ErrorList.AutoSize = true;
            this.text_ErrorList.Location = new System.Drawing.Point(371, 115);
            this.text_ErrorList.Name = "text_ErrorList";
            this.text_ErrorList.Size = new System.Drawing.Size(48, 13);
            this.text_ErrorList.TabIndex = 6;
            this.text_ErrorList.Text = "Error List";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(186, 153);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(126, 20);
            this.textBox_FirstName.TabIndex = 7;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(186, 179);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(126, 20);
            this.textBox_LastName.TabIndex = 8;
            // 
            // textBox_AccountBalance
            // 
            this.textBox_AccountBalance.Location = new System.Drawing.Point(186, 205);
            this.textBox_AccountBalance.Name = "textBox_AccountBalance";
            this.textBox_AccountBalance.Size = new System.Drawing.Size(126, 20);
            this.textBox_AccountBalance.TabIndex = 9;
            // 
            // listBox_ErrorList
            // 
            this.listBox_ErrorList.FormattingEnabled = true;
            this.listBox_ErrorList.Location = new System.Drawing.Point(374, 152);
            this.listBox_ErrorList.Name = "listBox_ErrorList";
            this.listBox_ErrorList.Size = new System.Drawing.Size(319, 173);
            this.listBox_ErrorList.TabIndex = 12;
            // 
            // picker_DateOfBirth
            // 
            this.picker_DateOfBirth.Location = new System.Drawing.Point(186, 234);
            this.picker_DateOfBirth.Name = "picker_DateOfBirth";
            this.picker_DateOfBirth.Size = new System.Drawing.Size(126, 20);
            this.picker_DateOfBirth.TabIndex = 13;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picker_DateOfBirth);
            this.Controls.Add(this.listBox_ErrorList);
            this.Controls.Add(this.textBox_AccountBalance);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.text_ErrorList);
            this.Controls.Add(this.text_CreateUser);
            this.Controls.Add(this.text_DateOfBirth);
            this.Controls.Add(this.text_AccountBalance);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.text_FirstName);
            this.Controls.Add(this.button_Create);
            this.Name = "DashBoard";
            this.Text = "Form_DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label text_FirstName;
        private System.Windows.Forms.Label text_LastName;
        private System.Windows.Forms.Label text_AccountBalance;
        private System.Windows.Forms.Label text_DateOfBirth;
        private System.Windows.Forms.Label text_CreateUser;
        private System.Windows.Forms.Label text_ErrorList;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_AccountBalance;
        private System.Windows.Forms.ListBox listBox_ErrorList;
        private System.Windows.Forms.DateTimePicker picker_DateOfBirth;
    }
}

