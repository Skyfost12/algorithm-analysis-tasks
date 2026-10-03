public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int islas = 0;
 
        int[] dr = { -1, 1, 0, 0 };
        int[] dc = { 0, 0, -1, 1 };
 
        var cola = new Queue<int>(); 
 
        for (int r = 0; r < m; r++) {
            for (int c = 0; c < n; c++) {
                if (grid[r][c] != '1') continue; 
 
                islas++;
                grid[r][c] = '0';
                cola.Enqueue(r * n + c);
 
                while (cola.Count > 0) {
                    int cur = cola.Dequeue();
                    int cr = cur / n;
                    int cc = cur % n;
 
                    for (int d = 0; d < 4; d++) {
                        int nr = cr + dr[d];
                        int nc = cc + dc[d];
 
                        if (nr < 0 || nr >= m || nc < 0 || nc >= n) continue;
                        if (grid[nr][nc] != '1') continue;                    
 
                        grid[nr][nc] = '0';       
                        cola.Enqueue(nr * n + nc);
                    }
                }
            }
        }
 
        return islas;
    }
}