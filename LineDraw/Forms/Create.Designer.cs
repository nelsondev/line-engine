using System.ComponentModel;

namespace LineDraw.Forms
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(14, 27);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(186, 23);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            this.textBox_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Name_KeyDown);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(125, 57);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 25);
            this.button_Create.TabIndex = 2;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 93);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}