package service;

import model.Class;
import repository.ClassRepository;
import repository.impl.ClassRepositoryImpl;

import java.util.List;

public interface ClassService {
    ClassRepository dataClass = new ClassRepositoryImpl();
    List<Class> listClass = dataClass.read();

    List<Class> getListClass();

    int displayMenuClass();
}
