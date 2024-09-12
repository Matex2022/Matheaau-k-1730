namespace Exc1_Food_Truck
{
    partial class Ex1c_Food_Truck
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
            label1 = new Label();
            label2 = new Label();
            txtHotDogs = new TextBox();
            txtHamburgers = new TextBox();
            txtHamburgerTotal = new TextBox();
            txtHotDogsTotal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtTax = new TextBox();
            txtPretaxTotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTotal = new TextBox();
            label7 = new Label();
            bntCalculate = new Button();
            bntClear = new Button();
            bntExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Hot Dogs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Hamburgers";
            // 
            // txtHotDogs
            // 
            txtHotDogs.Location = new Point(126, 23);
            txtHotDogs.Name = "txtHotDogs";
            txtHotDogs.Size = new Size(100, 23);
            txtHotDogs.TabIndex = 1;
            // 
            // txtHamburgers
            // 
            txtHamburgers.Location = new Point(126, 70);
            txtHamburgers.Name = "txtHamburgers";
            txtHamburgers.Size = new Size(100, 23);
            txtHamburgers.TabIndex = 2;
            // 
            // txtHamburgerTotal
            // 
            txtHamburgerTotal.Location = new Point(392, 70);
            txtHamburgerTotal.Name = "txtHamburgerTotal";
            txtHamburgerTotal.ReadOnly = true;
            txtHamburgerTotal.Size = new Size(100, 23);
            txtHamburgerTotal.TabIndex = 7;
            txtHamburgerTotal.TabStop = false;
            // 
            // txtHotDogsTotal
            // 
            txtHotDogsTotal.Location = new Point(392, 23);
            txtHotDogsTotal.Name = "txtHotDogsTotal";
            txtHotDogsTotal.ReadOnly = true;
            txtHotDogsTotal.Size = new Size(100, 23);
            txtHotDogsTotal.TabIndex = 6;
            txtHotDogsTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 70);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "x $5.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 23);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "x $4.00";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(392, 160);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 11;
            txtTax.TabStop = false;
            // 
            // txtPretaxTotal
            // 
            txtPretaxTotal.Location = new Point(392, 113);
            txtPretaxTotal.Name = "txtPretaxTotal";
            txtPretaxTotal.ReadOnly = true;
            txtPretaxTotal.Size = new Size(100, 23);
            txtPretaxTotal.TabIndex = 10;
            txtPretaxTotal.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 160);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 9;
            label5.Text = "Tax";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 113);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 8;
            label6.Text = "Pretax Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(392, 212);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 15;
            txtTotal.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 212);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 13;
            label7.Text = "Total";
            // 
            // bntCalculate
            // 
            bntCalculate.Location = new Point(37, 304);
            bntCalculate.Name = "bntCalculate";
            bntCalculate.Size = new Size(75, 23);
            bntCalculate.TabIndex = 3;
            bntCalculate.Text = "&Calculate";
            bntCalculate.UseVisualStyleBackColor = true;
            // 
            // bntClear
            // 
            bntClear.Location = new Point(186, 304);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(75, 23);
            bntClear.TabIndex = 4;
            bntClear.Text = "C&lear";
            bntClear.UseVisualStyleBackColor = true;
            bntClear.Click += button2_Click;
            // 
            // bntExit
            // 
            bntExit.Location = new Point(331, 304);
            bntExit.Name = "bntExit";
            bntExit.Size = new Size(75, 23);
            bntExit.TabIndex = 5;
            bntExit.Text = "E&xit";
            bntExit.UseVisualStyleBackColor = true;
            bntExit.Click += bntExit_Click;
            // 
            // Ex1c_Food_Truck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 375);
            Controls.Add(bntExit);
            Controls.Add(bntClear);
            Controls.Add(bntCalculate);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(txtTax);
            Controls.Add(txtPretaxTotal);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtHamburgerTotal);
            Controls.Add(txtHotDogsTotal);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtHamburgers);
            Controls.Add(txtHotDogs);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex1c_Food_Truck";
            Text = "Ex1c Food Truck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHotDogs;
        private TextBox txtHamburgers;
        private TextBox txtHamburgerTotal;
        private TextBox txtHotDogsTotal;
        private Label label3;
        private Label label4;
        private TextBox txtTax;
        private TextBox txtPretaxTotal;
        private Label label5;
        private Label label6;
        private TextBox txtTotal;
        private Label label7;
        private Button bntCalculate;
        private Button bntClear;
        private Button bntExit;
    }
}
