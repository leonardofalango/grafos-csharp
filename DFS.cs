using System.Collections.Generic;
using System.Linq;

public class DFS : Solver
{
    
    public override void Solve()
    {

        Stack<Space> toVisit = new Stack<Space>();

        toVisit.Push(Maze.Root);
        Space actualNode;

        while (toVisit.Count > 0)
        {
            actualNode = toVisit.Pop();
            actualNode.Visited = true;

            if (actualNode.Exit)
                return;

            if (actualNode.Left != null && !actualNode.Left.Visited)
                toVisit.Push(actualNode.Left);

            if (actualNode.Top != null && !actualNode.Top.Visited)
                toVisit.Push(actualNode.Top);

            if (actualNode.Bottom != null && !actualNode.Bottom.Visited)
                toVisit.Push(actualNode.Bottom);

            if (actualNode.Right != null && !actualNode.Right.Visited)
                toVisit.Push(actualNode.Right);

        }

    }
}