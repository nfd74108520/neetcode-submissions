public class Solution {
    public int MaxArea(int[] hs) {
        int maxest = 0;
        for (int l = 0; l < hs.Length; l++) {
            for (int r = hs.Length - 1; r > l; r--) {
                int w = r - l;
                int h = 0;

                if (hs[l] < hs[r])
                    h = hs[l];
                else
                    h = hs[r];

                int max = w * h;

                if (max > maxest) {
                    maxest = max;
                }
            }
        }

        return maxest;
    }
}
