﻿
namespace lab4
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
            this.sizeOfVeselBox = new System.Windows.Forms.TextBox();
            this.percentOfAlchBox = new System.Windows.Forms.TextBox();
            this.amountOfVeselsBox = new System.Windows.Forms.TextBox();
            this.valueOfPureAlchBox = new System.Windows.Forms.TextBox();
            this.valueOfDrinksBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboValueBox = new System.Windows.Forms.ComboBox();
            this.comboPercentBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sizeOfVeselBox
            // 
            this.sizeOfVeselBox.Location = new System.Drawing.Point(16, 28);
            this.sizeOfVeselBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizeOfVeselBox.Name = "sizeOfVeselBox";
            this.sizeOfVeselBox.Size = new System.Drawing.Size(104, 20);
            this.sizeOfVeselBox.TabIndex = 0;
            // 
            // percentOfAlchBox
            // 
            this.percentOfAlchBox.Location = new System.Drawing.Point(16, 92);
            this.percentOfAlchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.percentOfAlchBox.Name = "percentOfAlchBox";
            this.percentOfAlchBox.Size = new System.Drawing.Size(104, 20);
            this.percentOfAlchBox.TabIndex = 1;
            // 
            // amountOfVeselsBox
            // 
            this.amountOfVeselsBox.Location = new System.Drawing.Point(16, 157);
            this.amountOfVeselsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountOfVeselsBox.Name = "amountOfVeselsBox";
            this.amountOfVeselsBox.Size = new System.Drawing.Size(104, 20);
            this.amountOfVeselsBox.TabIndex = 2;
            // 
            // valueOfPureAlchBox
            // 
            this.valueOfPureAlchBox.Location = new System.Drawing.Point(325, 29);
            this.valueOfPureAlchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueOfPureAlchBox.Name = "valueOfPureAlchBox";
            this.valueOfPureAlchBox.Size = new System.Drawing.Size(104, 20);
            this.valueOfPureAlchBox.TabIndex = 3;
            // 
            // valueOfDrinksBox
            // 
            this.valueOfDrinksBox.Location = new System.Drawing.Point(170, 29);
            this.valueOfDrinksBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueOfDrinksBox.Name = "valueOfDrinksBox";
            this.valueOfDrinksBox.Size = new System.Drawing.Size(104, 20);
            this.valueOfDrinksBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.calculateButton.Location = new System.Drawing.Point(170, 92);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 20);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clearButton.Location = new System.Drawing.Point(325, 92);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 20);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(16, 13);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(33, 13);
            this.V.TabIndex = 7;
            this.V.Text = "V (ml)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "alc%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "drink V (ml)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "alc V (ml)";
            // 
            // comboValueBox
            // 
            this.comboValueBox.FormattingEnabled = true;
            this.comboValueBox.Location = new System.Drawing.Point(173, 158);
            this.comboValueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboValueBox.Name = "comboValueBox";
            this.comboValueBox.Size = new System.Drawing.Size(101, 21);
            this.comboValueBox.TabIndex = 12;
            this.comboValueBox.SelectedValueChanged += new System.EventHandler(this.comboValueBox_SelectedValueChanged);
            // 
            // comboPercentBox
            // 
            this.comboPercentBox.FormattingEnabled = true;
            this.comboPercentBox.Location = new System.Drawing.Point(328, 158);
            this.comboPercentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboPercentBox.Name = "comboPercentBox";
            this.comboPercentBox.Size = new System.Drawing.Size(101, 21);
            this.comboPercentBox.TabIndex = 13;
            this.comboPercentBox.SelectedValueChanged += new System.EventHandler(this.comboPercentBox_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 260);
            this.Controls.Add(this.comboPercentBox);
            this.Controls.Add(this.comboValueBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.V);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.valueOfDrinksBox);
            this.Controls.Add(this.valueOfPureAlchBox);
            this.Controls.Add(this.amountOfVeselsBox);
            this.Controls.Add(this.percentOfAlchBox);
            this.Controls.Add(this.sizeOfVeselBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sizeOfVeselBox;
        private System.Windows.Forms.TextBox percentOfAlchBox;
        private System.Windows.Forms.TextBox amountOfVeselsBox;
        private System.Windows.Forms.TextBox valueOfPureAlchBox;
        private System.Windows.Forms.TextBox valueOfDrinksBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboValueBox;
        private System.Windows.Forms.ComboBox comboPercentBox;
    }
}

