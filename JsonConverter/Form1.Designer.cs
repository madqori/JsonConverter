namespace JsonConverter
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFrom = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(541, 96);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 140);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 169);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(541, 118);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limit";
            // 
            // txtDataFrom
            // 
            this.txtDataFrom.Location = new System.Drawing.Point(73, 114);
            this.txtDataFrom.Name = "txtDataFrom";
            this.txtDataFrom.Size = new System.Drawing.Size(100, 20);
            this.txtDataFrom.TabIndex = 5;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(256, 114);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 319);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtDataFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataFrom;
        private System.Windows.Forms.TextBox txtLimit;
    }
}

