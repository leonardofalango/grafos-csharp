using System.Collections.Generic;

public class DFSRecursive : Solver
{
    public override void Solve()
    {
        Stack<Space> toVisit = new Stack<Space>();

        toVisit.Push(Maze.Root);
        Space actualNode;
        
        bool flag;
        Stack<Space> spacesToAdd;

        while (toVisit.Count > 0)
        {
            spacesToAdd = new Stack<Space>();
            flag = false;

            actualNode = toVisit.Peek();
            actualNode.Visited = true;

            if (actualNode.Exit)
                break;

            if (actualNode.Left != null && !actualNode.Left.Visited)
            {
                flag = true;
                spacesToAdd.Push(actualNode.Left);
            }

            if (actualNode.Top != null && !actualNode.Top.Visited)
            {
                flag = true;
                spacesToAdd.Push(actualNode.Top);
            }

            if (actualNode.Bottom != null && !actualNode.Bottom.Visited)
            {
                flag = true;
                spacesToAdd.Push(actualNode.Bottom);
            }

            if (actualNode.Right != null && !actualNode.Right.Visited)
            {
                flag = true;
                spacesToAdd.Push(actualNode.Right);
            }

            if (flag)
            {
                toVisit.Pop();
                foreach (var item in spacesToAdd)
                {
                    toVisit.Push(item);
                }
            }

        }

        foreach (var item in toVisit)
            item.IsSolution = true;

    }
}
    
}