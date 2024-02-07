package org.example;

import org.example.io.MatrixFileHandler;
import org.example.model.Matrix;
import org.example.model.MatrixSquare;
import org.example.model.MatrixUnit;

public class Main {
    public static void main(String[] args) {
//        Scanner sc = new Scanner(System.in);
//        System.out.println("Enter rows: ");
//        int rows = sc.nextInt();
//        System.out.println("Enter cols: ");
//        int cols = sc.nextInt();
//        int[][] matrix = new int[rows][cols];
//        for (int row = 0; row < rows; row++) {
//            for (int col = 0; col < cols; col++) {
//                System.out.format("Enter matrix[%d][%d]:\t", row + 1, col + 1);
//                matrix[row][col] = sc.nextInt();
//            }
//        }
//        displayMatrix(matrix);
//        displayMatrixDiagonalPrincipal(matrix);
//        displayMatrixDiagonalMinor(matrix);
//        MatrixSquare matrixSquare = new MatrixSquare(2);

//        Matrix matrix = new Matrix(new int[][]{{1,2,3,4},{5,6,7,8},{9,10,11,12}});
//        matrix.displayMatrix();
//        Matrix transposeMatrix = matrix.transposeMatrix();
//        transposeMatrix.displayMatrix();

        Matrix matrix = MatrixFileHandler.readFile("src/main/java/org/example/data/data-matrix");
        MatrixSquare matrixSquare = new MatrixSquare(matrix.getMatrix());
        System.out.println("Res: " + matrixSquare.getDet());
//        Matrix newMatrix = matrix.multiplyMatrixByScalar(3);
//        newMatrix.displayMatrix();
//
//        Matrix matrix1 = MatrixFileHandler.readFile("src/main/java/org/example/data/matrix-1");
//        MatrixUnit unit = (MatrixUnit) matrix1;
//        unit.displayMatrix();
//        Matrix matrix2 = MatrixFileHandler.readFile("src/main/java/org/example/data/matrix-2");
//        Matrix matrix3 = MatrixFileHandler.readFile("src/main/java/org/example/data/matrix-3");
//        Matrix res = matrix1.plusMatrix(matrix2);
//        res.plusMatrix(matrix3).displayMatrix();

    }


    public static void displayMatrix(int[][] matrix) {
        int rows = matrix.length;
        int cols = matrix[0].length;
        for (int row = 0; row < rows; row++) {
            System.out.format("Row %d:\t", row + 1);
            for (int col = 0; col < cols; col++) {
                System.out.format("%d\t\t", matrix[row][col]);
            }
            System.out.println("\n");
        }
    }

    public static void displayMatrixSquare(int[][] matrix) {
        //TODO: display a matrix square if rows equals cols
    }

    public static void displayMatrixTriangle(int[][] matrix) {
        //TODO: display a matrix triangle
    }

    public static void displayMatrixUnit(int[][] matrix) {
        //TODO: display a matrix unit
    }

    public static void displayMatrixEchelon(int[][] matrix) {
        //TODO: display a echelon matrix
    }

    public static boolean isMatrixSquare(int[][] matrix) {
        int rows = matrix.length;
        int cols = matrix[0].length;
        return isMatrixSquare(rows, cols);
    }

    public static boolean isMatrixSquare(int rows, int cols) {
        return rows == cols;
    }

    public static void displayMatrixDiagonalPrincipal(int[][] matrix) {
        if (!isMatrixSquare(matrix)) {
            System.out.println("It isn't a matrix square");
            return;
        }
        int rows = matrix.length;
        System.out.print("Diagonal matrix:\t");
        for (int row = 0; row < rows; row++) {
            System.out.format("%d\t\t", matrix[row][row]);
        }
        System.out.println();
    }

    public static void displayMatrixDiagonalMinor(int[][] matrix) {
        if (!isMatrixSquare(matrix)) {
            System.out.println("It isn't a matrix square");
            return;
        }
        ;
        int rows = matrix.length;
        System.out.print("Minor matrix:\t");
        for (int row = 0; row < rows; row++) {
            System.out.format("%d\t\t", matrix[row][rows - row - 1]);
        }
        System.out.println();
    }

    public static boolean isSameMatrix(int[][] matrix1, int[][] matrix2) {
        int rows1 = matrix1.length;
        int cols1 = matrix1[0].length;
        int rows2 = matrix2.length;
        int cols2 = matrix2[0].length;
        return isSameMatrix(rows1, cols1, rows2, cols2);
    }

    public static boolean isSameMatrix(int rows1, int cols1, int rows2, int cols2) {
        return rows1 == rows2 && cols1 == cols2;
    }

    public static void plusMatrix(int[][] matrix1, int[][] matrix2) {
        if (!isSameMatrix(matrix1, matrix2)) {
            System.out.println("These isn't same matrix");
            return;
        }
        int rows = matrix1.length;
        int cols = matrix1[0].length;
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; cols++) {

            }
        }
    }
}