package org.example;

import org.example.model.Matrix;
import org.example.model.MatrixSquare;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class MatrixTest {

    @Test
    void testEquals() {
        Matrix matrix1 = new MatrixSquare(new int[][]{{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}});
        Matrix matrix2 = new MatrixSquare(new int[][]{{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}});
        assertEquals(true, matrix1.equals(matrix2));

    }

    @Test
    void testTransposeMatrix(){
        Matrix matrix = new MatrixSquare(new int[][]{{1,2,3,4},{5,6,7,8},{9,10,11,12}});
        matrix.displayMatrix();
        Matrix transposeMatrix = matrix.transposeMatrix();
        transposeMatrix.displayMatrix();
    }
}