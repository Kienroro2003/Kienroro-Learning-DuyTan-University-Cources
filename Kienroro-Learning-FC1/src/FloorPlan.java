import java.util.*;

public class FloorPlan {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int wood = scanner.nextInt();
        int rows = scanner.nextInt();
        int cols = scanner.nextInt();
        scanner.nextLine(); // move scanner to next line
        char[][] floorPlan = new char[rows][cols];
        for (int i = 0; i < rows; i++) {
            floorPlan[i] = scanner.nextLine().toCharArray();
        }
        int[] sizes = new int[30];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (floorPlan[i][j] != '.') {
                    continue;
                }
                int size = dfs(floorPlan, i, j);
                sizes[size]++;
            }
        }
        int numRooms = 0;
        int squareMetresLeft = wood;
        for (int i = 25; i >= 0; i--) {
            while (sizes[i] > 0 && squareMetresLeft >= i) {
                numRooms++;
                squareMetresLeft -= i;
                sizes[i]--;
            }
        }
        System.out.printf("%d rooms, %d square metre(s) left over\n", numRooms, squareMetresLeft);
    }

    private static int dfs(char[][] floorPlan, int row, int col) {
        int size = 0;
        if (row < 0 || row >= floorPlan.length || col < 0 || col >= floorPlan[0].length || floorPlan[row][col] == 'I') {
            return size;
        }
        floorPlan[row][col] = 'I'; // mark as visited
        size++;
        size += dfs(floorPlan, row - 1, col);
        size += dfs(floorPlan, row + 1, col);
        size += dfs(floorPlan, row, col - 1);
        size += dfs(floorPlan, row, col + 1);
        return size;
    }
}
