namespace PerceptronTraining
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
            this.trainingSpeedLabel = new System.Windows.Forms.Label();
            this.trainingSpeedTextBox = new System.Windows.Forms.TextBox();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.InnerNeuronsTextBox = new System.Windows.Forms.TextBox();
            this.InnerNeuronsLabel = new System.Windows.Forms.Label();
            this.trainButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trainingSpeedLabel
            // 
            this.trainingSpeedLabel.AutoSize = true;
            this.trainingSpeedLabel.Location = new System.Drawing.Point(13, 16);
            this.trainingSpeedLabel.Name = "trainingSpeedLabel";
            this.trainingSpeedLabel.Size = new System.Drawing.Size(76, 13);
            this.trainingSpeedLabel.TabIndex = 0;
            this.trainingSpeedLabel.Text = "TrainingSpeed";
            // 
            // trainingSpeedTextBox
            // 
            this.trainingSpeedTextBox.Location = new System.Drawing.Point(16, 32);
            this.trainingSpeedTextBox.Name = "trainingSpeedTextBox";
            this.trainingSpeedTextBox.Size = new System.Drawing.Size(45, 20);
            this.trainingSpeedTextBox.TabIndex = 1;
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(16, 73);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(45, 20);
            this.alphaTextBox.TabIndex = 3;
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Location = new System.Drawing.Point(13, 57);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(34, 13);
            this.alphaLabel.TabIndex = 2;
            this.alphaLabel.Text = "Alpha";
            // 
            // InnerNeuronsTextBox
            // 
            this.InnerNeuronsTextBox.Location = new System.Drawing.Point(16, 112);
            this.InnerNeuronsTextBox.Name = "InnerNeuronsTextBox";
            this.InnerNeuronsTextBox.Size = new System.Drawing.Size(45, 20);
            this.InnerNeuronsTextBox.TabIndex = 5;
            // 
            // InnerNeuronsLabel
            // 
            this.InnerNeuronsLabel.AutoSize = true;
            this.InnerNeuronsLabel.Location = new System.Drawing.Point(13, 96);
            this.InnerNeuronsLabel.Name = "InnerNeuronsLabel";
            this.InnerNeuronsLabel.Size = new System.Drawing.Size(71, 13);
            this.InnerNeuronsLabel.TabIndex = 4;
            this.InnerNeuronsLabel.Text = "InnerNeurons";
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(16, 139);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(45, 23);
            this.trainButton.TabIndex = 6;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(16, 170);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(56, 23);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 329);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(525, 84);
            this.commentTextBox.TabIndex = 8;
            this.commentTextBox.Text = "";
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(12, 420);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 9;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(570, 329);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(426, 84);
            this.weightTextBox.TabIndex = 10;
            this.weightTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Weight:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.InnerNeuronsTextBox);
            this.Controls.Add(this.InnerNeuronsLabel);
            this.Controls.Add(this.alphaTextBox);
            this.Controls.Add(this.alphaLabel);
            this.Controls.Add(this.trainingSpeedTextBox);
            this.Controls.Add(this.trainingSpeedLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trainingSpeedLabel;
        private System.Windows.Forms.TextBox trainingSpeedTextBox;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.TextBox InnerNeuronsTextBox;
        private System.Windows.Forms.Label InnerNeuronsLabel;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.RichTextBox weightTextBox;
        private System.Windows.Forms.Label label1;



    }
}

