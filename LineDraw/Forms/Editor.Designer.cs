using System.ComponentModel;

namespace LineDraw.Forms
{
    partial class Editor
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
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Tools_Generate_Code = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Tools_Generate_Sprite_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Edit_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Edit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Frame_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Default_Animation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox_Preview = new System.Windows.Forms.RichTextBox();
            this.textBox_Animation_Speed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Animation_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_First_Frame = new System.Windows.Forms.Button();
            this.button_Last_Frame = new System.Windows.Forms.Button();
            this.button_Previous_Frame = new System.Windows.Forms.Button();
            this.button_Next_Frame = new System.Windows.Forms.Button();
            this.label_Frames = new System.Windows.Forms.Label();
            this.button_Remove_Frame = new System.Windows.Forms.Button();
            this.tabControl_Animations = new System.Windows.Forms.TabControl();
            this.NewAnimation = new System.Windows.Forms.TabPage();
            this.button_Add_Frame = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox_Frames = new System.Windows.Forms.ListBox();
            this.richTextBox_Input = new System.Windows.Forms.RichTextBox();
            this.newTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl_Animations.SuspendLayout();
            this.NewAnimation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItem_File_New, this.toolStripMenuItem_File_Open, this.toolStripMenuItem_File_Save});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem_File.Text = "File";
            // 
            // toolStripMenuItem_File_New
            // 
            this.toolStripMenuItem_File_New.Name = "toolStripMenuItem_File_New";
            this.toolStripMenuItem_File_New.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_File_New.Text = "New";
            // 
            // toolStripMenuItem_File_Open
            // 
            this.toolStripMenuItem_File_Open.Name = "toolStripMenuItem_File_Open";
            this.toolStripMenuItem_File_Open.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_File_Open.Text = "Open";
            // 
            // toolStripMenuItem_File_Save
            // 
            this.toolStripMenuItem_File_Save.Name = "toolStripMenuItem_File_Save";
            this.toolStripMenuItem_File_Save.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_File_Save.Text = "Save";
            // 
            // toolStripMenuItem_Tools
            // 
            this.toolStripMenuItem_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.generateToolStripMenuItem});
            this.toolStripMenuItem_Tools.Name = "toolStripMenuItem_Tools";
            this.toolStripMenuItem_Tools.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem_Tools.Text = "Tools";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItem_Tools_Generate_Code, this.toolStripMenuItem_Tools_Generate_Sprite_File});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // toolStripMenuItem_Tools_Generate_Code
            // 
            this.toolStripMenuItem_Tools_Generate_Code.Name = "toolStripMenuItem_Tools_Generate_Code";
            this.toolStripMenuItem_Tools_Generate_Code.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem_Tools_Generate_Code.Text = "Code";
            // 
            // toolStripMenuItem_Tools_Generate_Sprite_File
            // 
            this.toolStripMenuItem_Tools_Generate_Sprite_File.Name = "toolStripMenuItem_Tools_Generate_Sprite_File";
            this.toolStripMenuItem_Tools_Generate_Sprite_File.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem_Tools_Generate_Sprite_File.Text = "Sprite File";
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.editorToolStripMenuItem});
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem_Help.Text = "Help";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripMenuItem_File, this.toolStripMenuItem_Edit, this.toolStripMenuItem_Tools,
                this.toolStripMenuItem_Help
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Edit
            // 
            this.toolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItem_Edit_Add, this.toolStripMenuItem_Edit_Delete});
            this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem_Edit.Text = "Edit";
            // 
            // toolStripMenuItem_Edit_Add
            // 
            this.toolStripMenuItem_Edit_Add.Name = "toolStripMenuItem_Edit_Add";
            this.toolStripMenuItem_Edit_Add.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem_Edit_Add.Text = "Add Animation";
            // 
            // toolStripMenuItem_Edit_Delete
            // 
            this.toolStripMenuItem_Edit_Delete.Name = "toolStripMenuItem_Edit_Delete";
            this.toolStripMenuItem_Edit_Delete.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem_Edit_Delete.Text = "Delete Animation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Properties";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Frame_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // textBox_Frame_Name
            // 
            this.textBox_Frame_Name.Location = new System.Drawing.Point(6, 38);
            this.textBox_Frame_Name.Name = "textBox_Frame_Name";
            this.textBox_Frame_Name.Size = new System.Drawing.Size(192, 23);
            this.textBox_Frame_Name.TabIndex = 11;
            this.textBox_Frame_Name.TextChanged += new System.EventHandler(this.textBox_Frame_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // comboBox_Default_Animation
            // 
            this.comboBox_Default_Animation.FormattingEnabled = true;
            this.comboBox_Default_Animation.Location = new System.Drawing.Point(6, 126);
            this.comboBox_Default_Animation.Name = "comboBox_Default_Animation";
            this.comboBox_Default_Animation.Size = new System.Drawing.Size(192, 23);
            this.comboBox_Default_Animation.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Default Animation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Default_Animation);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.richTextBox_Preview);
            this.groupBox2.Controls.Add(this.textBox_Animation_Speed);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Animation_Name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 387);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Preview";
            // 
            // richTextBox_Preview
            // 
            this.richTextBox_Preview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox_Preview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Preview.DetectUrls = false;
            this.richTextBox_Preview.Location = new System.Drawing.Point(6, 181);
            this.richTextBox_Preview.Name = "richTextBox_Preview";
            this.richTextBox_Preview.ReadOnly = true;
            this.richTextBox_Preview.ShortcutsEnabled = false;
            this.richTextBox_Preview.Size = new System.Drawing.Size(192, 189);
            this.richTextBox_Preview.TabIndex = 0;
            this.richTextBox_Preview.TabStop = false;
            this.richTextBox_Preview.Text = "";
            this.richTextBox_Preview.WordWrap = false;
            // 
            // textBox_Animation_Speed
            // 
            this.textBox_Animation_Speed.Location = new System.Drawing.Point(6, 82);
            this.textBox_Animation_Speed.Name = "textBox_Animation_Speed";
            this.textBox_Animation_Speed.Size = new System.Drawing.Size(192, 23);
            this.textBox_Animation_Speed.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Speed";
            // 
            // textBox_Animation_Name
            // 
            this.textBox_Animation_Name.Location = new System.Drawing.Point(6, 38);
            this.textBox_Animation_Name.Name = "textBox_Animation_Name";
            this.textBox_Animation_Name.Size = new System.Drawing.Size(192, 23);
            this.textBox_Animation_Name.TabIndex = 6;
            this.textBox_Animation_Name.TextChanged += new System.EventHandler(this.textBox_Animation_Name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // button_First_Frame
            // 
            this.button_First_Frame.Location = new System.Drawing.Point(12, 457);
            this.button_First_Frame.Name = "button_First_Frame";
            this.button_First_Frame.Size = new System.Drawing.Size(45, 37);
            this.button_First_Frame.TabIndex = 5;
            this.button_First_Frame.Text = "<<";
            this.button_First_Frame.UseVisualStyleBackColor = true;
            // 
            // button_Last_Frame
            // 
            this.button_Last_Frame.Location = new System.Drawing.Point(213, 457);
            this.button_Last_Frame.Name = "button_Last_Frame";
            this.button_Last_Frame.Size = new System.Drawing.Size(45, 37);
            this.button_Last_Frame.TabIndex = 6;
            this.button_Last_Frame.Text = ">>";
            this.button_Last_Frame.UseVisualStyleBackColor = true;
            // 
            // button_Previous_Frame
            // 
            this.button_Previous_Frame.Location = new System.Drawing.Point(63, 457);
            this.button_Previous_Frame.Name = "button_Previous_Frame";
            this.button_Previous_Frame.Size = new System.Drawing.Size(69, 37);
            this.button_Previous_Frame.TabIndex = 7;
            this.button_Previous_Frame.Text = "< last";
            this.button_Previous_Frame.UseVisualStyleBackColor = true;
            // 
            // button_Next_Frame
            // 
            this.button_Next_Frame.Location = new System.Drawing.Point(138, 457);
            this.button_Next_Frame.Name = "button_Next_Frame";
            this.button_Next_Frame.Size = new System.Drawing.Size(69, 37);
            this.button_Next_Frame.TabIndex = 8;
            this.button_Next_Frame.Text = "next >";
            this.button_Next_Frame.UseVisualStyleBackColor = true;
            // 
            // label_Frames
            // 
            this.label_Frames.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_Frames.Location = new System.Drawing.Point(428, 465);
            this.label_Frames.Name = "label_Frames";
            this.label_Frames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Frames.Size = new System.Drawing.Size(147, 23);
            this.label_Frames.TabIndex = 9;
            this.label_Frames.Text = "frame total";
            // 
            // button_Remove_Frame
            // 
            this.button_Remove_Frame.BackColor = System.Drawing.Color.White;
            this.button_Remove_Frame.Location = new System.Drawing.Point(510, 3);
            this.button_Remove_Frame.Name = "button_Remove_Frame";
            this.button_Remove_Frame.Size = new System.Drawing.Size(22, 21);
            this.button_Remove_Frame.TabIndex = 10;
            this.button_Remove_Frame.Text = "-";
            this.button_Remove_Frame.UseVisualStyleBackColor = false;
            this.button_Remove_Frame.Click += new System.EventHandler(this.button_Remove_Frame_Click);
            // 
            // tabControl_Animations
            // 
            this.tabControl_Animations.Controls.Add(this.NewAnimation);
            this.tabControl_Animations.Controls.Add(this.newTabPage);
            this.tabControl_Animations.Location = new System.Drawing.Point(12, 6);
            this.tabControl_Animations.Name = "tabControl_Animations";
            this.tabControl_Animations.SelectedIndex = 0;
            this.tabControl_Animations.Size = new System.Drawing.Size(570, 445);
            this.tabControl_Animations.TabIndex = 11;
            this.tabControl_Animations.SelectedIndexChanged +=
                new System.EventHandler(this.tabControl_Animations_SelectedIndexChanged);
            // 
            // NewAnimation
            // 
            this.NewAnimation.Controls.Add(this.button_Add_Frame);
            this.NewAnimation.Controls.Add(this.label9);
            this.NewAnimation.Controls.Add(this.button_Remove_Frame);
            this.NewAnimation.Controls.Add(this.listBox_Frames);
            this.NewAnimation.Controls.Add(this.richTextBox_Input);
            this.NewAnimation.Location = new System.Drawing.Point(4, 24);
            this.NewAnimation.Name = "NewAnimation";
            this.NewAnimation.Padding = new System.Windows.Forms.Padding(3);
            this.NewAnimation.Size = new System.Drawing.Size(562, 417);
            this.NewAnimation.TabIndex = 0;
            this.NewAnimation.Text = "NewAnimation";
            this.NewAnimation.UseVisualStyleBackColor = true;
            // 
            // button_Add_Frame
            // 
            this.button_Add_Frame.BackColor = System.Drawing.Color.White;
            this.button_Add_Frame.Location = new System.Drawing.Point(538, 3);
            this.button_Add_Frame.Name = "button_Add_Frame";
            this.button_Add_Frame.Size = new System.Drawing.Size(22, 21);
            this.button_Add_Frame.TabIndex = 14;
            this.button_Add_Frame.Text = "+";
            this.button_Add_Frame.UseVisualStyleBackColor = false;
            this.button_Add_Frame.Click += new System.EventHandler(this.button_Add_Frame_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Frames";
            // 
            // listBox_Frames
            // 
            this.listBox_Frames.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox_Frames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Frames.FormattingEnabled = true;
            this.listBox_Frames.ItemHeight = 15;
            this.listBox_Frames.Location = new System.Drawing.Point(416, 27);
            this.listBox_Frames.Name = "listBox_Frames";
            this.listBox_Frames.Size = new System.Drawing.Size(148, 390);
            this.listBox_Frames.TabIndex = 12;
            this.listBox_Frames.SelectedIndexChanged +=
                new System.EventHandler(this.listBox_Frames_SelectedIndexChanged);
            // 
            // richTextBox_Input
            // 
            this.richTextBox_Input.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Input.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Input.Name = "richTextBox_Input";
            this.richTextBox_Input.Size = new System.Drawing.Size(409, 417);
            this.richTextBox_Input.TabIndex = 4;
            this.richTextBox_Input.Text = "";
            this.richTextBox_Input.TextChanged += new System.EventHandler(this.richTextBox_Input_TextChanged);
            // 
            // newTabPage
            // 
            this.newTabPage.Location = new System.Drawing.Point(4, 22);
            this.newTabPage.Name = "newTabPage";
            this.newTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newTabPage.Size = new System.Drawing.Size(562, 419);
            this.newTabPage.TabIndex = 1;
            this.newTabPage.Text = "+";
            this.newTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl_Animations);
            this.splitContainer1.Panel1.Controls.Add(this.label_Frames);
            this.splitContainer1.Panel1.Controls.Add(this.button_Next_Frame);
            this.splitContainer1.Panel1.Controls.Add(this.button_Previous_Frame);
            this.splitContainer1.Panel1.Controls.Add(this.button_Last_Frame);
            this.splitContainer1.Panel1.Controls.Add(this.button_First_Frame);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(803, 506);
            this.splitContainer1.SplitterDistance = 583;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 530);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "LineDRAW | Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl_Animations.ResumeLayout(false);
            this.NewAnimation.ResumeLayout(false);
            this.NewAnimation.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Add_Frame;
        private System.Windows.Forms.ListBox listBox_Frames;
        private System.Windows.Forms.TabControl tabControl_Animations;
        private System.Windows.Forms.Button button_Remove_Frame;
        private System.Windows.Forms.Label label_Frames;
        private System.Windows.Forms.Button button_Next_Frame;
        private System.Windows.Forms.Button button_Last_Frame;
        private System.Windows.Forms.RichTextBox richTextBox_Preview;
        private System.Windows.Forms.TextBox textBox_Animation_Speed;
        private System.Windows.Forms.TextBox textBox_Animation_Name;
        private System.Windows.Forms.ComboBox comboBox_Default_Animation;
        private System.Windows.Forms.Button button_Previous_Frame;
        private System.Windows.Forms.Button button_First_Frame;
        private System.Windows.Forms.RichTextBox richTextBox_Input;
        private System.Windows.Forms.TabPage newTabPage;
        private System.Windows.Forms.TabPage NewAnimation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit_Delete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit_Add;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File_New;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File_Save;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Tools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Tools_Generate_Code;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Tools_Generate_Sprite_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Frame_Name;
    }
}