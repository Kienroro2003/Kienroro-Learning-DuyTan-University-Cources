package model;

public class Class {
    private int id;
    private String name;
    private int idTeacher;

    public Class() {
    }

    public Class(int id, String name, int idTeacher) {
        this.id = id;
        this.name = name;
        this.idTeacher = idTeacher;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getIdTeacher() {
        return idTeacher;
    }

    public void setIdTeacher(int idTeacher) {
        this.idTeacher = idTeacher;
    }

    public String formatProperty(){
        return id + "," + name + "," + idTeacher;
    }

    @Override
    public String toString() {
        return "Class{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", idTeacher=" + idTeacher +
                '}';
    }
}
