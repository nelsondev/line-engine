namespace LineDraw.Forms
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Recent = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.listBox_Recent);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.button_Create);
            this.splitContainer1.Panel2.Controls.Add(this.button_Load);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(692, 441);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LineDraw.Properties.Resources.preview1;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 417);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 163);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(233, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/nelsondev/line-engine";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 148);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // listBox_Recent
            // 
            this.listBox_Recent.FormattingEnabled = true;
            this.listBox_Recent.ItemHeight = 15;
            this.listBox_Recent.Location = new System.Drawing.Point(3, 208);
            this.listBox_Recent.Name = "listBox_Recent";
            this.listBox_Recent.Size = new System.Drawing.Size(299, 109);
            this.listBox_Recent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recent";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(3, 323);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(299, 50);
            this.button_Create.TabIndex = 3;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(3, 378);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(299, 50);
            this.button_Load.TabIndex = 2;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LineDRAW";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Setup";
            this.Text = "LineDRAW | Setup";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox listBox_Recent;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Load;
    }
}