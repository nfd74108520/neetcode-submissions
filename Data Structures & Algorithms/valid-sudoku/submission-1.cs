public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> validSet = new HashSet<string>();
        for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board.Length; c++) {
                char val = board[r][c];

                if (val == '.')
                    continue;

                string rFingerPrint = $"r{r}{val}";
                string cFingerPrint = $"c{c}{val}";

                int bZone = (r / 3) * 3 + (c / 3);
                string bFingerPrint = $"b{bZone}{val}";

                if (validSet.Contains(rFingerPrint) || validSet.Contains(cFingerPrint) ||
                    validSet.Contains(bFingerPrint))
                    return false;

                validSet.Add(rFingerPrint);
                validSet.Add(cFingerPrint);
                validSet.Add(bFingerPrint);
            }
        }

        return true;
    }
}
