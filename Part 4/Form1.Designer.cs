namespace Part_4
{
    partial class RandomNumber
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
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.numMA = new System.Windows.Forms.NumericUpDown();
            this.numMI = new System.Windows.Forms.NumericUpDown();
            this.lblRan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(2, 186);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(98, 23);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "Click For Integer";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(134, 186);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(108, 23);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "Click For Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(27, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Enter Two Random Numbers Below";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(2, 76);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(81, 13);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Minimum Value:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(-1, 133);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(84, 13);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Maximum Value:";
            // 
            // numMA
            // 
            this.numMA.Location = new System.Drawing.Point(89, 131);
            this.numMA.Name = "numMA";
            this.numMA.Size = new System.Drawing.Size(120, 20);
            this.numMA.TabIndex = 5;
            // 
            // numMI
            // 
            this.numMI.Location = new System.Drawing.Point(89, 74);
            this.numMI.Name = "numMI";
            this.numMI.Size = new System.Drawing.Size(120, 20);
            this.numMI.TabIndex = 6;
            // 
            // lblRan
            // 
            this.lblRan.AutoSize = true;
            this.lblRan.Location = new System.Drawing.Point(12, 233);
            this.lblRan.Name = "lblRan";
            this.lblRan.Size = new System.Drawing.Size(35, 13);
            this.lblRan.TabIndex = 7;
            this.lblRan.Text = "label1";
            // 
            // RandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.lblRan);
            this.Controls.Add(this.numMI);
            this.Controls.Add(this.numMA);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Name = "RandomNumber";
            this.Text = "Random Number";
            this.Load += new System.EventHandler(this.RandomNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numMA;
        private System.Windows.Forms.NumericUpDown numMI;
        private System.Windows.Forms.Label lblRan;
    }
}

