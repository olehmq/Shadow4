namespace Shadow4
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
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.characterDetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // characterListBox
            // 
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.Location = new System.Drawing.Point(159, 99);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(120, 95);
            this.characterListBox.TabIndex = 0;
            this.characterListBox.SelectedIndexChanged += new System.EventHandler(this.characterListBox_SelectedIndexChanged);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(405, 130);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Купити";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // characterDetailsLabel
            // 
            this.characterDetailsLabel.AutoSize = true;
            this.characterDetailsLabel.Location = new System.Drawing.Point(336, 190);
            this.characterDetailsLabel.Name = "characterDetailsLabel";
            this.characterDetailsLabel.Size = new System.Drawing.Size(35, 13);
            this.characterDetailsLabel.TabIndex = 2;
            this.characterDetailsLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.characterDetailsLabel);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.characterListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox characterListBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label characterDetailsLabel;
    }
}

