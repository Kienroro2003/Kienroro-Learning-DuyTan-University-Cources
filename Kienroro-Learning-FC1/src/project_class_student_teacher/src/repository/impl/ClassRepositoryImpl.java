package repository.impl;

import model.Class;
import repository.ClassRepository;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class ClassRepositoryImpl implements ClassRepository {
    @Override
    public void write(List<Class> classList) {
        File file = new File(PATH);
        FileWriter writerDataClass = null;
        try {
            writerDataClass = new FileWriter(file);
            for (Class item : classList){
                writerDataClass.write(item.formatProperty());
                writerDataClass.write("\n");
            }
        } catch (IOException e) {
            e.printStackTrace();
        }finally {
            try {
                writerDataClass.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    @Override
    public List<Class> read() {
        File file = new File(PATH);
        FileReader readDataToCSV = null;
        List<Class> classList = new ArrayList<>();
        BufferedReader bufferedReader = null;
        try {
            readDataToCSV = new FileReader(file);
            bufferedReader = new BufferedReader(readDataToCSV);
            while (true){
                String line = bufferedReader.readLine();
                if(line == null){
                    break;
                }
                String[] properties = line.split(",");
                Class newClass = new Class(Integer.parseInt(properties[0]), properties[1], Integer.parseInt(properties[2]));
                classList.add(newClass);
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                bufferedReader.close();
                readDataToCSV.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        return classList;
    }
}
