package view;

import controller.MainController;
import exception.NotFoundStudentException;
import model.Class;
import service.ClassService;
import service.StudentService;
import service.impl.ClassServiceImpl;
import service.impl.StudentServiceImpl;

public class Main {
    public static void main(String[] args) {
        MainController main = new MainController();
        main.displayMenu();
    }
}
