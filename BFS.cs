using System.Collections.Generic;
using System.Linq;

public class BFS : Solver
{
    
    public override void Solve()
    {

        Queue<Space> toVisit = new Queue<Space>();

        toVisit.Enqueue(Maze.Root);
        Space actualNode;

        while (toVisit.Count > 0)
        {
            actualNode = toVisit.Dequeue();
            actualNode.Visited = true;

            if (actualNode.Exit)
                return;

            if (actualNode.Left != null && !actualNode.Left.Visited)
            {
                toVisit.Enqueue(actualNode.Left);
            }

            if (actualNode.Top != null && !actualNode.Top.Visited)
            {
                toVisit.Enqueue(actualNode.Top);
            }

            if (actualNode.Bottom != null && !actualNode.Bottom.Visited)
            {
                toVisit.Enqueue(actualNode.Bottom);
            }

            if (actualNode.Right != null && !actualNode.Right.Visited)
            {
                toVisit.Enqueue(actualNode.Right);
            }

        }

    }
}