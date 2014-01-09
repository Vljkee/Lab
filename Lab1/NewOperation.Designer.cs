namespace Lab1
{
    partial class NewOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DoctorTB = new System.Windows.Forms.TextBox();
            this.OperationTB = new System.Windows.Forms.TextBox();
            this.PatientTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(191, 158);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(171, 23);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Создать операцию";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DoctorTB
            // 
            this.DoctorTB.Location = new System.Drawing.Point(74, 60);
            this.DoctorTB.Name = "DoctorTB";
            this.DoctorTB.Size = new System.Drawing.Size(288, 20);
            this.DoctorTB.TabIndex = 1;
            // 
            // OperationTB
            // 
            this.OperationTB.Location = new System.Drawing.Point(74, 112);
            this.OperationTB.Name = "OperationTB";
            this.OperationTB.Size = new System.Drawing.Size(288, 20);
            this.OperationTB.TabIndex = 2;
            // 
            // PatientTB
            // 
            this.PatientTB.Location = new System.Drawing.Point(74, 86);
            this.PatientTB.Name = "PatientTB";
            this.PatientTB.Size = new System.Drawing.Size(288, 20);
            this.PatientTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Доктор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пациент:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Операция:";
            // 
            // NewOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientTB);
            this.Controls.Add(this.OperationTB);
            this.Controls.Add(this.DoctorTB);
            this.Controls.Add(this.CreateBtn);
            this.Name = "NewOperation";
            this.Text = "NewOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox DoctorTB;
        private System.Windows.Forms.TextBox OperationTB;
        private System.Windows.Forms.TextBox PatientTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}