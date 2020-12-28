namespace СourseWorkAfanasieva
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
            this.disk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioGigabyte = new System.Windows.Forms.RadioButton();
            this.radioPercent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.persent = new System.Windows.Forms.NumericUpDown();
            this.gigabyte = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.persent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gigabyte)).BeginInit();
            this.SuspendLayout();
            // 
            // disk
            // 
            this.disk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disk.FormattingEnabled = true;
            this.disk.Location = new System.Drawing.Point(287, 38);
            this.disk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disk.Name = "disk";
            this.disk.Size = new System.Drawing.Size(136, 24);
            this.disk.TabIndex = 0;
            this.disk.SelectedIndexChanged += new System.EventHandler(this.disk_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите диск:";
            // 
            // radioGigabyte
            // 
            this.radioGigabyte.AutoSize = true;
            this.radioGigabyte.Location = new System.Drawing.Point(287, 183);
            this.radioGigabyte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioGigabyte.Name = "radioGigabyte";
            this.radioGigabyte.Size = new System.Drawing.Size(45, 21);
            this.radioGigabyte.TabIndex = 2;
            this.radioGigabyte.TabStop = true;
            this.radioGigabyte.Text = "Гб";
            this.radioGigabyte.UseVisualStyleBackColor = true;
            this.radioGigabyte.CheckedChanged += new System.EventHandler(this.radioButton_checkedChanged);
            this.radioGigabyte.VisibleChanged += new System.EventHandler(this.radioButton_checkedChanged);
            // 
            // radioPercent
            // 
            this.radioPercent.AutoSize = true;
            this.radioPercent.Location = new System.Drawing.Point(287, 135);
            this.radioPercent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPercent.Name = "radioPercent";
            this.radioPercent.Size = new System.Drawing.Size(41, 21);
            this.radioPercent.TabIndex = 3;
            this.radioPercent.TabStop = true;
            this.radioPercent.Text = "%";
            this.radioPercent.UseVisualStyleBackColor = true;
            this.radioPercent.CheckedChanged += new System.EventHandler(this.radioButton_checkedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Уведомлять, если меньше  ";
            // 
            // persent
            // 
            this.persent.Location = new System.Drawing.Point(147, 135);
            this.persent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.persent.Name = "persent";
            this.persent.Size = new System.Drawing.Size(105, 22);
            this.persent.TabIndex = 5;
            this.persent.ValueChanged += new System.EventHandler(this.persent_ValueChanged);
            // 
            // gigabyte
            // 
            this.gigabyte.Location = new System.Drawing.Point(147, 183);
            this.gigabyte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gigabyte.Name = "gigabyte";
            this.gigabyte.Size = new System.Drawing.Size(107, 22);
            this.gigabyte.TabIndex = 6;
            this.gigabyte.ValueChanged += new System.EventHandler(this.gigabyte_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(120, 240);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(256, 240);
            this.Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 28);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 283);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gigabyte);
            this.Controls.Add(this.persent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioPercent);
            this.Controls.Add(this.radioGigabyte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CourseWork";
            ((System.ComponentModel.ISupportInitialize)(this.persent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gigabyte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox disk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioGigabyte;
        private System.Windows.Forms.RadioButton radioPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown persent;
        private System.Windows.Forms.NumericUpDown gigabyte;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button Stop;
    }
}

