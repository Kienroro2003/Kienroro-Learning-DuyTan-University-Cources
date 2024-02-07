package service;

import exception.NotFoundStudentException;
import model.Student;
import repository.StudentRepository;
import repository.impl.StudentRepositoryImpl;
import service.impl.ClassServiceImpl;

import java.util.List;

public interface StudentService {
    StudentRepository studentRepository = new StudentRepositoryImpl();
    ClassService classService = new ClassServiceImpl();
    List<Student> list = studentRepository.read();

    void display();

    void add();

    void remove(int id) throws NotFoundStudentException;

    Student find(String name);

    void writeToFile();
}
