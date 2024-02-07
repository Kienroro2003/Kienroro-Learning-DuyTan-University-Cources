package model;

public class Student {
    private int id;
    private String name;
    private String birthday;
    private String gender;
    private String phoneNumber;
    private int idClass;

    public Student() {
    }

    public Student(int id, String name, String birthday, String gender, String phoneNumber, int idClass) {
        this.id = id;
        this.name = name;
        this.birthday = birthday;
        this.gender = gender;
        this.phoneNumber = phoneNumber;
        this.idClass = idClass;
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

    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public int getIdClass() {
        return idClass;
    }

    public void setIdClass(int idClass) {
        this.idClass = idClass;
    }

    public String formatProperties(){
        return this.id + "," + this.name + "," + this.birthday + "," + this.gender + "," + this.phoneNumber + "," + this.idClass;
    }

    @Override
    public String toString() {
        return "Student{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", birthday='" + birthday + '\'' +
                ", gender='" + gender + '\'' +
                ", phoneNumber='" + phoneNumber + '\'' +
                ", idClass=" + idClass +
                '}';
    }

    public String toString(String nameClass){
        return "Student{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", birthday='" + birthday + '\'' +
                ", gender='" + gender + '\'' +
                ", phoneNumber='" + phoneNumber + '\'' +
                ", class=" + nameClass +
                '}';
    }

    @Override
    public boolean equals(Object obj) {
        Student student = (Student) obj;
        if(this.id == student.id)return true;
        return false;
    }
}
