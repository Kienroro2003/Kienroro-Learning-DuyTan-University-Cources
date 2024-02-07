class ClassNode{
    String nameClass;
    ClassNode next;
    StudentNode students;

    public ClassNode() {
    }

    public ClassNode(String nameClass, StudentNode students) {
        this.nameClass = nameClass;
        this.students = students;
    }

    public ClassNode(String nameClass, StudentNode students, ClassNode next) {
        this.nameClass = nameClass;
        this.next = next;
        this.students = students;
    }
}

class StudentNode{
    String name;
    StudentNode next;

    public StudentNode() {
    }

    public StudentNode(String name) {
        this.name = name;
    }

    public StudentNode(String name, StudentNode next) {
        this.name = name;
        this.next = next;
    }

}


public class LinkedStudent {
    ClassNode classNode;

    int numStudents(ClassNode clPoint){
        int count = 0;
        if(clPoint.students == null){
            return count;
        }else{
            StudentNode temp = clPoint.students;
            while (temp.next != null){
                count++;
                temp = temp.next;
            }
            return ++count;
        }
    }

    int numStudent(ClassNode list, String nameClass){
        ClassNode temp = list;
        while (temp != null){
            if(temp.nameClass.equals(nameClass)){
                return numStudents(temp);
            }
            temp = temp.next;
        }
        return 0;
    }

    public static void main(String[] args) {
        LinkedStudent linkedStudent = new LinkedStudent();
        linkedStudent.classNode = new ClassNode();
        linkedStudent.classNode.nameClass = "K51";
        linkedStudent.classNode.students = new StudentNode("An", new StudentNode("Anh", new StudentNode("Ban", new StudentNode("Ba",null))));
        LinkedStudent linkedStudent2 = new LinkedStudent();
        linkedStudent2.classNode = new ClassNode();
        linkedStudent2.classNode.nameClass = "K49";
        linkedStudent2.classNode.students = new StudentNode("Hoa", new StudentNode("Lan", new StudentNode("Mai", new StudentNode("Mi",new StudentNode("Hoan", null)))));
        LinkedStudent linkedStudent3 = new LinkedStudent();
        linkedStudent3.classNode = new ClassNode();
        linkedStudent3.classNode.nameClass = "K52";
        linkedStudent3.classNode.students = new StudentNode("La", new StudentNode("Phong", new StudentNode("Ga", new StudentNode("Phong",null))));
        LinkedStudent linkedStudent4 = new LinkedStudent();
        linkedStudent4.classNode = new ClassNode();
        linkedStudent4.classNode.nameClass = "K50";
        linkedStudent4.classNode.students = new StudentNode("Quang", new StudentNode("Phan", new StudentNode("Van", new StudentNode("Chanh",null))));
        LinkedStudent linkedStudent5 = new LinkedStudent();
        linkedStudent5.classNode = new ClassNode();
        linkedStudent5.classNode.nameClass = "K53";
        linkedStudent5.classNode.students = new StudentNode("Nam", new StudentNode("Ngoan", new StudentNode("Chu", new StudentNode("Lam",null))));
        linkedStudent.classNode.next = linkedStudent2.classNode;
        linkedStudent2.classNode.next = linkedStudent3.classNode;
        linkedStudent3.classNode.next = linkedStudent4.classNode;
        linkedStudent4.classNode.next = linkedStudent5.classNode;
        int total = linkedStudent.numStudent(linkedStudent.classNode, "K51");
        System.out.println("Tong so hoc sinh: " + total);

    }

}
