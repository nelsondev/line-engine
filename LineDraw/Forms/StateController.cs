using System.Collections.Generic;
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