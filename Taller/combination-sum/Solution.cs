public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var resultado = new List<IList<int>>();
        var actual = new List<int>();
 
        Array.Sort(candidates);
        Backtrack(candidates, target, 0, actual, resultado);
 
        return resultado;
    }

    private void Backtrack(int[] c, int resto, int inicio, List<int> actual, List<IList<int>> resultado) {
        if (resto == 0) {
            resultado.Add(new List<int>(actual));
            return;
        }
 
        for (int i = inicio; i < c.Length; i++) {
            if (c[i] > resto) break;
 
            actual.Add(c[i]);
            Backtrack(c, resto - c[i], i, actual, resultado);
            actual.RemoveAt(actual.Count - 1);
        }
    }
}