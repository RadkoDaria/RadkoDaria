﻿namespace calculator
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
            this.SuspendLayout();
            // 
            // InputVar1
            // 
            this.InputVar1.Location = new System.Drawing.Point(132, 90);
            this.InputVar1.Name = "InputVar1";
            this.InputVar1.Size = new System.Drawing.Size(100, 20);
            this.InputVar1.TabIndex = 0;
            this.InputVar1.TextChanged += new System.EventHandler(this.InputVar1_TextChanged);
            // 
            // InputVar2
            // 
            this.InputVar2.Location = new System.Drawing.Point(257, 90);
            this.InputVar2.Name = "InputVar2";
            this.InputVar2.Size = new System.Drawing.Size(100, 20);
            this.InputVar2.TabIndex = 1;
            // 
            // OutputVar
            // 
            this.OutputVar.AutoSize = true;
            this.OutputVar.Location = new System.Drawing.Point(390, 90);
            this.OutputVar.Name = "OutputVar";
            this.OutputVar.Size = new System.Drawing.Size(42, 13);
            this.OutputVar.TabIndex = 2;
            this.OutputVar.Text = "Answer";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(138, 169);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(228, 169);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(228, 210);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 5;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(138, 210);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 6;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.OutputVar);
            this.Controls.Add(this.InputVar2);
            this.Controls.Add(this.InputVar1);
            this.Name = "Form1";
            this.Text = "v";
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
    }
}

