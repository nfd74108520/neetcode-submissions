public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int l = 0, r = heights.Length - 1;
        while (l < r) {
            int w = r - l;
            int h = Math.Min(heights[l], heights[r]);
            result = Math.Max((w * h), result);

            if (heights[l] < heights[r])
                l++;
            else
                r--;
        }
        return result;
    }
}
