namespace TestProject
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Sentence = new System.Windows.Forms.TextBox();
            this.deleteS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(29, 57);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(220, 42);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Select the file:";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Word.Location = new System.Drawing.Point(305, 57);
            this.Word.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Word.Multiline = true;
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(383, 41);
            this.Word.TabIndex = 1;
            this.Word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Word.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Word_KeyPress);
            // 
            // Enter
            // 
            this.Enter.Image = global::TestProject.Properties.Resources.if_Select_22735;
            this.Enter.Location = new System.Drawing.Point(749, 57);
            this.Enter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(56, 41);
            this.Enter.TabIndex = 2;
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "TXT files|*.txt;";
            // 
            // Sentence
            // 
            this.Sentence.Location = new System.Drawing.Point(29, 136);
            this.Sentence.Multiline = true;
            this.Sentence.Name = "Sentence";
            this.Sentence.Size = new System.Drawing.Size(659, 181);
            this.Sentence.TabIndex = 3;
            this.Sentence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sentence_KeyPress);
            // 
            // deleteS
            // 
            this.deleteS.Location = new System.Drawing.Point(722, 174);
            this.deleteS.Name = "deleteS";
            this.deleteS.Size = new System.Drawing.Size(83, 103);
            this.deleteS.TabIndex = 4;
            this.deleteS.Text = "Delete all sentences";
            this.deleteS.UseVisualStyleBackColor = true;
            this.deleteS.Click += new System.EventHandler(this.deleteS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 375);
            this.Controls.Add(this.deleteS);
            this.Controls.Add(this.Sentence);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.OpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Test Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Sentence;
        private System.Windows.Forms.Button deleteS;
    }
}

