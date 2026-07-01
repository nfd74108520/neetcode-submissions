public class Solution {
    public int Trap(int[] h) {
        int l = 0, r = h.Length - 1;
        int lMax = 0, rMax = 0;
        int total = 0;

        while (l < r) {
            if (h[l] < h[r]) {
                if (h[l] > lMax) {
                    lMax = h[l];
                } else {
                    total += (lMax - h[l]);
                }
                l++;
            } else {
                if (h[r] > rMax) {
                    rMax = h[r];
                } else {
                    total += (rMax - h[r]);
                }
                r--;
            }
        }

        return total;
    }
}
