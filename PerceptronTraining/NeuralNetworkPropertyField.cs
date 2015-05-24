using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerceptronTraining
{
    public class NeuralNetworkPropertyField : UserControl
    {
        public Label fieldName;
        public TextBox fieldValue;
        public Label fieldError;

        public NeuralNetworkPropertyField(string fieldName, string value)
        {
            InitializeComponent();

            this.fieldName.Text = fieldName;
            this.fieldValue.Text = value;
            this.fieldError.Text = "";
        }

        private void InitializeComponent()
        {
            this.fieldName = new System.Windows.Forms.Label();
            this.fieldValue = new System.Windows.Forms.TextBox();
            this.fieldError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fieldName
            // 
            this.fieldName.AutoSize = true;
            this.fieldName.Location = new System.Drawing.Point(0, 0);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(54, 13);
            this.fieldName.TabIndex = 0;
            this.fieldName.Text = "filedName";
            // 
            // fieldValue
            // 
            this.fieldValue.Location = new System.Drawing.Point(3, 16);
            this.fieldValue.Name = "fieldValue";
            this.fieldValue.Size = new System.Drawing.Size(100, 20);
            this.fieldValue.TabIndex = 1;
            // 
            // fieldError
            // 
            this.fieldError.AutoSize = true;
            this.fieldError.Location = new System.Drawing.Point(109, 19);
            this.fieldError.Name = "fieldError";
            this.fieldError.Size = new System.Drawing.Size(28, 13);
            this.fieldError.TabIndex = 2;
            this.fieldError.Text = "error";
            // 
            // NeuralNetworkPropertyField
            // 
            this.Controls.Add(this.fieldError);
            this.Controls.Add(this.fieldValue);
            this.Controls.Add(this.fieldName);
            this.Name = "NeuralNetworkPropertyField";
            this.Size = new System.Drawing.Size(147, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
