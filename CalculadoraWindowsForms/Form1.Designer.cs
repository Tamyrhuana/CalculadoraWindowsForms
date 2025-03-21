namespace CalculadoraWindowsForms
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
            txtOperacao = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btnSomar = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            btnResultado = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtOperacao
            // 
            txtOperacao.Enabled = false;
            txtOperacao.Location = new Point(20, 33);
            txtOperacao.Multiline = true;
            txtOperacao.Name = "txtOperacao";
            txtOperacao.Size = new Size(197, 52);
            txtOperacao.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(20, 99);
            btn1.Name = "btn1";
            btn1.Size = new Size(53, 52);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(93, 99);
            btn2.Name = "btn2";
            btn2.Size = new Size(53, 52);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(164, 99);
            btn3.Name = "btn3";
            btn3.Size = new Size(53, 52);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(20, 170);
            btn4.Name = "btn4";
            btn4.Size = new Size(53, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(93, 170);
            btn5.Name = "btn5";
            btn5.Size = new Size(53, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(164, 170);
            button6.Name = "button6";
            button6.Size = new Size(53, 52);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(20, 242);
            button7.Name = "button7";
            button7.Size = new Size(53, 52);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(93, 242);
            button8.Name = "button8";
            button8.Size = new Size(53, 52);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(164, 242);
            button9.Name = "button9";
            button9.Size = new Size(53, 52);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(20, 321);
            button10.Name = "button10";
            button10.Size = new Size(53, 52);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(267, 33);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(53, 52);
            btnSomar.TabIndex = 11;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // button12
            // 
            button12.Location = new Point(267, 99);
            button12.Name = "button12";
            button12.Size = new Size(53, 52);
            button12.TabIndex = 12;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(267, 170);
            button13.Name = "button13";
            button13.Size = new Size(53, 52);
            button13.TabIndex = 13;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(267, 242);
            button14.Name = "button14";
            button14.Size = new Size(53, 52);
            button14.TabIndex = 14;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(267, 321);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(53, 52);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(93, 321);
            button1.Name = "button1";
            button1.Size = new Size(124, 52);
            button1.TabIndex = 16;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 409);
            Controls.Add(button1);
            Controls.Add(btnResultado);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(btnSomar);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtOperacao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperacao;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnSomar;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button btnResultado;
        private Button button1;
    }
}
