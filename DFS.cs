using System.Collections.Generic;

public class DFS : Solver
{
    public override void Solve()
    {
        solve(Maze.Root);
    }

    private bool solve(Space space)
    {
        space.Visited = true;
        
        if (space.Exit)
        {
            space.IsSolution = true;
            return true;
        }


        if (space.Right != null && !space.Right.Visited)
        {
            space.IsSolution = solve(space.Right);
            if (space.IsSolution)
                return true;
        }
        
        if (space.Bottom != null && !space.Bottom.Visited)
        {
            space.IsSolution = solve(space.Bottom);
            if (space.IsSolution)
                return true;
        } 
        
        if (space.Top != null && !space.Top.Visited)
        {
            space.IsSolution = solve(space.Top);
            if (space.IsSolution)
                return true;
        }

        if (space.Left != null && !space.Left.Visited)
        {
            space.IsSolution = solve(space.Left);
            if (space.IsSolution)
                return true;
        } 
        
        return false;
        
    }
}
