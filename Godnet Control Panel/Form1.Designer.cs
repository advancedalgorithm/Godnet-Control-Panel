namespace Godnet_Control_Panel
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label13 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel8 = new Panel();
            textBox3 = new TextBox();
            panel9 = new Panel();
            panel6 = new Panel();
            textBox2 = new TextBox();
            panel7 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel5 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            panel10 = new Panel();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel17 = new Panel();
            label4 = new Label();
            panel11 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel16 = new Panel();
            panel15 = new Panel();
            panel14 = new Panel();
            panel13 = new Panel();
            panel12 = new Panel();
            dataGridView1 = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            ipaddr = new DataGridViewTextBoxColumn();
            plan = new DataGridViewTextBoxColumn();
            max_attks = new DataGridViewTextBoxColumn();
            max_time = new DataGridViewTextBoxColumn();
            max_con = new DataGridViewTextBoxColumn();
            expiry = new DataGridViewTextBoxColumn();
            rank = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel17.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 55);
            panel1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Silver;
            label13.Location = new Point(103, 31);
            label13.Name = "label13";
            label13.Size = new Size(162, 21);
            label13.TabIndex = 3;
            label13.Text = "Connection State: N/A";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(816, 9);
            label2.Name = "label2";
            label2.Size = new Size(16, 21);
            label2.TabIndex = 2;
            label2.Text = "-";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(841, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.output_onlinepngtools__3_;
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 180);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(12, 136);
            button1.Name = "button1";
            button1.Size = new Size(208, 33);
            button1.TabIndex = 5;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(textBox3);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(12, 103);
            panel8.Name = "panel8";
            panel8.Size = new Size(208, 27);
            panel8.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(42, 42, 42);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Silver;
            textBox3.Location = new Point(0, 1);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '●';
            textBox3.Size = new Size(208, 22);
            textBox3.TabIndex = 1;
            textBox3.Text = "Password";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(192, 0, 0);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 24);
            panel9.Name = "panel9";
            panel9.Size = new Size(208, 3);
            panel9.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(12, 70);
            panel6.Name = "panel6";
            panel6.Size = new Size(208, 27);
            panel6.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(42, 42, 42);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(0, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 22);
            textBox2.TabIndex = 1;
            textBox2.Text = "Username";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 0, 0);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(208, 3);
            panel7.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(12, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 27);
            panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(42, 42, 42);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(0, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 22);
            textBox1.TabIndex = 1;
            textBox1.Text = "74.50.67.38";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 3);
            panel5.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 0, 0);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 31);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(71, 7);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 0;
            label3.Text = "Connect To SSH";
            // 
            // panel10
            // 
            panel10.Controls.Add(radioButton5);
            panel10.Controls.Add(radioButton4);
            panel10.Controls.Add(radioButton3);
            panel10.Controls.Add(radioButton2);
            panel10.Controls.Add(radioButton1);
            panel10.Controls.Add(panel17);
            panel10.ForeColor = Color.Silver;
            panel10.Location = new Point(12, 259);
            panel10.Name = "panel10";
            panel10.Size = new Size(234, 200);
            panel10.TabIndex = 6;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton5.ForeColor = Color.Silver;
            radioButton5.Location = new Point(12, 104);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(89, 25);
            radioButton5.TabIndex = 5;
            radioButton5.Text = "Plans DB";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = Color.Silver;
            radioButton4.Location = new Point(12, 73);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(75, 25);
            radioButton4.TabIndex = 4;
            radioButton4.Text = "API DB";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.Silver;
            radioButton3.Location = new Point(12, 166);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(108, 25);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "Attack Logs";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.Silver;
            radioButton2.Location = new Point(12, 135);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(138, 25);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Command Logs";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.Silver;
            radioButton1.Location = new Point(12, 42);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 25);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Users DB";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(192, 0, 0);
            panel17.Controls.Add(label4);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(234, 31);
            panel17.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(45, 7);
            label4.Name = "label4";
            label4.Size = new Size(145, 17);
            label4.TabIndex = 0;
            label4.Text = "Database/Logs To View";
            // 
            // panel11
            // 
            panel11.Controls.Add(label12);
            panel11.Controls.Add(label11);
            panel11.Controls.Add(label9);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(label6);
            panel11.Controls.Add(label5);
            panel11.Controls.Add(panel16);
            panel11.Controls.Add(panel15);
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(dataGridView1);
            panel11.Controls.Add(label10);
            panel11.Controls.Add(label8);
            panel11.Controls.Add(richTextBox1);
            panel11.Location = new Point(252, 73);
            panel11.Name = "panel11";
            panel11.Size = new Size(605, 386);
            panel11.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.ForeColor = Color.Silver;
            label12.Location = new Point(560, 10);
            label12.Name = "label12";
            label12.Size = new Size(36, 17);
            label12.TabIndex = 10;
            label12.Text = "Rank";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(480, 10);
            label11.Name = "label11";
            label11.Size = new Size(43, 17);
            label11.TabIndex = 9;
            label11.Text = "Expiry";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(359, 10);
            label9.Name = "label9";
            label9.Size = new Size(36, 17);
            label9.TabIndex = 7;
            label9.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(260, 10);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 5;
            label7.Text = "Plan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(164, 10);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 4;
            label6.Text = "IP Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(40, 10);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 3;
            label5.Text = "Username";
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(192, 0, 0);
            panel16.Location = new Point(0, 33);
            panel16.Name = "panel16";
            panel16.Size = new Size(605, 3);
            panel16.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(192, 0, 0);
            panel15.Dock = DockStyle.Right;
            panel15.Location = new Point(602, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(3, 380);
            panel15.TabIndex = 1;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(192, 0, 0);
            panel14.Dock = DockStyle.Left;
            panel14.Location = new Point(0, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(3, 380);
            panel14.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(192, 0, 0);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(0, 383);
            panel13.Name = "panel13";
            panel13.Size = new Size(605, 3);
            panel13.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(192, 0, 0);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(605, 3);
            panel12.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.Silver;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.BackgroundColor = Color.FromArgb(42, 42, 42);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle7.SelectionForeColor = Color.Silver;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { username, ipaddr, plan, max_attks, max_time, max_con, expiry, rank });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle8.SelectionForeColor = Color.Silver;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.GridColor = Color.FromArgb(192, 0, 0);
            dataGridView1.Location = new Point(2, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle9.SelectionForeColor = Color.Silver;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle10.SelectionForeColor = Color.Silver;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(671, 348);
            dataGridView1.TabIndex = 2;
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.Name = "username";
            username.Width = 150;
            // 
            // ipaddr
            // 
            ipaddr.HeaderText = "IP";
            ipaddr.Name = "ipaddr";
            // 
            // plan
            // 
            plan.HeaderText = "Plan";
            plan.Name = "plan";
            plan.Width = 50;
            // 
            // max_attks
            // 
            max_attks.HeaderText = "Max Attacks";
            max_attks.Name = "max_attks";
            max_attks.Width = 50;
            // 
            // max_time
            // 
            max_time.HeaderText = "Max Time";
            max_time.Name = "max_time";
            max_time.Width = 50;
            // 
            // max_con
            // 
            max_con.HeaderText = "Max Con";
            max_con.Name = "max_con";
            max_con.Width = 50;
            // 
            // expiry
            // 
            expiry.HeaderText = "Expiry";
            expiry.Name = "expiry";
            // 
            // rank
            // 
            rank.HeaderText = "Rank";
            rank.Name = "rank";
            rank.Width = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(401, 3);
            label10.Name = "label10";
            label10.Size = new Size(55, 30);
            label10.TabIndex = 8;
            label10.Text = "Running \r\nCons";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(311, 3);
            label8.Name = "label8";
            label8.Size = new Size(34, 30);
            label8.TabIndex = 6;
            label8.Text = "Max \r\nCons";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(42, 42, 42);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Silver;
            richTextBox1.Location = new Point(2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(600, 381);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(872, 471);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Panel panel8;
        private TextBox textBox3;
        private Panel panel9;
        private Panel panel6;
        private TextBox textBox2;
        private Panel panel7;
        private Panel panel4;
        private TextBox textBox1;
        private Panel panel5;
        private Panel panel3;
        private Label label3;
        private Panel panel10;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel17;
        private Label label4;
        private Panel panel11;
        private Panel panel15;
        private Panel panel14;
        private Panel panel13;
        private Panel panel12;
        private Label label5;
        private DataGridView dataGridView1;
        private Panel panel16;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn ipaddr;
        private DataGridViewTextBoxColumn plan;
        private DataGridViewTextBoxColumn max_attks;
        private DataGridViewTextBoxColumn max_time;
        private DataGridViewTextBoxColumn max_con;
        private DataGridViewTextBoxColumn expiry;
        private DataGridViewTextBoxColumn rank;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label8;
        private Label label13;
        private RichTextBox richTextBox1;
    }
}
