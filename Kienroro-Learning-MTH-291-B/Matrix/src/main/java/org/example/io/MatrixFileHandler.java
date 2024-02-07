package org.example.io;

import org.example.model.Matrix;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class MatrixFileHandler {
    public static Matrix readFile(String path){
        FileReader fileReader = null;
        BufferedReader bufferedReader = null;
        Matrix matrix = null;
        try {
            fileReader = new FileReader(path);
            bufferedReader = new BufferedReader(fileReader);
            String[] line = bufferedReader.readLine().split(" ");
            int rows = Integer.parseInt(line[0]);
            int cols = Integer.parseInt(line[1]);
            matrix = new Matrix(rows, cols);
            for (int row = 0; row < rows; row++) {
                line = bufferedReader.readLine().split(" ");
                for (int col = 0; col < cols; col++) {
                    matrix.setElement(row, col, Integer.parseInt(line[col]));
                }
            }
            return matrix;

        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
