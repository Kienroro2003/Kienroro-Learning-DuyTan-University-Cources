package repository.impl;

import model.Class;
import model.Student;
import repository.StudentRepository;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class StudentRepositoryImpl implements StudentRepository {
    @Override
    public List<Student> read() {
        List<Student> listStudent = new ArrayList<>();
        File file = new File(PATH);
        FileReader fileReader = null;
        BufferedReader bufferedReader = null;
        try {
            fileReader = new FileReader(file);
            bufferedReader = new BufferedReader(fileReader);
            while (true){
                String line = bufferedReader.readLine();
                if(line == null){
                    break;
                }
                String[] properties = line.split(",");
                Student student = new Student(Integer.parseInt(properties[0]), properties[1], properties[2], properties[3],properties[4], Integer.parseInt(properties[5]));
                listStudent.add(student);
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return listStudent;
    }

    @Override
    public void write(List<Student> studentList) {
        File file = new File(PATH);
        FileWriter writerDataClass = null;
        try {
            writerDataClass = new FileWriter(file);
            for (Student student : studentList){
                writerDataClass.write(student.formatProperties());
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
}
