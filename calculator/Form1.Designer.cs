namespace calculator
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
            this.InputVar1 = new System.Windows.Forms.TextBox();
            this.InputVar2 = new System.Windows.Forms.TextBox();
            this.OutputVar = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Log2 = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.Degree2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputVar1
            // 
            this.InputVar1.Location = new System.Drawing.Point(36, 27);
            this.InputVar1.Name = "InputVar1";
            this.InputVar1.Size = new System.Drawing.Size(100, 20);
            this.InputVar1.TabIndex = 0;
            this.InputVar1.TextChanged += new System.EventHandler(this.InputVar1_TextChanged);
            // 
            // InputVar2
            // 
            this.InputVar2.Location = new System.Drawing.Point(156, 27);
            this.InputVar2.Name = "InputVar2";
            this.InputVar2.Size = new System.Drawing.Size(100, 20);
            this.InputVar2.TabIndex = 1;
            // 
            // OutputVar
            // 
            this.OutputVar.AutoSize = true;
            this.OutputVar.Location = new System.Drawing.Point(277, 34);
            this.OutputVar.Name = "OutputVar";
            this.OutputVar.Size = new System.Drawing.Size(42, 13);
            this.OutputVar.TabIndex = 2;
            this.OutputVar.Text = "Answer";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(36, 69);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.CalculateClick);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(117, 69);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.CalculateClick);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(279, 69);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 5;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.CalculateClick);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(198, 69);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 6;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.CalculateClick);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(36, 98);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(117, 98);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(198, 98);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 9;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(36, 127);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(75, 23);
            this.Ln.TabIndex = 10;
            this.Ln.Text = "ln(x)";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(279, 98);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(75, 23);
            this.Exp.TabIndex = 11;
            this.Exp.Text = "e^x";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(198, 127);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 23);
            this.Arcsin.TabIndex = 12;
            this.Arcsin.Text = "Arcsin(x)";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(117, 127);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 13;
            this.Arccos.Text = "Arccos(x)";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Log2
            // 
            this.Log2.Location = new System.Drawing.Point(279, 127);
            this.Log2.Name = "Log2";
            this.Log2.Size = new System.Drawing.Size(75, 23);
            this.Log2.TabIndex = 14;
            this.Log2.Text = "Log2(x)";
            this.Log2.UseVisualStyleBackColor = true;
            this.Log2.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(36, 156);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(75, 23);
            this.Log10.TabIndex = 15;
            this.Log10.Text = "Log10(x)";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // Degree2
            // 
            this.Degree2.Location = new System.Drawing.Point(117, 156);
            this.Degree2.Name = "Degree2";
            this.Degree2.Size = new System.Drawing.Size(75, 23);
            this.Degree2.TabIndex = 16;
            this.Degree2.Text = "x^2";
            this.Degree2.UseVisualStyleBackColor = true;
            this.Degree2.Click += new System.EventHandler(this.Calculator2Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Degree2);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Log2);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.OutputVar);
            this.Controls.Add(this.InputVar2);
            this.Controls.Add(this.InputVar1);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputVar1;
        private System.Windows.Forms.TextBox InputVar2;
        private System.Windows.Forms.Label OutputVar;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Log2;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Degree2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

