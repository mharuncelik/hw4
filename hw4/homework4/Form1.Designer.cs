namespace homework4
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
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            btnMax = new Button();
            btnPower = new Button();
            btnIsPrime = new Button();
            btnFactorial = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(125, 112);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(165, 31);
            txtSayi1.TabIndex = 0;
            //
            // txtSayi2
            //
            txtSayi2.Location = new Point(502, 112);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(150, 31);
            txtSayi2.TabIndex = 1;
            // 
            // btnMax
            // 
            btnMax.Location = new Point(69, 235);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(118, 83);
            btnMax.TabIndex = 3;
            btnMax.Text = "Max";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnPower
            // 
            btnPower.Location = new Point(251, 236);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(118, 82);
            btnPower.TabIndex = 5;
            btnPower.Text = "Power";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // btnIsPrime
            // 
            btnIsPrime.Location = new Point(432, 236);
            btnIsPrime.Name = "btnIsPrime";
            btnIsPrime.Size = new Size(118, 83);
            btnIsPrime.TabIndex = 7;
            btnIsPrime.Text = "IsPrime";
            btnIsPrime.UseVisualStyleBackColor = true;
            btnIsPrime.Click += btnIsPrime_Click;
            // 
            // btnFactorial
            // 
            btnFactorial.Location = new Point(620, 237);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(118, 82);
            btnFactorial.TabIndex = 9;
            btnFactorial.Text = "Factorial";
            btnFactorial.UseVisualStyleBackColor = true;
            btnFactorial.Click += btnFactorial_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(125, 385);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(65, 25);
            lblSonuc.TabIndex = 10;
            lblSonuc.Text = "Sonuç:";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnFactorial);
            Controls.Add(btnIsPrime);
            Controls.Add(btnPower);
            Controls.Add(btnMax);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Button btnMax;
        private Button btnPower;
        private Button btnIsPrime;
        private Button btnFactorial;
        private Label lblSonuc;
    }
}
