//Not my Code

public class Solution {
    /*
    1 1 1      2 2 2
    1 1 0  ->  2 2 0
    1 0 1      2 0 1
    
    Solution: Get the starting point and perform bfs in all the 4 directions
    
    Corner cases (found after submitting)
    if both the colors are same we can return the old image no need of extra space (visited array)
    
    
    */
    
    public class Cell
    {
        public int x;
        public int y;
        
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        
        int[] d1 = new int[] {-1, 0, 1, 0};
        int[] d2 = new int[] {0, 1, 0, -1};
        
        Queue<Cell> q = new Queue<Cell>();
        bool[,] visited = new bool[image.Length, image[0].Length];
        
        int old = image[sr][sc];
        
        if(old == newColor)
            return image;
        
        image[sr][sc] = newColor;
        visited[sr, sc] = true;
        q.Enqueue(new Cell(sr, sc));
        
        
        while(q.Count != 0)
        {
            var cell = q.Dequeue();
            
            for(int i = 0; i < 4; i++)
            {
                var newRow = cell.x + d1[i];
                var newCol = cell.y + d2[i];
                
                if(newRow < 0 || newCol < 0 || newRow >= image.Length || newCol >= image[0].Length)
                    continue;
                
                if(image[newRow][newCol] == old && visited[newRow, newCol] == false)
                {
                    image[newRow][newCol] = newColor;
                    q.Enqueue(new Cell(newRow, newCol));
                    visited[newRow, newCol] = true;
                }
            }
        }
            
        return image;
    }
}
