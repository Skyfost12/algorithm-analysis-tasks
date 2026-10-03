public class Solution {
    public int[][] Merge(int[][] intervals) {          
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        int start = intervals[0][0];
        int end = intervals[0][1];

        for(int i = 1; i < intervals.Length; i++){
            int s = intervals[i][0];
            int e = intervals[i][1];

            if(s <= end){
                end = Math.Max(end,e);
            }else{
                result.Add(new int[] {start, end});
                start = s;
                end = e;
            }
        }
        result.Add(new int[] {start,end});
        return result.ToArray();
    } 
}