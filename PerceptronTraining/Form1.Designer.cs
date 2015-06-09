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
            this.inertiaMomentTextBox = new System.Windows.Forms.TextBox();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.InnerNeuronsTextBox = new System.Windows.Forms.TextBox();
            this.InnerNeuronsLabel = new System.Windows.Forms.Label();
            this.trainButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.epochesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.occuracityTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
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
            // inertiaMomentTextBox
            // 
            this.inertiaMomentTextBox.Location = new System.Drawing.Point(16, 73);
            this.inertiaMomentTextBox.Name = "inertiaMomentTextBox";
            this.inertiaMomentTextBox.Size = new System.Drawing.Size(45, 20);
            this.inertiaMomentTextBox.TabIndex = 3;
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Location = new System.Drawing.Point(13, 57);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(73, 13);
            this.alphaLabel.TabIndex = 2;
            this.alphaLabel.Text = "inertiaMoment";
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
            this.trainButton.Location = new System.Drawing.Point(16, 180);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(45, 23);
            this.trainButton.TabIndex = 6;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(16, 211);
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
            // epochesTextBox
            // 
            this.epochesTextBox.Location = new System.Drawing.Point(16, 154);
            this.epochesTextBox.Name = "epochesTextBox";
            this.epochesTextBox.Size = new System.Drawing.Size(45, 20);
            this.epochesTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Epoches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Occuracity";
            // 
            // occuracityTextBox
            // 
            this.occuracityTextBox.Location = new System.Drawing.Point(628, 326);
            this.occuracityTextBox.Name = "occuracityTextBox";
            this.occuracityTextBox.Size = new System.Drawing.Size(100, 20);
            this.occuracityTextBox.TabIndex = 13;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(921, 420);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(840, 420);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 15;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 453);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.occuracityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.epochesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.InnerNeuronsTextBox);
            this.Controls.Add(this.InnerNeuronsLabel);
            this.Controls.Add(this.inertiaMomentTextBox);
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
        private System.Windows.Forms.TextBox inertiaMomentTextBox;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.TextBox InnerNeuronsTextBox;
        private System.Windows.Forms.Label InnerNeuronsLabel;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox epochesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox occuracityTextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;



    }
}

