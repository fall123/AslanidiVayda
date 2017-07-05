namespace ProjectYP
{
    partial class bt_tan
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
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.bt_sin = new System.Windows.Forms.Button();
            this.bt_cos = new System.Windows.Forms.Button();
            this.bt_tn = new System.Windows.Forms.Button();
            this.bt_ctan = new System.Windows.Forms.Button();
            this.bt_exp = new System.Windows.Forms.Button();
            this.bt_log = new System.Windows.Forms.Button();
            this.bt_asin = new System.Windows.Forms.Button();
            this.bt_acos = new System.Windows.Forms.Button();
            this.bt_atan = new System.Windows.Forms.Button();
            this.bt_actan = new System.Windows.Forms.Button();
            this.xpowery = new System.Windows.Forms.Button();
            this.logXY = new System.Windows.Forms.Button();
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
            // add
            // 
            this.add.Location = new System.Drawing.Point(27, 102);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.buttonClick);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(108, 102);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.buttonClick);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(27, 131);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 23);
            this.mul.TabIndex = 5;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.buttonClick);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(108, 131);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 6;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.buttonClick);
            // 
            // bt_sin
            // 
            this.bt_sin.Location = new System.Drawing.Point(240, 102);
            this.bt_sin.Name = "bt_sin";
            this.bt_sin.Size = new System.Drawing.Size(75, 34);
            this.bt_sin.TabIndex = 7;
            this.bt_sin.Text = "sin";
            this.bt_sin.UseVisualStyleBackColor = true;
            this.bt_sin.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_cos
            // 
            this.bt_cos.Location = new System.Drawing.Point(240, 142);
            this.bt_cos.Name = "bt_cos";
            this.bt_cos.Size = new System.Drawing.Size(75, 37);
            this.bt_cos.TabIndex = 8;
            this.bt_cos.Text = "cos";
            this.bt_cos.UseVisualStyleBackColor = true;
            this.bt_cos.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_tn
            // 
            this.bt_tn.Location = new System.Drawing.Point(321, 102);
            this.bt_tn.Name = "bt_tn";
            this.bt_tn.Size = new System.Drawing.Size(75, 34);
            this.bt_tn.TabIndex = 9;
            this.bt_tn.Text = "tan";
            this.bt_tn.UseVisualStyleBackColor = true;
            this.bt_tn.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_ctan
            // 
            this.bt_ctan.Location = new System.Drawing.Point(321, 142);
            this.bt_ctan.Name = "bt_ctan";
            this.bt_ctan.Size = new System.Drawing.Size(75, 37);
            this.bt_ctan.TabIndex = 10;
            this.bt_ctan.Text = "ctan";
            this.bt_ctan.UseVisualStyleBackColor = true;
            this.bt_ctan.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_exp
            // 
            this.bt_exp.Location = new System.Drawing.Point(465, 102);
            this.bt_exp.Name = "bt_exp";
            this.bt_exp.Size = new System.Drawing.Size(75, 34);
            this.bt_exp.TabIndex = 11;
            this.bt_exp.Text = "e^x";
            this.bt_exp.UseVisualStyleBackColor = true;
            this.bt_exp.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_log
            // 
            this.bt_log.Location = new System.Drawing.Point(465, 142);
            this.bt_log.Name = "bt_log";
            this.bt_log.Size = new System.Drawing.Size(75, 37);
            this.bt_log.TabIndex = 12;
            this.bt_log.Text = "Ln";
            this.bt_log.UseVisualStyleBackColor = true;
            this.bt_log.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_asin
            // 
            this.bt_asin.Location = new System.Drawing.Point(240, 185);
            this.bt_asin.Name = "bt_asin";
            this.bt_asin.Size = new System.Drawing.Size(75, 37);
            this.bt_asin.TabIndex = 13;
            this.bt_asin.Text = "arcsin";
            this.bt_asin.UseVisualStyleBackColor = true;
            this.bt_asin.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_acos
            // 
            this.bt_acos.Location = new System.Drawing.Point(321, 185);
            this.bt_acos.Name = "bt_acos";
            this.bt_acos.Size = new System.Drawing.Size(75, 37);
            this.bt_acos.TabIndex = 14;
            this.bt_acos.Text = "arccos";
            this.bt_acos.UseVisualStyleBackColor = true;
            this.bt_acos.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_atan
            // 
            this.bt_atan.Location = new System.Drawing.Point(240, 228);
            this.bt_atan.Name = "bt_atan";
            this.bt_atan.Size = new System.Drawing.Size(75, 37);
            this.bt_atan.TabIndex = 15;
            this.bt_atan.Text = "arctan";
            this.bt_atan.UseVisualStyleBackColor = true;
            this.bt_atan.Click += new System.EventHandler(this.oneArgclick);
            // 
            // bt_actan
            // 
            this.bt_actan.Location = new System.Drawing.Point(321, 228);
            this.bt_actan.Name = "bt_actan";
            this.bt_actan.Size = new System.Drawing.Size(75, 37);
            this.bt_actan.TabIndex = 16;
            this.bt_actan.Text = "arcctan";
            this.bt_actan.UseVisualStyleBackColor = true;
            this.bt_actan.Click += new System.EventHandler(this.oneArgclick);
            // 
            // xpowery
            // 
            this.xpowery.Location = new System.Drawing.Point(27, 185);
            this.xpowery.Name = "xpowery";
            this.xpowery.Size = new System.Drawing.Size(75, 34);
            this.xpowery.TabIndex = 17;
            this.xpowery.Text = "x^y";
            this.xpowery.UseVisualStyleBackColor = true;
            this.xpowery.Click += new System.EventHandler(this.buttonClick);
            // 
            // logXY
            // 
            this.logXY.Location = new System.Drawing.Point(108, 185);
            this.logXY.Name = "logXY";
            this.logXY.Size = new System.Drawing.Size(75, 34);
            this.logXY.TabIndex = 18;
            this.logXY.Text = "LogXY";
            this.logXY.UseVisualStyleBackColor = true;
            this.logXY.Click += new System.EventHandler(this.buttonClick);
            // 
            // bt_tan
            // 
            this.ClientSize = new System.Drawing.Size(786, 483);
            this.Controls.Add(this.logXY);
            this.Controls.Add(this.xpowery);
            this.Controls.Add(this.bt_actan);
            this.Controls.Add(this.bt_atan);
            this.Controls.Add(this.bt_acos);
            this.Controls.Add(this.bt_asin);
            this.Controls.Add(this.bt_log);
            this.Controls.Add(this.bt_exp);
            this.Controls.Add(this.bt_ctan);
            this.Controls.Add(this.bt_tn);
            this.Controls.Add(this.bt_cos);
            this.Controls.Add(this.bt_sin);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Name = "bt_tan";
            this.Click += new System.EventHandler(this.oneArgclick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button bt_sin;
        private System.Windows.Forms.Button bt_cos;
        private System.Windows.Forms.Button bt_tn;
        private System.Windows.Forms.Button bt_ctan;
        private System.Windows.Forms.Button bt_exp;
        private System.Windows.Forms.Button bt_log;
        private System.Windows.Forms.Button bt_asin;
        private System.Windows.Forms.Button bt_acos;
        private System.Windows.Forms.Button bt_atan;
        private System.Windows.Forms.Button bt_actan;
        private System.Windows.Forms.Button xpowery;
        private System.Windows.Forms.Button logXY;
    }
}

