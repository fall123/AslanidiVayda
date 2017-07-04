namespace ProjectYP
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.slojenie = new System.Windows.Forms.Button();
            this.vichitanye = new System.Windows.Forms.Button();
            this.umnojenie = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(177, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 2;
            // 
            // slojenie
            // 
            this.slojenie.Location = new System.Drawing.Point(27, 102);
            this.slojenie.Name = "slojenie";
            this.slojenie.Size = new System.Drawing.Size(75, 23);
            this.slojenie.TabIndex = 3;
            this.slojenie.Text = "+";
            this.slojenie.UseVisualStyleBackColor = true;
            this.slojenie.Click += new System.EventHandler(this.slojenie_Click_1);
            // 
            // vichitanye
            // 
            this.vichitanye.Location = new System.Drawing.Point(108, 102);
            this.vichitanye.Name = "vichitanye";
            this.vichitanye.Size = new System.Drawing.Size(75, 23);
            this.vichitanye.TabIndex = 4;
            this.vichitanye.Text = "-";
            this.vichitanye.UseVisualStyleBackColor = true;
            this.vichitanye.Click += new System.EventHandler(this.vichitanye_Click);
            // 
            // umnojenie
            // 
            this.umnojenie.Location = new System.Drawing.Point(27, 131);
            this.umnojenie.Name = "umnojenie";
            this.umnojenie.Size = new System.Drawing.Size(75, 23);
            this.umnojenie.TabIndex = 5;
            this.umnojenie.Text = "*";
            this.umnojenie.UseVisualStyleBackColor = true;
            this.umnojenie.Click += new System.EventHandler(this.umnojenie_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "/";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.delenie_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(786, 483);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.umnojenie);
            this.Controls.Add(this.vichitanye);
            this.Controls.Add(this.slojenie);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button slojenie;
        private System.Windows.Forms.Button vichitanye;
        private System.Windows.Forms.Button umnojenie;
        private System.Windows.Forms.Button button6;
    }
}

