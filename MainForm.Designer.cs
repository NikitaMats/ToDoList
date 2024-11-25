namespace ToDoList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            taskList = new TabPage();
            taskListBox = new ListBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            tabControl.SuspendLayout();
            taskList.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(taskList);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(784, 461);
            tabControl.TabIndex = 1;
            // 
            // taskList
            // 
            taskList.Controls.Add(button2);
            taskList.Controls.Add(button1);
            taskList.Controls.Add(comboBox1);
            taskList.Controls.Add(label4);
            taskList.Controls.Add(textBox3);
            taskList.Controls.Add(label3);
            taskList.Controls.Add(label2);
            taskList.Controls.Add(textBox2);
            taskList.Controls.Add(textBox1);
            taskList.Controls.Add(label1);
            taskList.Controls.Add(taskListBox);
            taskList.Location = new Point(4, 24);
            taskList.Name = "taskList";
            taskList.Padding = new Padding(3);
            taskList.Size = new Size(776, 433);
            taskList.TabIndex = 0;
            taskList.Text = "Tasks";
            taskList.UseVisualStyleBackColor = true;
            // 
            // taskListBox
            // 
            taskListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 15;
            taskListBox.Location = new Point(10, 10);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(200, 409);
            taskListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 10);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(466, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 10);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Executor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Description:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 75);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(476, 294);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 381);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Task Status:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(222, 396);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(364, 381);
            button1.Name = "button1";
            button1.Size = new Size(161, 38);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(535, 381);
            button2.Name = "button2";
            button2.Size = new Size(161, 38);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            taskList.ResumeLayout(false);
            taskList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage taskList;
        private TabPage tabPage2;
        private ListBox taskListBox;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
    }
}
