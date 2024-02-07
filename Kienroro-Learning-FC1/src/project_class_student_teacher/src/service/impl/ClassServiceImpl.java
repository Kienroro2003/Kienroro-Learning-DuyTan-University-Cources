package service.impl;

import model.Class;
import service.ClassService;

import java.util.List;
import java.util.Scanner;

public class ClassServiceImpl implements ClassService {
    @Override
    public List<Class> getListClass() {
        return listClass;
    }

    @Override
    public int displayMenuClass() {
        Scanner scanner = new Scanner(System.in);
        for (Class c : listClass){
            System.out.println("Id: " + c.getId() + ", Name: " + c.getName());
        }
        int choose = scanner.nextInt();
        return choose;
    }
}
