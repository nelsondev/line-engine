using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LineEngine;

namespace LineDraw.Forms
{
    public class Tab
    {
        public Tab()
        {
            
        }
        public Tab(string name)
        {
            Name = name;
            State = new State
            {
                Speed = 0.ToString()
            };
        }
        public string Name { get; set; }
        public IState State { get; set; }
    }
    
    public partial class Editor : Form
    {
        private string SelectedTabName { get; set; }
        private string SelectedFrameName { get; set; }
        private List<Tab> Tabs { get; }
        
        public Editor(string name)
        {
            InitializeComponent();
            
            Tabs = new List<Tab>();
            Init(name);
            UpdateInterface(GetTab(name));
        }

        public void Init(string name)
        {
            SelectedTabName = name;
            var tab = new Tab(name);
            var frame = new Frame("frame" + tab.State.Frames.Count, "");
            tab.State.Frames.Add(frame);
            SelectedFrameName = frame.Name;
            Tabs.Add(tab);
            UpdateInterface(tab);
            listBox_Frames.SelectedIndex = 0;
        }

        public Tab GetTab(string name)
        {
            return Tabs.Single(t => t.Name == name);
        }

        public IFrame GetFrame()
        {
            return GetTab(SelectedTabName).State.Frames.Single(f => f.Name == SelectedFrameName);
        }

        public bool TabExists(string name)
        {
            return Tabs.Any(t => t.Name == name);
        }
        
        public bool FrameExists(string name)
        {
            return GetTab(SelectedTabName).State.Frames.Any(f => f.Name == name);
        }


        public void UpdateInterface(Tab tab)
        {
            SelectedTabName = tab.Name;
            
            tabControl_Animations.SelectedTab.Name = tab.Name;
            tabControl_Animations.SelectedTab.Text = tab.Name;

            textBox_Frame_Name.Text = SelectedFrameName;
            textBox_Animation_Name.Text = tab.Name;
            textBox_Animation_Speed.Text = tab.State.Speed;

            listBox_Frames.Items.Clear();
            
            foreach (var frame in tab.State.Frames)
            {
                listBox_Frames.Items.Add(frame.Name);
            }
        }

        public void UpdateFrame(IFrame frame)
        {
            SelectedFrameName = frame.Name;
            richTextBox_Input.Text = frame.Text;
            textBox_Frame_Name.Text = SelectedFrameName;
        }

        public string NewTabName(int count)
        {
            var name = "NewAnimation" + count;
            return TabExists(name) ? NewTabName(count + 1) : name;
        }
        
        public string NewFrameName(int count)
        {
            var name = "frame" + count;
            return FrameExists(name) ? NewFrameName(count + 1) : name;
        }

        private void CreateTabPage()
        {
            var page = new TabPage();
            var name = NewTabName(Tabs.Count);
            page.Name = name;
            page.Text = name;
            
            tabControl_Animations.TabPages.Add(page);
            
            var tab = new Tab(name);
            Tabs.Add(tab);
            SelectedTabName = name;
            UpdateInterface(tab);
        }

        private void CopyControlsToTabPage(Control from, Control to)
        {
            var ctrlArray = new Control[from.Controls.Count];
            from.Controls.CopyTo(ctrlArray, 0);
            to.Controls.AddRange(ctrlArray);
        }
        
        /*
         * EVENTS
         */
        private void Editor_Load(object sender, EventArgs e)
        {
            listBox_Frames.SelectedIndex = 0;
        }
        
        private void richTextBox_Input_TextChanged(object sender, EventArgs e)
        {
            var frame = GetFrame();
            frame.Text = richTextBox_Input.Text;
        }
        
        private void listBox_Frames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = GetTab(SelectedTabName);

            if (listBox_Frames.SelectedItem == null)
                return;
            
            SelectedFrameName = listBox_Frames.SelectedItem.ToString();
            UpdateFrame(tab.State.Frames[listBox_Frames.SelectedIndex]);
            
        }

        private void textBox_Frame_Name_TextChanged(object sender, EventArgs e)
        {
            var tab = GetTab(SelectedTabName);
            var frame = GetFrame();

            if (textBox_Frame_Name.Text == "" || textBox_Frame_Name.Text == frame.Name) return;
            
            if (FrameExists(textBox_Frame_Name.Text))
            {
                MessageBox.Show("Please pick a unique frame name.", "Invalid frame name.", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            frame.Name = textBox_Frame_Name.Text;
            SelectedFrameName = frame.Name;
            UpdateInterface(tab);
        }
        
        private void button_Add_Frame_Click(object sender, EventArgs e)
        {
            var tab = GetTab(SelectedTabName);
            var name = NewFrameName(tab.State.Frames.Count);
            var frame = new Frame(name, "");
            tab.State.Frames.Add(frame);
            SelectedFrameName = name;
            
            UpdateInterface(tab);
            UpdateFrame(frame);
            listBox_Frames.SelectedIndex = tab.State.Frames.Count-1;
        }

        private void button_Remove_Frame_Click(object sender, EventArgs e)
        {
            var tab = GetTab(SelectedTabName);
            
            if (tab.State.Frames.Count <= 1)
            {
                return;
            }
            
            var frame = GetFrame();
            var index = 0;
            for (var i = 0; i < tab.State.Frames.Count; i++)
            {
                if (tab.State.Frames[i] == frame)
                    index = i;
            }

            tab.State.Frames.Remove(frame);

            UpdateInterface(tab);

            if (index > 0)
                listBox_Frames.SelectedIndex = index - 1;
            else
                listBox_Frames.SelectedIndex = 0;
            
            SelectedFrameName = listBox_Frames.SelectedItem.ToString();
        }
        
        private void textBox_Animation_Name_TextChanged(object sender, EventArgs e)
        {
            var tab = GetTab(SelectedTabName);
            tab.Name = textBox_Animation_Name.Text;
            
            UpdateInterface(tab);
        }

        private void tabControl_Animations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Animations.SelectedTab.Name == "newTabPage")
                CreateTabPage();
        }
    }
}
        //
        // private void ControlsToTabPage(Control from, Control to)
        // {
        //     var ctrlArray = new Control[from.Controls.Count];
        //     from.Controls.CopyTo(ctrlArray, 0);
        //     to.Controls.AddRange(ctrlArray);
        // }
        //
        // private void CreateTabPage()
        // {
        //     var page = new TabPage
        //     {
        //         Name = @"NewAnimation", 
        //         Text = @"NewAnimation"
        //     };
        //     
        //     var state = new State
        //     {
        //         Frames = new List<IFrame>
        //         {
        //             new Frame("frame01", "")
        //         },
        //         Name = page.Name,
        //         Speed = 0.ToString()
        //     };
        //     
        //     _states.Add(state.Name, state);
        //     
        //     tabControl_Animations.TabPages.Insert(tabControl_Animations.TabPages.Count-1, page);
        //
        //     LoadTabPage(tabControl_Animations.TabPages.Count-2);
        // }
        //
        // private void LoadTabPage(int index)
        // {
        //     if (tabControl_Animations.SelectedIndex == index)
        //         return;
        //     
        //     tabControl_Animations.SelectedIndex = index;
        //     ControlsToTabPage(_page, tabControl_Animations.SelectedTab);
        //     _page = tabControl_Animations.SelectedTab;
        //     var state = _states[_page.Name];
        //     listBox_Frames.Items.Clear();
        //     foreach (var frame in state.Frames)
        //     {
        //         listBox_Frames.Items.Add(frame.Name);
        //     }
        //     listBox_Frames.SelectedIndex = 0;
        //     richTextBox_Input.Text = state.Frames.ToList()[listBox_Frames.SelectedIndex].Text;
        //     textBox_Animation_Name.Text = state.Name;
        //     textBox_Animation_Speed.Text = state.Speed;
        // }
        //
        // private void DeleteTabPage(int index)
        // {
        //     var page = tabControl_Animations.TabPages[index];
        //     var state = _states[page.Name];
        //     var i = tabControl_Animations.SelectedIndex = tabControl_Animations.SelectedIndex > 0
        //         ? tabControl_Animations.TabPages.Count - 2
        //         : tabControl_Animations.SelectedIndex - 1;
        //     LoadTabPage(i);
        //     _states.Remove(state.Name);
        //     tabControl_Animations.TabPages.Remove(page);
        // }
        //
        // private void New_Animation()
        // {
        //     // set tab control name
        //     tabControl_Animations.TabPages[0].Text = _animation.Name;
        //     tabControl_Animations.SelectedTab.Name = _animation.Name;
        //     
        //     // Prep default animation combo box
        //     comboBox_Default_Animation.Items.Add(_animation.Name);
        //     comboBox_Default_Animation.SelectedIndex = 0;
        //     
        //     // Prep frame list
        //     listBox_Frames.Items.Add("frame 01");
        //     listBox_Frames.SelectedIndex = 0;
        //     
        //     // Prep animation name box
        //     textBox_Animation_Name.Text = _animation.Name;
        //     textBox_Animation_Speed.Text = 0.ToString();
        //     
        //     // Prep label frame
        //     label_Frames.Text = @"1 / 1";
        // }
        //
        // private void New_Animation_Tab()
        // {
        //     var page = new TabPage
        //     {
        //         Name = @"NewAnimation", 
        //         Text = @"NewAnimation"
        //     };
        //
        //     tabControl_Animations.TabPages.Insert(tabControl_Animations.TabPages.Count-1, page);
        //     tabControl_Animations.SelectedTab = page;
        // }
        //
        // private void Delete_Animation_Tab()
        // {
        //     var page = tabControl_Animations.SelectedTab;
        //     tabControl_Animations.TabPages.Remove(page);
        // }
        //
        // private void Delete_Animation_Tab(int index)
        // {
        //     var page = tabControl_Animations.TabPages[index];
        //     tabControl_Animations.TabPages.Remove(page);
        // }

        // public void Rename_Animation_Tab(string name)
        // {
        //     var page = tabControl_Animations.SelectedTab;
        //     var state = _states[page.Name];
        //     var old = page.Name + " ";
        //     page.Name = name;
        //     page.Text = name;
        //     state.Name = name;
        //     if (!_states.ContainsKey(name))
        //         _states.Add(name, state);
        //     else
        //         _states.Remove(old);
        // }
        //
        // /*
        //  * Events
        //  */
        // private void Editor_Load(object sender, EventArgs e)
        // {
        //     _page = tabControl_Animations.SelectedTab;
        //     _states.Add(Name, new State
        //     {
        //         Frames = new List<IFrame>
        //         {
        //             new Frame("frame01", "")
        //         },
        //         Name = Name,
        //         Speed = 0.ToString()
        //     });
        // }
        //
        // private void tabControl_Animations_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     if (tabControl_Animations.SelectedTab.Name == "newTabPage")
        //     {
        //         CreateTabPage();
        //         return;
        //     }
        //     LoadTabPage(tabControl_Animations.SelectedIndex);
        // }
        //
        // private void textBox_Animation_Name_TextChanged(object sender, EventArgs e)
        // {
        //     Rename_Animation_Tab(textBox_Animation_Name.Text);
        // }
        //
        // private void textBox_Animation_Speed_TextChanged(object sender, EventArgs e)
        // {
        //     // throw new System.NotImplementedException();
        // }
        //
        // private void toolStripMenuItem_Edit_Add_Click(object sender, EventArgs e)
        // {
        //     CreateTabPage();
        // }
        //
        // private void toolStripMenuItem_Edit_Delete_Click(object sender, EventArgs e)
        // {
        //     // if (tabControl_Animations.TabPages.Count == 2)
        //     // {
        //     //     New_Animation_Tab();
        //     //     Delete_Animation_Tab(1);
        //     //     return;
        //     // }
        //     //
        //     // ControlsToTabPage(_page, tabControl_Animations.TabPages[0]);
        //     // Delete_Animation_Tab();
        // }
        //
        // private void listBox_Frames_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     
        // }
