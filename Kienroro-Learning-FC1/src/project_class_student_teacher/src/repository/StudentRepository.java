package repository;

import model.Student;

import java.util.List;

public interface StudentRepository {
    String PATH = "/Users/kienroro2003/Documents/CodeGym/Document/Module 2/project_class_student_teacher/src/data/student.csv";
    List<Student> read();
    void write(List<Student> studentList);
}
