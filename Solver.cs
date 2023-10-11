using System.Collections.Generic;
using System.Windows.Forms;
using Stately;

public abstract class Solver
{
    public Maze Maze { get; set; }
    
    public abstract void Solve();
}