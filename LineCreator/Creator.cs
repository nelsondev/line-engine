using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace LineCreator
{
    //public interface IAnimation
    //{
    //    int Speed { get; set; }
    //    int Frame { get; }
    //    int Length { get; }
    //    Sprite Sprite { get; }
    //}

    //public class Animation : IAnimation
    //{
    //    public Animation()
    //    {
    //        Sprites = new List<Sprite>();
    //    }

    //    private List<Sprite> Sprites { get; }

    //    public int Speed { get; set; }
    //    public int Frame { get; set; }
    //    public int Length => Sprites.Count;
    //    public Sprite Sprite => Sprites[Frame];
    //}

    //public struct Sprite
    //{

    //}

    public struct Display
    {
        private int X { get; }
        private int Y { get; }
        public char Character { get; }

        public Display(int x, int y, char character)
        {
            X = x;
            Y = y;
            Character = character;
        }

        public override string ToString()
        {
            return $"new Display({X}, {Y}, '{Character}')";
        }
    }

    public partial class Creator : Form
    {
        public Creator()
        {
            InitializeComponent();
        }

        private IEnumerable<string> SplitByNewLine(string str)
        {
            return str.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );
        }

        private static List<List<char>> ToCharList(IEnumerable<string> list)
        {
            return list.Select(s => s.ToCharArray().ToList()).ToList();
        }

        private static List<Display> ToDisplayList(IReadOnlyList<List<char>> list)
        {
            var result = new List<Display>();
            
            for (var i = 0; i < list.Count; i++)
            {
                var l = list[i];

                for (var j = 0; j < l.Count; j++)
                {
                    var c = l[j];

                    if (c != ' ')
                    {
                        result.Add(new Display(j, i, c));
                    }
                }
            }

            return result;
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            var lines = SplitByNewLine(richTextBox_Art.Text);
            var charList = ToCharList(lines);
            var displays = ToDisplayList(charList);

            // Grab all distinct characters in display array
            var query = from display
                    in displays.GroupBy(display => display.Character)
                    select display;

            // Clear old output
            richTextBox_Generated.Clear();

            richTextBox_Generated.Text += @"new Sprite() " + Environment.NewLine + @"{" + Environment.NewLine;

            if (textBox_Origin.Text != "")
                richTextBox_Generated.Text += $@"	Origin = new Point({textBox_Origin.Text})," + Environment.NewLine;
            else
                richTextBox_Generated.Text += @"	Origin = new Point(0, 0)," + Environment.NewLine;

            richTextBox_Generated.Text += @"	Displays = new Display[] " + Environment.NewLine + @"	{" + Environment.NewLine;

            // Loop through each distinct character
            foreach (var group in query.ToList())
            {
                // Add a comment to differentiate the characters
                richTextBox_Generated.Text += $@"		// {group.Key} characters {Environment.NewLine}";
                
                foreach (var display in displays.Where(display => display.Character == group.Key))
                {
                    richTextBox_Generated.Text += @"		" + display + @"," + Environment.NewLine;
                }

                richTextBox_Generated.Text += Environment.NewLine;
            }
            richTextBox_Generated.Text += @"	}" + Environment.NewLine;
            richTextBox_Generated.Text += @"};";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Art.Clear();
            richTextBox_Generated.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
