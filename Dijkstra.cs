


using System.Collections.Generic;

public class Dijkstra : Solver
{
    public int[] Distances { get; set; }
    public Space[] PrevStates { get; set; }
    public PriorityQueue<Space, int> Queue { get; set; }

    public override void Solve()
    {
        solve(Maze.Root);
    }

    private void solve(Space space)
    {
        Queue.Enqueue(space, 0);

        while (Queue.Count > 0)
        {
            Space u = Queue.Dequeue();

            // para cada vizinho de v em u
            // foreach (var v in u)
            if (u.Bottom != null)
            {
                
            }
        }
    }
}