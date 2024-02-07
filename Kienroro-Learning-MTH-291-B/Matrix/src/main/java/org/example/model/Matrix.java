package org.example.model;

import java.util.Scanner;

public class Matrix {
    protected int rows;
    protected int cols;
    protected int[][] matrix;

    public Matrix() {
    }

    public Matrix(int rows, int cols) {
        this.rows = rows;
        this.cols = cols;
        this.matrix = new int[this.rows][this.cols];
    }

    public Matrix(int[][] matrix) {
        this.matrix = matrix;
        this.rows = matrix.length;
        this.cols = matrix[0].length;
    }

    public Matrix(Matrix another){
        this.matrix = another.matrix;
        this.cols = another.cols;
        this.rows = another.rows;
    }

    public int getRows() {
        return rows;
    }

    public void setRows(int rows) {
        this.rows = rows;
    }

    public int getCols() {
        return cols;
    }

    public void setCols(int cols) {
        this.cols = cols;
    }

    public int[][] getMatrix() {
        return matrix;
    }

    public void setMatrix(int[][] matrix) {
        this.matrix = matrix;
    }

    public int getElement(int row, int col){
        return this.matrix[row][col];
    }

    public void setElement(int row, int col, int newValue){
        this.matrix[row][col] = newValue;
    }

    public Matrix transposeMatrix(){
        Matrix transpose = new Matrix(this.cols, this.rows);
        for (int row = 0; row < this.rows; row++) {
            for (int col = 0; col < cols; col++) {
                transpose.matrix[col][row] = matrix[row][col];
            }
        }
        return transpose;
    }

    public void displayMatrix(){
        for (int row = 0; row < this.rows; row++) {
            for (int col = 0; col < this.cols; col++) {
                System.out.format("%d\t\t", this.matrix[row][col]);
            }
            System.out.println("\n");
        }
    }

    public void inputMatrix(){
        Scanner sc = new Scanner(System.in);
        if(this.rows == 0 || this.cols == 0){
            System.out.print("Enter rows: ");
            this.rows = sc.nextInt();
            System.out.print("Enter cols: ");
            this.cols = sc.nextInt();
        }
        for (int row = 0; row < this.rows; row++) {
            for (int col = 0; col < this.cols; col++) {
                System.out.format("Enter matrix[%d][%d]: ", row, col);
                this.matrix[row][col] = sc.nextInt();
            }
        }
    }

    public Matrix plusMatrix(Matrix matrix){
        try{
            if(this.rows != matrix.getRows() || this.cols != matrix.getCols())throw new NumberFormatException("These 2 matrices are not the same");
            Matrix resMatrix = new Matrix(this);
            for (int row = 0; row < this.rows; row++) {
                for (int col = 0; col < this.cols; col++) {
                    resMatrix.matrix[row][col] += matrix.matrix[row][col];
                }
            }
            return resMatrix;
        }catch (NumberFormatException e){
            System.out.println(e.getMessage());
            return null;
        }
    }

    public Matrix minusMatrix(Matrix matrix){
        try{
            if(this.rows != matrix.getRows() || this.cols != matrix.getCols())throw new NumberFormatException("These 2 matrices are not the same");
            Matrix resMatrix = new Matrix(this);
            for (int row = 0; row < this.rows; row++) {
                for (int col = 0; col < this.cols; col++) {
                    resMatrix.matrix[row][col] -= matrix.matrix[row][col];
                }
            }
            return resMatrix;
        }catch (NumberFormatException e){
            System.out.println(e.getMessage());
            return null;
        }
    }

    public Matrix multiplyMatrixByScalar(int c){
        Matrix resMatrix = new Matrix(this);
        for (int row = 0; row < this.rows; row++) {
            for (int col = 0; col < this.cols; col++) {
                resMatrix.matrix[row][col] *= c;
            }
        }
        return resMatrix;
    }

    public Matrix multiplyMatrixByMatrix(Matrix matrix){
        Matrix resMatrix = new Matrix(this.rows, matrix.cols);

        for (int row = 0; row < this.rows; row++) {
            for (int k = 0; k < matrix.cols; k++) {
                for (int col = 0; col < this.cols; col++) {
                    resMatrix.matrix[row][k] += this.matrix[row][col] * matrix.matrix[col][k];
                }
            }
        }
        return resMatrix;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Matrix matrix = (Matrix) o;
        if(this.rows == matrix.rows && this.cols == matrix.cols){
            for (int row = 0; row < this.rows; row++) {
                for (int col = 0; col < this.cols; col++) {
                    if(this.matrix[row][col] != matrix.getMatrix()[row][col])return false;
                }
            }
            return true;
        }
        return false;
    }

    @Override
    public int hashCode() {
        return 2024;
    }
}
