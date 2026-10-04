public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        int n = intervals.Length;
 
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int aceptados = 1;
        int finUltimo = intervals[0][1];
        
        for (int i = 1; i < n; i++) {
            if (intervals[i][0] >= finUltimo) {
                aceptados++;
                finUltimo = intervals[i][1];
            }
        }
        return n - aceptados;
    }
}