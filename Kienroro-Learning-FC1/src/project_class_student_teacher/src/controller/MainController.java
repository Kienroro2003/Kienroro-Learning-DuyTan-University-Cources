package controller;

import exception.NotFoundStudentException;
import service.StudentService;
import service.impl.StudentServiceImpl;

import java.util.Scanner;

public class MainController {
    public void displayMenu(){
        while (true){
            StudentService studentService = new StudentServiceImpl();
            Scanner scanner = new Scanner(System.in);
            System.out.println("1. Thêm mới sinh viên");
            System.out.println("2. Xóa sinh viên");
            System.out.println("3. Xem danh sách sinh viên");
            System.out.println("4. Xem thông tin giáo viên");
            System.out.println("5. Tìm kiếm sinh viên");
            System.out.println("6. Thoát");
            int choose = scanner.nextInt();
            switch (choose){
                case 1:{
                    studentService.add();
                    break;
                }
                case 2:{
                    System.out.println("Enter id you hope remove: ");
                    int idStudentRemove = scanner.nextInt();
                    try {
                        studentService.remove(idStudentRemove);
                    } catch (NotFoundStudentException e) {
                        System.out.println(e.getMessage());
                    }
                    break;
                }
                case 3:{
                    studentService.display();
                    break;
                }
                case 4:{

                    break;
                }
                case 5:{
                    System.out.println("Enter name you find: ");
                    String name = scanner.nextLine();
                    if(studentService.find(name) != null){
                        System.out.println(studentService.find(name));
                    }else {
                        System.out.println("The student isn't found ");
                    }
                    break;
                }
                case 6:{
                    studentService.writeToFile();
                    System.exit(0);
                }
            }
        }
    }
}
