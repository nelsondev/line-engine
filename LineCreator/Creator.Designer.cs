namespace LineCreator
{
    partial class Creator
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
            this.richTextBox_Art = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Generated = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_Origin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_Art
            // 
            this.richTextBox_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.richTextBox_Art.Location = new System.Drawing.Point(14, 33);
            this.richTextBox_Art.Name = "richTextBox_Art";
            this.richTextBox_Art.Size = new System.Drawing.Size(355, 217);
            this.richTextBox_Art.TabIndex = 0;
            this.richTextBox_Art.Text = "";
            // 
            // richTextBox_Generated
            // 
            this.richTextBox_Generated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.richTextBox_Generated.Location = new System.Drawing.Point(376, 32);
            this.richTextBox_Generated.Name = "richTextBox_Generated";
            this.richTextBox_Generated.Size = new System.Drawing.Size(355, 286);
            this.richTextBox_Generated.TabIndex = 1;
            this.richTextBox_Generated.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Art";
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(14, 279);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(101, 39);
            this.button_Generate.TabIndex = 4;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(122, 279);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(101, 39);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_Origin
            // 
            this.textBox_Origin.Location = new System.Drawing.Point(59, 255);
            this.textBox_Origin.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Origin.Name = "textBox_Origin";
            this.textBox_Origin.Size = new System.Drawing.Size(88, 23);
            this.textBox_Origin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Origin";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Origin);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Generated);
            this.Controls.Add(this.richTextBox_Art);
            this.Name = "Creator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Art;
        private System.Windows.Forms.RichTextBox richTextBox_Generated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Origin;
        private System.Windows.Forms.Label label3;
    }
}

