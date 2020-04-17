public class Solution {
    
    public int dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            return 0;
        
        grid[i][j] = '0';
        
        dfs(grid,i+1,j);
        dfs(grid,i-1,j);
        dfs(grid,i,j+1);
        dfs(grid,i,j-1);
        
        return 1;
    }
    
    public int NumIslands(char[][] grid) {
        int count = 0;
        int len = grid.Length;
        if (grid == null || len == 0)
            return 0;
        
        for(int i = 0; i < grid.GetLength(0); i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                    count += dfs(grid,i,j);
            }
        }
        
        return count;
    }
}
