package org.example.model;

import org.example.model.Matrix;

public class MatrixSquare extends Matrix {
    public MatrixSquare() {
    }

    public MatrixSquare(int rows){
        this.rows = rows;
        this.cols = this.rows;
        this.matrix = new int[this.rows][this.cols];
    }

    public MatrixSquare(int[][] matrix) {
       try{
           this.rows = matrix.length;
           this.cols = matrix[0].length;
           if(rows != cols)throw new NumberFormatException("The matrix is not in the correct format");
           this.matrix = matrix;
       }catch (NumberFormatException e){
           System.out.println(e.getMessage());
       }
    }

    public boolean isMatrixUnit(){
        if(this.matrix == null) return false;
        for (int row = 0; row < this.rows; row++) {
            for (int col = 0; col < this.rows; col++) {
                if((row == col && matrix[row][col] != 1) ||( row != col && matrix[row][col] != 0))return false;
            }
        }
        return true;
    }

    public void displayPositiveMatrix(){
        if(this.rows % 2 == 0 || this.matrix == null)return;
        System.out.print("Positive matrix: ");
        for (int i = 0; i < this.rows; i++) {
            System.out.format("%d\t", this.matrix[i][i]);
        }
    }

    public boolean isUpperTriangularMatrix(){
        if(this.matrix == null) return false;
        for (int row = 1; row < this.rows; row++) {
            for (int col = 0; col < row; col++) {
                if(this.matrix[row][col] != 0)return false;
            }
        }
        return true;
    }

    public boolean isLowerTriangularMatrix(){
        if(this.matrix == null) return false;
        for (int row = 0; row < this.rows - 1; row++) {
            for (int col = row + 1; col < this.rows; col++) {
                if(this.matrix[row][col] != 0)return false;
            }
        }
        return true;
    }

    public boolean isEchelonMatrix(){
        if(this.matrix == null)return false;
        int index = -1;
        for (int row = 0; row < this.rows; row++) {
            int col = 0;
            for (; col < this.rows; col++) {
                if(this.matrix[row][col] != 0)break;
            }
            if(col > index || col == this.rows)index = col;
            else return false;
        }
        return true;
    }

    public Matrix matrixPower(int k){
        if(k == 1)return this;
        return multiplyMatrixByMatrix(matrixPower(k-1));
    }

    public int getDet(){
        int res = 0;
        if(matrix.length == 2)return matrix[0][0] * matrix[1][1] - matrix[1][0] * matrix[0][1];
        for (int row = 0; row < this.rows; row++) {
            MatrixSquare newMatrix = new MatrixSquare(this.rows - 1);
            int indexRowNewMatrix = 0;
            int indexColNewMatrix = 0;
            for (int rowClone = 0; rowClone < this.rows; rowClone++) {
                if(rowClone == row)continue;
                for (int colClone = 1; colClone < this.cols; colClone++) {
                    newMatrix.matrix[indexRowNewMatrix][indexColNewMatrix++] = this.matrix[rowClone][colClone];
                    if(indexColNewMatrix == newMatrix.cols){
                        indexRowNewMatrix++;
                        indexColNewMatrix = 0;
                    }
                }
            }
            res += (row % 2 == 0 ? 1 : -1) * newMatrix.getDet() * this.matrix[row][0];
        }
        return res;
    }
}
