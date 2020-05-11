public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        if (image[sr][sc] == newColor)
            return image;
        
        fill(image, sr, sc, newColor, image[sr][sc]);
        return image;
    }
    
    public void fill(int[][] image, int sr, int sc, int newColor, int originalColor) {
        if (sc < 0 || sr < 0 || sr >= image.Length || sc >= image[0].Length || image[sr][sc] != originalColor)
            return;
        
        image[sr][sc] = newColor;
        fill(image, sr-1, sc, newColor, originalColor);
        fill(image, sr+1, sc, newColor, originalColor);
        fill(image, sr, sc-1, newColor, originalColor);
        fill(image, sr, sc+1, newColor, originalColor);
    }
}
