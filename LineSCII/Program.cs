using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LineSCII
{
    internal static class Program
    {
        // private static void Owo()
        // {
        //     ConsoleKeyInfo cki;
        //     // Prevent example from ending if CTL+C is pressed.
        //     Console.TreatControlCAsInput = true;
        //
        //     Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        //     Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        //     do 
        //     {
        //         cki = Console.ReadKey();
        //         
        //         Console.Write(" --- You pressed ");
        //         if((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
        //         if((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
        //         if((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
        //         Console.WriteLine(cki.Key.ToString());
        //     } while (cki.Key != ConsoleKey.Escape);
        // }

        private class Buffer
        {
            public Buffer(int width, int height)
            {
                Chars = new char?[width, height];
            }
            
            // Properties
            public char?[,] Chars { get; }
            
            // Methods
            public void Loop(Action<int, int> call)
            {
                for (var i = 0; i < Chars.GetLength(0); i++)
                {
                    for (var j = 0; j < Chars.GetLength(1); j++)
                    {
                        call(i, j);
                    }
                }
            }

            public void Loop(Action<char?> call)
            {
                Loop((x, y) => { call(Chars[x, y]); });
            }
            
            public void Set(int x, int y, char? c)
            {
                Chars[x, y] = c;
            }
            public void SetNull(int x, int y)
            {
                Set(x, y, null);
            }

            public void Clear()
            {
                Loop(SetNull);
            }

            public string GetRow(int x)
            {
                var sb = new StringBuilder();
                for (var i = 0; i < Chars.GetLength(1); i++)
                {
                    if (Chars[x, i] != null) sb.Append(Chars[x, i]);
                }
                return sb.ToString();
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                for (var i = 0; i < Chars.GetLength(0); i++)
                {
                    var row = GetRow(i);
                    if (string.IsNullOrWhiteSpace(row)) continue;
                    sb.Append(row + "\n");
                }

                return sb.ToString();
            }
        }
        
        private class Cursor
        {
            public Cursor()
            {
                Row = 0;
                Col = 0;
            }
            
            public int Row { get; set; }
            public int Col { get; set; }
            
            public void UpdateCursorPosition(int x, int y)
            {
                Row = x;
                Col = y;
            }
        }
        
        private class Ascii
        {
            public Ascii()
            {
                Buffer = new Buffer(Console.BufferWidth, Console.BufferHeight);
                Cursor = new Cursor();
            }

            // Properties
            public Buffer Buffer { get; }
            public Cursor Cursor { get; }
            
            // Methods
            public void Run()
            {
                while (true)
                {
                    char? output = null;
                    var key = Console.ReadKey();

                    Cursor.UpdateCursorPosition(Console.CursorTop, Console.CursorLeft);

                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Output:");
                        Console.Write(Buffer.ToString());
                        break;
                    }

                    switch (key.Key)
                    {
                        // Backspace
                        case ConsoleKey.Backspace:
                            Cursor.UpdateCursorPosition(Console.CursorTop, Console.CursorLeft + 1);
                            Console.Write(' ');
                            Console.CursorLeft -= 1;
                            break;
                        // New line
                        case ConsoleKey.Enter:
                            Console.CursorTop += 1;
                            break;
                        // Arrow Keys
                        case ConsoleKey.UpArrow:
                            Console.CursorTop -= 1;
                            Console.CursorLeft = Buffer.GetRow(Console.CursorTop).Length;
                            break;
                        case ConsoleKey.DownArrow:
                            Console.CursorTop += 1;
                            Console.CursorLeft = Buffer.GetRow(Console.CursorTop).Length;
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.CursorLeft -= 2;
                            continue;
                        case ConsoleKey.RightArrow:
                            Console.CursorLeft += 1;
                            continue;
                        // Set output character
                        default:
                            output = key.KeyChar;
                            break;
                    }
                    
                    Buffer.Set(Cursor.Row, Cursor.Col, output);
                }
            }
        }

        private static void Main(string[] args)
        {
            var ascii = new Ascii();
            ascii.Run();
            // var list = new List<string>() { " " };
            //
            // var test = new char[Console.WindowWidth-1, Console.WindowHeight-1];
            //
            // static string AppendNewLines(IEnumerable<string> list)
            // {
            //     return list.Aggregate("", (current, s) => current + (s + "\n"));
            // }
            //
            // while (true)
            // {
            //     var row = Console.CursorTop;
            //     var col = Console.CursorLeft;
            //     var keyChar = ' ';
            //     
            //     // Console.Clear();
            //     // Console.Write(AppendNewLines(list));
            //     Console.CursorTop = row;
            //     Console.CursorLeft = col;
            //     var key = Console.ReadKey();
            //     
            //     // create new row
            //     if (key.Key == ConsoleKey.Enter)
            //     {
            //         list.Add(" ");
            //         Console.CursorTop += 1;
            //     }
            //
            //     if (key.Key == ConsoleKey.Escape)
            //     {
            //         Console.Clear();
            //         Console.WriteLine("We've done it!");
            //         Console.Write(AppendNewLines(list));
            //         break;
            //     }
            //
            //     if (key.Key != ConsoleKey.Backspace)
            //         keyChar = key.KeyChar;
            //
            //     var arr = list[row].ToCharArray();
            //     
            //     try
            //     {
            //         arr[col] = keyChar;
            //         var str = new string(arr);
            //         list[row] = str;
            //     }
            //     catch (IndexOutOfRangeException)
            //     {
            //         var newarr = new char[arr.Length + 1];
            //         for (var i = 0; i < arr.Length; i++)
            //         {
            //             newarr[i] = arr[i];
            //         }
            //
            //         newarr[^1] = keyChar;
            //         var str = new string(newarr);
            //         list[row] = str;
            //     }
        }
    }
}