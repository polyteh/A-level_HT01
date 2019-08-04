namespace QuadraticEquationForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_coefA = new System.Windows.Forms.TextBox();
            this.tb_coefB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_coefC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_X1 = new System.Windows.Forms.TextBox();
            this.tb_X2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_warning = new System.Windows.Forms.Label();
            this.lb_Decomp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // tb_coefA
            // 
            this.tb_coefA.Location = new System.Drawing.Point(108, 37);
            this.tb_coefA.Name = "tb_coefA";
            this.tb_coefA.Size = new System.Drawing.Size(97, 20);
            this.tb_coefA.TabIndex = 1;
            // 
            // tb_coefB
            // 
            this.tb_coefB.Location = new System.Drawing.Point(108, 79);
            this.tb_coefB.Name = "tb_coefB";
            this.tb_coefB.Size = new System.Drawing.Size(97, 20);
            this.tb_coefB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // tb_coefC
            // 
            this.tb_coefC.Location = new System.Drawing.Point(108, 127);
            this.tb_coefC.Name = "tb_coefC";
            this.tb_coefC.Size = new System.Drawing.Size(97, 20);
            this.tb_coefC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Initial data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "X1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "X2";
            // 
            // tb_X1
            // 
            this.tb_X1.Location = new System.Drawing.Point(555, 37);
            this.tb_X1.Name = "tb_X1";
            this.tb_X1.Size = new System.Drawing.Size(100, 20);
            this.tb_X1.TabIndex = 10;
            // 
            // tb_X2
            // 
            this.tb_X2.Location = new System.Drawing.Point(555, 72);
            this.tb_X2.Name = "tb_X2";
            this.tb_X2.Size = new System.Drawing.Size(100, 20);
            this.tb_X2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lb_warning
            // 
            this.lb_warning.AutoSize = true;
            this.lb_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_warning.ForeColor = System.Drawing.Color.Red;
            this.lb_warning.Location = new System.Drawing.Point(442, 203);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(87, 13);
            this.lb_warning.TabIndex = 13;
            this.lb_warning.Text = "Solving status";
            // 
            // lb_Decomp
            // 
            this.lb_Decomp.AutoSize = true;
            this.lb_Decomp.Location = new System.Drawing.Point(445, 129);
            this.lb_Decomp.Name = "lb_Decomp";
            this.lb_Decomp.Size = new System.Drawing.Size(35, 13);
            this.lb_Decomp.TabIndex = 14;
            this.lb_Decomp.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 479);
            this.Controls.Add(this.lb_Decomp);
            this.Controls.Add(this.lb_warning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_X2);
            this.Controls.Add(this.tb_X1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_coefC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_coefB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_coefA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_coefA;
        private System.Windows.Forms.TextBox tb_coefB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_coefC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_X1;
        private System.Windows.Forms.TextBox tb_X2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_warning;
        private System.Windows.Forms.Label lb_Decomp;
    }
}

