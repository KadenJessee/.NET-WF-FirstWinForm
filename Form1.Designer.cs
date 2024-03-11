namespace WinFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmdClick = new System.Windows.Forms.Button();
            this.cmdTapMe = new System.Windows.Forms.Button();
            this.cmdPressMe = new System.Windows.Forms.Button();
            this.lblDisplayTxt = new System.Windows.Forms.Label();
            this.lblDisplayTxt2 = new System.Windows.Forms.Label();
            this.lblDisplayTxt3 = new System.Windows.Forms.Label();
            this.lblClickDesc = new System.Windows.Forms.Label();
            this.lblTryCancel = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 23);
            this.textBox3.TabIndex = 2;
            // 
            // cmdClick
            // 
            this.cmdClick.Location = new System.Drawing.Point(87, 175);
            this.cmdClick.Name = "cmdClick";
            this.cmdClick.Size = new System.Drawing.Size(84, 34);
            this.cmdClick.TabIndex = 3;
            this.cmdClick.Text = "Click";
            this.cmdClick.UseVisualStyleBackColor = true;
            this.cmdClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdTapMe
            // 
            this.cmdTapMe.Location = new System.Drawing.Point(351, 175);
            this.cmdTapMe.Name = "cmdTapMe";
            this.cmdTapMe.Size = new System.Drawing.Size(83, 34);
            this.cmdTapMe.TabIndex = 4;
            this.cmdTapMe.Text = "Tap";
            this.cmdTapMe.UseVisualStyleBackColor = true;
            this.cmdTapMe.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdPressMe
            // 
            this.cmdPressMe.Location = new System.Drawing.Point(624, 175);
            this.cmdPressMe.Name = "cmdPressMe";
            this.cmdPressMe.Size = new System.Drawing.Size(85, 34);
            this.cmdPressMe.TabIndex = 5;
            this.cmdPressMe.Text = "Press";
            this.cmdPressMe.UseVisualStyleBackColor = true;
            this.cmdPressMe.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDisplayTxt
            // 
            this.lblDisplayTxt.AutoSize = true;
            this.lblDisplayTxt.Location = new System.Drawing.Point(112, 254);
            this.lblDisplayTxt.Name = "lblDisplayTxt";
            this.lblDisplayTxt.Size = new System.Drawing.Size(0, 15);
            this.lblDisplayTxt.TabIndex = 6;
            // 
            // lblDisplayTxt2
            // 
            this.lblDisplayTxt2.AutoSize = true;
            this.lblDisplayTxt2.Location = new System.Drawing.Point(371, 254);
            this.lblDisplayTxt2.Name = "lblDisplayTxt2";
            this.lblDisplayTxt2.Size = new System.Drawing.Size(0, 15);
            this.lblDisplayTxt2.TabIndex = 7;
            // 
            // lblDisplayTxt3
            // 
            this.lblDisplayTxt3.AutoSize = true;
            this.lblDisplayTxt3.Location = new System.Drawing.Point(649, 254);
            this.lblDisplayTxt3.Name = "lblDisplayTxt3";
            this.lblDisplayTxt3.Size = new System.Drawing.Size(0, 15);
            this.lblDisplayTxt3.TabIndex = 8;
            // 
            // lblClickDesc
            // 
            this.lblClickDesc.AutoSize = true;
            this.lblClickDesc.Location = new System.Drawing.Point(47, 157);
            this.lblClickDesc.Name = "lblClickDesc";
            this.lblClickDesc.Size = new System.Drawing.Size(173, 15);
            this.lblClickDesc.TabIndex = 9;
            this.lblClickDesc.Text = "When clicked, choose yes or no";
            // 
            // lblTryCancel
            // 
            this.lblTryCancel.AutoSize = true;
            this.lblTryCancel.Location = new System.Drawing.Point(332, 157);
            this.lblTryCancel.Name = "lblTryCancel";
            this.lblTryCancel.Size = new System.Drawing.Size(122, 15);
            this.lblTryCancel.TabIndex = 10;
            this.lblTryCancel.Text = "Tap to Retry or Cancel";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(585, 157);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(183, 15);
            this.lblPress.TabIndex = 11;
            this.lblPress.Text = "Press this and push 1 of 3 options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.lblTryCancel);
            this.Controls.Add(this.lblClickDesc);
            this.Controls.Add(this.lblDisplayTxt3);
            this.Controls.Add(this.lblDisplayTxt2);
            this.Controls.Add(this.lblDisplayTxt);
            this.Controls.Add(this.cmdPressMe);
            this.Controls.Add(this.cmdTapMe);
            this.Controls.Add(this.cmdClick);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button cmdClick;
        private Button cmdTapMe;
        private Button cmdPressMe;
        private Label lblDisplayTxt;
        private Label lblDisplayTxt2;
        private Label lblDisplayTxt3;
        private Label lblClickDesc;
        private Label lblTryCancel;
        private Label lblPress;
    }
}