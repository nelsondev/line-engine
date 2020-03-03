using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LineEngine;

namespace LineDraw.Forms
{
    public interface IFrame
    {
        string Name { get; set; }
        string Text { get; set; }
    }

    public struct Frame : IFrame
    {
        public Frame(string name, string text)
        {
            Name = name;
            Text = text;
        }
        
        public string Name { get; set; }
        public string Text { get; set; }
    }
    
    public interface IState
    {
        List<IFrame> Frames { get; set; }
        string Speed { get; set; }

        IFrame AddFrame();
    }
    
    public class State : IState
    {
        public State()
        {
            Frames = new List<IFrame>();
        }
        
        public State(IFrame frame)
        {
            Frames = new List<IFrame> {frame};
        }

        public State(List<IFrame> frames)
        {
            Frames = frames;
        }

        private bool FrameExists(string name)
        {
            return Frames.Any(f => f.Name == name);
        }
        
        private string NewFrameName(int count)
        {
            var name = "frame" + count;
            return FrameExists(name) ? NewFrameName(count + 1) : name;
        }
        
        public IFrame AddFrame()
        {
            var frame = new Frame(NewFrameName(0), "");
            Frames.Add(frame);
            return frame;
        }

        public List<IFrame> Frames { get; set; }
        public string Speed { get; set; }
    }
    
    public interface IStateController
    {
        List<IState> States { get; }
    }
    
    public class StateController : IStateController
    {
        public StateController()
        {
            States = new List<IState>();
        }

        public List<IState> States { get; }
    }
}