﻿namespace CalculadoraWindowsForms
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
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicao = new Button();
            btnDivisao = new Button();
            btnIgual = new Button();
            btnLimpar = new Button();
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
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(20, 170);
            btn4.Name = "btn4";
            btn4.Size = new Size(53, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(93, 170);
            btn5.Name = "btn5";
            btn5.Size = new Size(53, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(164, 170);
            btn6.Name = "btn6";
            btn6.Size = new Size(53, 52);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(20, 242);
            btn7.Name = "btn7";
            btn7.Size = new Size(53, 52);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(93, 242);
            btn8.Name = "btn8";
            btn8.Size = new Size(53, 52);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(164, 242);
            btn9.Name = "btn9";
            btn9.Size = new Size(53, 52);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(20, 321);
            btn0.Name = "btn0";
            btn0.Size = new Size(53, 52);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(267, 33);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(53, 52);
            btnSoma.TabIndex = 11;
            btnSoma.Text = "+";
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(267, 99);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(53, 52);
            btnSubtracao.TabIndex = 12;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicao
            // 
            btnMultiplicao.Location = new Point(267, 170);
            btnMultiplicao.Name = "btnMultiplicao";
            btnMultiplicao.Size = new Size(53, 52);
            btnMultiplicao.TabIndex = 13;
            btnMultiplicao.Text = "*";
            btnMultiplicao.UseVisualStyleBackColor = true;
            btnMultiplicao.Click += btnMultiplicao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(267, 242);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(53, 52);
            btnDivisao.TabIndex = 14;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(267, 321);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(53, 52);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(93, 321);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(124, 52);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 409);
            Controls.Add(btnLimpar);
            Controls.Add(btnIgual);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
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
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicao;
        private Button btnDivisao;
        private Button btnIgual;
        private Button btnLimpar;
    }
}
