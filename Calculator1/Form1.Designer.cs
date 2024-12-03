namespace Calculator1
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
            this.btnEqualize = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDivding = new System.Windows.Forms.Button();
            this.btnImpact = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEqualize
            // 
            this.btnEqualize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnEqualize.Location = new System.Drawing.Point(338, 225);
            this.btnEqualize.Name = "btnEqualize";
            this.btnEqualize.Size = new System.Drawing.Size(53, 105);
            this.btnEqualize.TabIndex = 32;
            this.btnEqualize.Text = "=";
            this.btnEqualize.UseVisualStyleBackColor = false;
            this.btnEqualize.Click += new System.EventHandler(this.btnEqualize_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnCE.Location = new System.Drawing.Point(338, 100);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(53, 44);
            this.btnCE.TabIndex = 31;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnDivding
            // 
            this.btnDivding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDivding.Location = new System.Drawing.Point(260, 100);
            this.btnDivding.Name = "btnDivding";
            this.btnDivding.Size = new System.Drawing.Size(53, 44);
            this.btnDivding.TabIndex = 30;
            this.btnDivding.Text = "/";
            this.btnDivding.UseVisualStyleBackColor = false;
            this.btnDivding.Click += new System.EventHandler(this.OptHesap);
            // 
            // btnImpact
            // 
            this.btnImpact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnImpact.Location = new System.Drawing.Point(260, 166);
            this.btnImpact.Name = "btnImpact";
            this.btnImpact.Size = new System.Drawing.Size(53, 44);
            this.btnImpact.TabIndex = 29;
            this.btnImpact.Text = "*";
            this.btnImpact.UseVisualStyleBackColor = false;
            this.btnImpact.Click += new System.EventHandler(this.OptHesap);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnComma.Location = new System.Drawing.Point(187, 286);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(53, 44);
            this.btnComma.TabIndex = 28;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnPlus.Location = new System.Drawing.Point(260, 285);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 44);
            this.btnPlus.TabIndex = 27;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.OptHesap);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.button10.Location = new System.Drawing.Point(46, 285);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 44);
            this.button10.TabIndex = 26;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber6
            // 
            this.btnNumber6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber6.Location = new System.Drawing.Point(187, 164);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(53, 44);
            this.btnNumber6.TabIndex = 25;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = false;
            this.btnNumber6.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber9
            // 
            this.btnNumber9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber9.Location = new System.Drawing.Point(187, 225);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(53, 44);
            this.btnNumber9.TabIndex = 24;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = false;
            this.btnNumber9.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber8
            // 
            this.btnNumber8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber8.Location = new System.Drawing.Point(115, 225);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(51, 44);
            this.btnNumber8.TabIndex = 23;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = false;
            this.btnNumber8.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber3
            // 
            this.btnNumber3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber3.Location = new System.Drawing.Point(187, 100);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(51, 44);
            this.btnNumber3.TabIndex = 22;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = false;
            this.btnNumber3.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber2
            // 
            this.btnNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber2.Location = new System.Drawing.Point(115, 100);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(51, 44);
            this.btnNumber2.TabIndex = 21;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = false;
            this.btnNumber2.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber4
            // 
            this.btnNumber4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber4.Location = new System.Drawing.Point(46, 164);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(51, 42);
            this.btnNumber4.TabIndex = 20;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = false;
            this.btnNumber4.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber7
            // 
            this.btnNumber7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber7.Location = new System.Drawing.Point(46, 225);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(51, 44);
            this.btnNumber7.TabIndex = 19;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = false;
            this.btnNumber7.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber1
            // 
            this.btnNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber1.Location = new System.Drawing.Point(46, 100);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(51, 44);
            this.btnNumber1.TabIndex = 18;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = false;
            this.btnNumber1.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnNumber5
            // 
            this.btnNumber5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnNumber5.Location = new System.Drawing.Point(115, 166);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(51, 44);
            this.btnNumber5.TabIndex = 17;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = false;
            this.btnNumber5.Click += new System.EventHandler(this.NumberEvent);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnMinus.Location = new System.Drawing.Point(260, 225);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 44);
            this.btnMinus.TabIndex = 34;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.OptHesap);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(338, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(59, 32);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 16);
            this.lbResult.TabIndex = 36;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.txtResult.Location = new System.Drawing.Point(46, 62);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(267, 22);
            this.txtResult.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnEqualize);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDivding);
            this.Controls.Add(this.btnImpact);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.btnNumber5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEqualize;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnDivding;
        private System.Windows.Forms.Button btnImpact;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}

