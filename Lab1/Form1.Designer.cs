namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewOperationBtn = new System.Windows.Forms.Button();
            this.ShowOperationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewOperationBtn
            // 
            this.NewOperationBtn.Location = new System.Drawing.Point(12, 12);
            this.NewOperationBtn.Name = "NewOperationBtn";
            this.NewOperationBtn.Size = new System.Drawing.Size(135, 57);
            this.NewOperationBtn.TabIndex = 0;
            this.NewOperationBtn.Text = "Создать операцию";
            this.NewOperationBtn.UseVisualStyleBackColor = true;
            this.NewOperationBtn.Click += new System.EventHandler(this.NewOperationBtn_Click);
            // 
            // ShowOperationBtn
            // 
            this.ShowOperationBtn.Location = new System.Drawing.Point(12, 75);
            this.ShowOperationBtn.Name = "ShowOperationBtn";
            this.ShowOperationBtn.Size = new System.Drawing.Size(135, 57);
            this.ShowOperationBtn.TabIndex = 1;
            this.ShowOperationBtn.Text = "Посмотреть операции";
            this.ShowOperationBtn.UseVisualStyleBackColor = true;
            this.ShowOperationBtn.Click += new System.EventHandler(this.ShowOperationBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 170);
            this.Controls.Add(this.ShowOperationBtn);
            this.Controls.Add(this.NewOperationBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOperationBtn;
        private System.Windows.Forms.Button ShowOperationBtn;
    }
}

