package repository;

import model.Class;

import java.util.List;

public interface ClassRepository {
    String PATH = "/Users/kienroro2003/Documents/CodeGym/Document/Module 2/project_class_student_teacher/src/data/batchs.csv";

    void write(List<Class> classList);

    List<Class> read();


}
