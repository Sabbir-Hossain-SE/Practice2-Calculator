namespace CalculatorApp
{
    partial class CalculatorApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.divButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.divButton);
            this.groupBox1.Controls.Add(this.mulButton);
            this.groupBox1.Controls.Add(this.subButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.number2TextBox);
            this.groupBox1.Controls.Add(this.number1TextBox);
            this.groupBox1.Location = new System.Drawing.Point(210, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(203, 244);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(124, 43);
            this.divButton.TabIndex = 8;
            this.divButton.Text = "DIV(/)";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(53, 244);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(124, 43);
            this.mulButton.TabIndex = 7;
            this.mulButton.Text = "MUL(*)";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(203, 177);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(124, 43);
            this.subButton.TabIndex = 6;
            this.subButton.Text = "SUB(-)";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(53, 177);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 43);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "ADD(+)";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number1";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(53, 105);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(274, 20);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "RESULT";
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(203, 69);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(124, 20);
            this.number2TextBox.TabIndex = 1;
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(53, 69);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(124, 20);
            this.number1TextBox.TabIndex = 0;
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalculatorApp";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.TextBox number1TextBox;
    }
}

