namespace CalculadoraBase
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
            display = new TextBox();
            b1 = new Button();
            bsoma = new Button();
            bigual = new Button();
            bvirgula = new Button();
            bclear = new Button();
            b2 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button8 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            créditosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Location = new Point(12, 26);
            display.Margin = new Padding(3, 2, 3, 2);
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(211, 23);
            display.TabIndex = 0;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.Location = new Point(12, 105);
            b1.Margin = new Padding(3, 2, 3, 2);
            b1.Name = "b1";
            b1.Size = new Size(32, 22);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // bsoma
            // 
            bsoma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsoma.Location = new Point(125, 53);
            bsoma.Margin = new Padding(3, 2, 3, 2);
            bsoma.Name = "bsoma";
            bsoma.Size = new Size(32, 30);
            bsoma.TabIndex = 2;
            bsoma.Text = "+";
            bsoma.TextAlign = ContentAlignment.BottomCenter;
            bsoma.UseVisualStyleBackColor = true;
            bsoma.Click += bsoma_Click;
            // 
            // bigual
            // 
            bigual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bigual.Location = new Point(125, 129);
            bigual.Margin = new Padding(3, 2, 3, 2);
            bigual.Name = "bigual";
            bigual.Size = new Size(32, 22);
            bigual.TabIndex = 3;
            bigual.Text = "=";
            bigual.TextAlign = ContentAlignment.BottomCenter;
            bigual.UseVisualStyleBackColor = true;
            bigual.Click += bigual_Click;
            // 
            // bvirgula
            // 
            bvirgula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bvirgula.Location = new Point(125, 87);
            bvirgula.Margin = new Padding(3, 2, 3, 2);
            bvirgula.Name = "bvirgula";
            bvirgula.Size = new Size(32, 38);
            bvirgula.TabIndex = 4;
            bvirgula.Text = ",";
            bvirgula.UseVisualStyleBackColor = true;
            bvirgula.Click += bvirgula_Click;
            // 
            // bclear
            // 
            bclear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bclear.Location = new Point(50, 129);
            bclear.Margin = new Padding(3, 2, 3, 2);
            bclear.Name = "bclear";
            bclear.Size = new Size(32, 22);
            bclear.TabIndex = 5;
            bclear.Text = "C";
            bclear.UseVisualStyleBackColor = true;
            bclear.Click += bclear_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b2.Location = new Point(50, 105);
            b2.Margin = new Padding(3, 2, 3, 2);
            b2.Name = "b2";
            b2.Size = new Size(32, 22);
            b2.TabIndex = 7;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(12, 131);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(32, 22);
            button1.TabIndex = 16;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button0_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(158, 54);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(32, 29);
            button2.TabIndex = 18;
            button2.Text = "-";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += bsubtracao_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(88, 105);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(32, 22);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(12, 79);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(32, 22);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(50, 79);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(32, 22);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(88, 79);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(32, 22);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(12, 53);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(32, 22);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button9.Location = new Point(88, 53);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(32, 22);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button10.Location = new Point(50, 53);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(32, 22);
            button10.TabIndex = 15;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button8_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button11.Location = new Point(88, 129);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(32, 22);
            button11.TabIndex = 17;
            button11.Text = "⌫";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonApagar_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button8.Location = new Point(158, 87);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(32, 31);
            button8.TabIndex = 19;
            button8.Text = "/";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += bdivisao_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button12.Location = new Point(158, 119);
            button12.Margin = new Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new Size(32, 32);
            button12.TabIndex = 20;
            button12.Text = "*";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = true;
            button12.Click += bmultiplicacao_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button13.Location = new Point(191, 120);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Size = new Size(32, 31);
            button13.TabIndex = 21;
            button13.Text = "√";
            button13.TextAlign = ContentAlignment.TopCenter;
            button13.UseVisualStyleBackColor = true;
            button13.Click += braizquadrada_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button14.Location = new Point(191, 54);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new Size(32, 29);
            button14.TabIndex = 22;
            button14.Text = "x²";
            button14.TextAlign = ContentAlignment.TopCenter;
            button14.UseVisualStyleBackColor = true;
            button14.Click += bpotenciaDe2_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button15.Location = new Point(154, 151);
            button15.Margin = new Padding(3, 2, 3, 2);
            button15.Name = "button15";
            button15.Size = new Size(69, 31);
            button15.TabIndex = 23;
            button15.Text = "log₁₀";
            button15.TextAlign = ContentAlignment.TopCenter;
            button15.UseVisualStyleBackColor = true;
            button15.Click += bLog_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button16.Location = new Point(12, 155);
            button16.Margin = new Padding(3, 2, 3, 2);
            button16.Name = "button16";
            button16.Size = new Size(43, 27);
            button16.TabIndex = 24;
            button16.Text = "Tan";
            button16.TextAlign = ContentAlignment.BottomCenter;
            button16.UseVisualStyleBackColor = true;
            button16.Click += bTan_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button17.Location = new Point(58, 155);
            button17.Margin = new Padding(3, 2, 3, 2);
            button17.Name = "button17";
            button17.Size = new Size(43, 27);
            button17.TabIndex = 25;
            button17.Text = "Cos";
            button17.TextAlign = ContentAlignment.BottomCenter;
            button17.UseVisualStyleBackColor = true;
            button17.Click += bCos_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button18.Location = new Point(105, 155);
            button18.Margin = new Padding(3, 2, 3, 2);
            button18.Name = "button18";
            button18.Size = new Size(43, 27);
            button18.TabIndex = 26;
            button18.Text = "π";
            button18.TextAlign = ContentAlignment.BottomCenter;
            button18.UseVisualStyleBackColor = true;
            button18.Click += bPi_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button19.Location = new Point(191, 87);
            button19.Margin = new Padding(3, 2, 3, 2);
            button19.Name = "button19";
            button19.Size = new Size(32, 31);
            button19.TabIndex = 27;
            button19.Text = "x³";
            button19.TextAlign = ContentAlignment.TopCenter;
            button19.UseVisualStyleBackColor = true;
            button19.Click += bpotenciaDe3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem, créditosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(242, 24);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // créditosToolStripMenuItem
            // 
            créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            créditosToolStripMenuItem.Size = new Size(63, 20);
            créditosToolStripMenuItem.Text = "Créditos";
            créditosToolStripMenuItem.Click += créditosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 213);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button11);
            Controls.Add(button1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(b2);
            Controls.Add(bclear);
            Controls.Add(bvirgula);
            Controls.Add(bigual);
            Controls.Add(bsoma);
            Controls.Add(b1);
            Controls.Add(display);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculadora Base";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
		private Button b1;
		private Button bsoma;
		private Button bigual;
		private Button bvirgula;
		private Button bclear;
        private Button b2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button1;
        private Button button11;
        private Button button2;
        private Button button8;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem créditosToolStripMenuItem;
    }
}
