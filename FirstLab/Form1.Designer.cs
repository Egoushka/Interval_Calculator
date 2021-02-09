namespace FirstLab
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

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
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.intervalA = new System.Windows.Forms.GroupBox();
            this.aEnd = new System.Windows.Forms.NumericUpDown();
            this.aBeg = new System.Windows.Forms.NumericUpDown();
            this.intervalB = new System.Windows.Forms.GroupBox();
            this.bEnd = new System.Windows.Forms.NumericUpDown();
            this.bBeg = new System.Windows.Forms.NumericUpDown();
            this.controllPanel = new System.Windows.Forms.GroupBox();
            this.divBNUD = new System.Windows.Forms.NumericUpDown();
            this.multANUD = new System.Windows.Forms.NumericUpDown();
            this.subFromBNUD = new System.Windows.Forms.NumericUpDown();
            this.addToaNUD = new System.Windows.Forms.NumericUpDown();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.GroupBox();
            this.toB = new System.Windows.Forms.RadioButton();
            this.toA = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.intervalA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.aEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.aBeg)).BeginInit();
            this.intervalB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.bEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bBeg)).BeginInit();
            this.controllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.divBNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.multANUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.subFromBNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.addToaNUD)).BeginInit();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Add";
            this.radioButton1.Text = "Adding";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(6, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Subtraction";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(6, 80);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Multiply";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(6, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Division";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.Location = new System.Drawing.Point(6, 200);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(104, 24);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Maximum";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Location = new System.Drawing.Point(6, 170);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(104, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Mapping A";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(6, 140);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(118, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Division(hypothesis)";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.Location = new System.Drawing.Point(132, 20);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(104, 24);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Adding to A";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.Location = new System.Drawing.Point(132, 50);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(130, 24);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Substraction from B";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.Location = new System.Drawing.Point(132, 110);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(119, 24);
            this.radioButton11.TabIndex = 10;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Division B by a num";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.Location = new System.Drawing.Point(132, 140);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(153, 24);
            this.radioButton12.TabIndex = 11;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Myltiplying several intervals";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.Location = new System.Drawing.Point(132, 170);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(104, 24);
            this.radioButton13.TabIndex = 12;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Inversion B";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.Location = new System.Drawing.Point(132, 200);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(104, 24);
            this.radioButton14.TabIndex = 13;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Minimum";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // intervalA
            // 
            this.intervalA.Controls.Add(this.aEnd);
            this.intervalA.Controls.Add(this.aBeg);
            this.intervalA.Location = new System.Drawing.Point(12, 15);
            this.intervalA.Name = "intervalA";
            this.intervalA.Size = new System.Drawing.Size(225, 74);
            this.intervalA.TabIndex = 18;
            this.intervalA.TabStop = false;
            this.intervalA.Text = "Interval A";
            // 
            // aEnd
            // 
            this.aEnd.Location = new System.Drawing.Point(137, 28);
            this.aEnd.Minimum = new decimal(new int[] {100, 0, 0, -2147483648});
            this.aEnd.Name = "aEnd";
            this.aEnd.Size = new System.Drawing.Size(82, 20);
            this.aEnd.TabIndex = 1;
            // 
            // aBeg
            // 
            this.aBeg.Location = new System.Drawing.Point(6, 28);
            this.aBeg.Minimum = new decimal(new int[] {100, 0, 0, -2147483648});
            this.aBeg.Name = "aBeg";
            this.aBeg.Size = new System.Drawing.Size(82, 20);
            this.aBeg.TabIndex = 0;
            this.aBeg.ValueChanged += new System.EventHandler(this.aBeg_ValueChanged);
            // 
            // intervalB
            // 
            this.intervalB.Controls.Add(this.bEnd);
            this.intervalB.Controls.Add(this.bBeg);
            this.intervalB.Location = new System.Drawing.Point(243, 15);
            this.intervalB.Name = "intervalB";
            this.intervalB.Size = new System.Drawing.Size(225, 74);
            this.intervalB.TabIndex = 19;
            this.intervalB.TabStop = false;
            this.intervalB.Text = "Interval B";
            // 
            // bEnd
            // 
            this.bEnd.Location = new System.Drawing.Point(137, 28);
            this.bEnd.Minimum = new decimal(new int[] {100, 0, 0, -2147483648});
            this.bEnd.Name = "bEnd";
            this.bEnd.Size = new System.Drawing.Size(82, 20);
            this.bEnd.TabIndex = 3;
            // 
            // bBeg
            // 
            this.bBeg.Location = new System.Drawing.Point(6, 28);
            this.bBeg.Minimum = new decimal(new int[] {100, 0, 0, -2147483648});
            this.bBeg.Name = "bBeg";
            this.bBeg.Size = new System.Drawing.Size(82, 20);
            this.bBeg.TabIndex = 2;
            // 
            // controllPanel
            // 
            this.controllPanel.Controls.Add(this.divBNUD);
            this.controllPanel.Controls.Add(this.multANUD);
            this.controllPanel.Controls.Add(this.subFromBNUD);
            this.controllPanel.Controls.Add(this.addToaNUD);
            this.controllPanel.Controls.Add(this.radioButton10);
            this.controllPanel.Controls.Add(this.radioButton1);
            this.controllPanel.Controls.Add(this.radioButton6);
            this.controllPanel.Controls.Add(this.radioButton5);
            this.controllPanel.Controls.Add(this.radioButton7);
            this.controllPanel.Controls.Add(this.radioButton8);
            this.controllPanel.Controls.Add(this.radioButton4);
            this.controllPanel.Controls.Add(this.radioButton9);
            this.controllPanel.Controls.Add(this.radioButton3);
            this.controllPanel.Controls.Add(this.radioButton2);
            this.controllPanel.Controls.Add(this.radioButton11);
            this.controllPanel.Controls.Add(this.radioButton14);
            this.controllPanel.Controls.Add(this.radioButton12);
            this.controllPanel.Controls.Add(this.radioButton13);
            this.controllPanel.Location = new System.Drawing.Point(12, 92);
            this.controllPanel.Name = "controllPanel";
            this.controllPanel.Size = new System.Drawing.Size(417, 232);
            this.controllPanel.TabIndex = 19;
            this.controllPanel.TabStop = false;
            this.controllPanel.Text = "Operation";
            // 
            // divBNUD
            // 
            this.divBNUD.Enabled = false;
            this.divBNUD.Location = new System.Drawing.Point(297, 114);
            this.divBNUD.Name = "divBNUD";
            this.divBNUD.Size = new System.Drawing.Size(82, 20);
            this.divBNUD.TabIndex = 16;
            // 
            // multANUD
            // 
            this.multANUD.Enabled = false;
            this.multANUD.Location = new System.Drawing.Point(297, 80);
            this.multANUD.Name = "multANUD";
            this.multANUD.Size = new System.Drawing.Size(82, 20);
            this.multANUD.TabIndex = 15;
            // 
            // subFromBNUD
            // 
            this.subFromBNUD.Enabled = false;
            this.subFromBNUD.Location = new System.Drawing.Point(297, 50);
            this.subFromBNUD.Name = "subFromBNUD";
            this.subFromBNUD.Size = new System.Drawing.Size(82, 20);
            this.subFromBNUD.TabIndex = 14;
            // 
            // addToaNUD
            // 
            this.addToaNUD.Enabled = false;
            this.addToaNUD.Location = new System.Drawing.Point(297, 24);
            this.addToaNUD.Name = "addToaNUD";
            this.addToaNUD.Size = new System.Drawing.Size(82, 20);
            this.addToaNUD.TabIndex = 2;
            // 
            // radioButton10
            // 
            this.radioButton10.Location = new System.Drawing.Point(132, 83);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(119, 24);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Multiply A by a num";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // result
            // 
            this.result.Controls.Add(this.toB);
            this.result.Controls.Add(this.toA);
            this.result.Location = new System.Drawing.Point(474, 15);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(225, 74);
            this.result.TabIndex = 20;
            this.result.TabStop = false;
            this.result.Text = "Result";
            // 
            // toB
            // 
            this.toB.Location = new System.Drawing.Point(95, 44);
            this.toB.Name = "toB";
            this.toB.Size = new System.Drawing.Size(130, 24);
            this.toB.TabIndex = 2;
            this.toB.TabStop = true;
            this.toB.Text = "To B";
            this.toB.UseVisualStyleBackColor = true;
            // 
            // toA
            // 
            this.toA.Location = new System.Drawing.Point(6, 44);
            this.toA.Name = "toA";
            this.toA.Size = new System.Drawing.Size(104, 24);
            this.toA.TabIndex = 1;
            this.toA.TabStop = true;
            this.toA.Text = "To A";
            this.toA.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(435, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 232);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Graphic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 374);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.result);
            this.Controls.Add(this.controllPanel);
            this.Controls.Add(this.intervalB);
            this.Controls.Add(this.intervalA);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.intervalA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.aEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.aBeg)).EndInit();
            this.intervalB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.bEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bBeg)).EndInit();
            this.controllPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.divBNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.multANUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.subFromBNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.addToaNUD)).EndInit();
            this.result.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton toA;
        private System.Windows.Forms.RadioButton toB;

        private System.Windows.Forms.RadioButton radioButton9;

        private System.Windows.Forms.NumericUpDown aBeg;
        private System.Windows.Forms.NumericUpDown addToaNUD;
        private System.Windows.Forms.NumericUpDown aEnd;
        private System.Windows.Forms.NumericUpDown bBeg;
        private System.Windows.Forms.NumericUpDown bEnd;
        private System.Windows.Forms.NumericUpDown divBNUD;
        private System.Windows.Forms.NumericUpDown multANUD;
        private System.Windows.Forms.NumericUpDown subFromBNUD;

        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.RadioButton radioButton8;

        private System.Windows.Forms.GroupBox controllPanel;
        private System.Windows.Forms.GroupBox intervalA;
        private System.Windows.Forms.GroupBox intervalB;
        private System.Windows.Forms.GroupBox result;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;

        #endregion
    }
}