namespace WA_Calculator
{
    partial class Form1
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
            this.lblcalculator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiplicate = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcalculator
            // 
            this.lblcalculator.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblcalculator.Location = new System.Drawing.Point(12, 9);
            this.lblcalculator.Name = "lblcalculator";
            this.lblcalculator.Size = new System.Drawing.Size(693, 40);
            this.lblcalculator.TabIndex = 0;
            this.lblcalculator.Text = "Simple Calculator";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(346, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(619, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next/Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(59, 68);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(152, 23);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Value of A";
            this.lblA.Click += new System.EventHandler(this.first);
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(59, 131);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(149, 23);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Value of B";
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(59, 200);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(146, 23);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "A+B = C";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(268, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(268, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtC.Location = new System.Drawing.Point(268, 200);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(205, 20);
            this.txtC.TabIndex = 8;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnADD.Location = new System.Drawing.Point(62, 239);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 42);
            this.btnADD.TabIndex = 9;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.BackColor = System.Drawing.Color.Fuchsia;
            this.btnSubstract.Location = new System.Drawing.Point(199, 239);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(75, 42);
            this.btnSubstract.TabIndex = 10;
            this.btnSubstract.Text = "SUB";
            this.btnSubstract.UseVisualStyleBackColor = false;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiplicate
            // 
            this.btnMultiplicate.BackColor = System.Drawing.Color.Lime;
            this.btnMultiplicate.Location = new System.Drawing.Point(330, 239);
            this.btnMultiplicate.Name = "btnMultiplicate";
            this.btnMultiplicate.Size = new System.Drawing.Size(75, 42);
            this.btnMultiplicate.TabIndex = 11;
            this.btnMultiplicate.Text = "MULT";
            this.btnMultiplicate.UseVisualStyleBackColor = false;
            this.btnMultiplicate.Click += new System.EventHandler(this.btnMultiplicate_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Tomato;
            this.btnDivision.Location = new System.Drawing.Point(464, 239);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 42);
            this.btnDivision.TabIndex = 12;
            this.btnDivision.Text = "DIV";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicate);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcalculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalculator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnADD;
        protected System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiplicate;
        private System.Windows.Forms.Button btnDivision;
    }
}

