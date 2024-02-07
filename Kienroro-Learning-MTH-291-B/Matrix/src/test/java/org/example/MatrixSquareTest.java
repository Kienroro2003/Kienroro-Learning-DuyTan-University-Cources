package org.example;

import org.example.model.MatrixSquare;

import static org.junit.jupiter.api.Assertions.*;

class MatrixSquareTest {

    @org.junit.jupiter.api.Test
    void isEchelonMatrix() {
        int[][] matrix = {{1,2,3,4},{0,1,0,0,0},{0,0,0,0,0}};
        MatrixSquare matrixSquare = new MatrixSquare(matrix);
        assertEquals(true, matrixSquare.isEchelonMatrix());
    }
}