namespace DialOnAndroidGui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxDial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonPound = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxGoogleAndroidKey = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDial
            // 
            this.textBoxDial.Location = new System.Drawing.Point(6, 15);
            this.textBoxDial.Name = "textBoxDial";
            this.textBoxDial.Size = new System.Drawing.Size(400, 20);
            this.textBoxDial.TabIndex = 0;
            this.textBoxDial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDial_KeyDown_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(88, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(88, 128);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // buttonStar
            // 
            this.buttonStar.Location = new System.Drawing.Point(6, 128);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(75, 23);
            this.buttonStar.TabIndex = 12;
            this.buttonStar.Text = "*";
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // buttonPound
            // 
            this.buttonPound.Location = new System.Drawing.Point(169, 128);
            this.buttonPound.Name = "buttonPound";
            this.buttonPound.Size = new System.Drawing.Size(75, 23);
            this.buttonPound.TabIndex = 14;
            this.buttonPound.Text = "#";
            this.buttonPound.UseVisualStyleBackColor = true;
            this.buttonPound.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(169, 99);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(169, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(412, 15);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(33, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(454, 15);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(33, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxGoogleAndroidKey
            // 
            this.textBoxGoogleAndroidKey.Location = new System.Drawing.Point(250, 70);
            this.textBoxGoogleAndroidKey.Multiline = true;
            this.textBoxGoogleAndroidKey.Name = "textBoxGoogleAndroidKey";
            this.textBoxGoogleAndroidKey.Size = new System.Drawing.Size(237, 81);
            this.textBoxGoogleAndroidKey.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 175);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(491, 5);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Google Cloud Device ID";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(412, 41);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "register";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 180);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxGoogleAndroidKey);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonPound);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Dial on Android";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Button buttonPound;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxGoogleAndroidKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
    }
}

