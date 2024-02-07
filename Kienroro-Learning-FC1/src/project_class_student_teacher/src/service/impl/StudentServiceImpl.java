package service.impl;

import exception.NotFoundStudentException;
import model.Class;
import model.Student;
import service.StudentService;
import validation.StudentValidate;

import java.util.Scanner;

public class StudentServiceImpl implements StudentService {
    @Override
    public void display() {
        for(Student student : list){
            for (Class c : classService.getListClass()){
                if(student.getIdClass() == c.getId()){
                    System.out.println(student.toString(c.getName()));
                }
            }
        }
    }

    @Override
    public void add() {
        StudentValidate validate = new StudentValidate();
        Scanner scanner = new Scanner(System.in);
        Student student = new Student();
        student.setId(list.size() + 1);
        System.out.println("Enter student's name: ");
        student.setName(scanner.nextLine());
        while (!validate.checkName(student.getName())){
            System.out.println("Enter student's name again: ");
            student.setName(scanner.nextLine());
        }
        System.out.println("Enter your birthday: ");
        student.setBirthday(scanner.nextLine());
        while (!validate.checkDate(student.getBirthday())){
            System.out.println("Enter student's birthday again: ");
            student.setBirthday(scanner.nextLine());
        }
        System.out.println("Enter student's gender: ");
        student.setGender(scanner.nextLine());
        while (student.getGender().equals("")){
            System.out.println("Enter student's gender again: ");
            student.setGender(scanner.nextLine());
        }
        System.out.println("Enter student's phone number: ");
        student.setPhoneNumber(scanner.nextLine());
        while (!validate.checkPhoneNumber(student.getPhoneNumber())){
            System.out.println("Enter student's phone number again: ");
            student.setPhoneNumber(scanner.nextLine());
        }
        System.out.println("Choose student's class: ");
        student.setIdClass(classService.displayMenuClass());
        list.add(student);
    }

    @Override
    public void remove(int id) throws NotFoundStudentException {
        Scanner scanner = new Scanner(System.in);
        for (Student student : list){
            if (student.getId() == id){
                System.out.println("Confirm? 1.YES 2.NO");
                String confirm = scanner.nextLine();
                if(confirm.equalsIgnoreCase("YES")){
                    list.remove(student);
                    display();
                    return;
                }else{
                    return;
                }
            }
        }
        throw new NotFoundStudentException();
    }

    @Override
    public Student find(String name) {
        for (Student student : list){
            if(student.getName().equals(name)){
                return student;
            }
        }
        return null;
    }

    @Override
    public void writeToFile() {
        studentRepository.write(list);
    }
}
