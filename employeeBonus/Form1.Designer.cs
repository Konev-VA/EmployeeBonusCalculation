namespace employeeBonus
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bonusValue = new System.Windows.Forms.TextBox();
            this.employeeInfo = new System.Windows.Forms.TextBox();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.fio = new System.Windows.Forms.Label();
            this.dolzhnost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 258);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(716, 37);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(28, 20);
            this.search.TabIndex = 2;
            this.search.Text = "🔍";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(494, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "СУММА ПРЕМИИ: ";
            // 
            // bonusValue
            // 
            this.bonusValue.Location = new System.Drawing.Point(637, 114);
            this.bonusValue.Name = "bonusValue";
            this.bonusValue.Size = new System.Drawing.Size(107, 20);
            this.bonusValue.TabIndex = 4;
            // 
            // employeeInfo
            // 
            this.employeeInfo.Location = new System.Drawing.Point(498, 181);
            this.employeeInfo.Multiline = true;
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.Size = new System.Drawing.Size(246, 143);
            this.employeeInfo.TabIndex = 5;
            // 
            // previous
            // 
            this.previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previous.Location = new System.Drawing.Point(498, 393);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 29);
            this.previous.TabIndex = 6;
            this.previous.Text = "<<";
            this.previous.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(669, 392);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 30);
            this.next.TabIndex = 7;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.Location = new System.Drawing.Point(65, 37);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(194, 20);
            this.fio.TabIndex = 8;
            this.fio.Text = "Фамилия Имя Отчество";
            // 
            // dolzhnost
            // 
            this.dolzhnost.AutoSize = true;
            this.dolzhnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dolzhnost.Location = new System.Drawing.Point(104, 71);
            this.dolzhnost.Name = "dolzhnost";
            this.dolzhnost.Size = new System.Drawing.Size(95, 20);
            this.dolzhnost.TabIndex = 9;
            this.dolzhnost.Text = "Должность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dolzhnost);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.employeeInfo);
            this.Controls.Add(this.bonusValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bonusValue;
        private System.Windows.Forms.TextBox employeeInfo;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Label dolzhnost;
    }
}

