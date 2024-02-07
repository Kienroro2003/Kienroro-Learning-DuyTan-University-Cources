import java.math.BigInteger;

public class FiboMatrix {
    public static int fibonacci(int n) {
        if (n == 0 || n == 1) {
            return n;
        }

        int[][] mat = {{1, 1}, {1, 0}};
        int[][] result = power(mat, n - 1);

        return result[0][1];
    }

    public static int[][] power(int[][] mat, int n) {
        if (n == 1) {
            return mat;
        }

        int[][] half = power(mat, n / 2);

        if (n % 2 == 0) {
            return multiply(half, half);
        } else {
            return multiply(multiply(half, half), mat);
        }
    }

    public static int[][] multiply(int[][] mat1, int[][] mat2) {
        int[][] result = new int[2][2];

        result[0][0] = mat1[0][0] * mat2[0][0] + mat1[0][1] * mat2[1][0];
        result[0][1] = mat1[0][0] * mat2[0][1] + mat1[0][1] * mat2[1][1];
        result[1][0] = mat1[1][0] * mat2[0][0] + mat1[1][1] * mat2[1][0];
        result[1][1] = mat1[1][0] * mat2[0][1] + mat1[1][1] * mat2[1][1];

        return result;
    }

    public static void main(String[] args) {
        BigInteger bigInteger = BigInteger.ONE;
    }
}
