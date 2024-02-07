public class Dupes {
    class Node {
        int value;
        Node next;

        public Node() {
        }

        public Node(int value) {
            this.value = value;
        }
    }

    Node list;

    void push(int number) {
        Node node = new Node(number);
        if (list == null) {
            list = node;
        } else {
            Node temp = list;
            while (temp.next != null) {
                temp = temp.next;
            }
            temp.next = node;
        }
    }

    Node removeDupes(Node list){
        Node result = list;
        Node temp = list;
        while (temp.next != null){
            if(temp.value == temp.next.value){
                remove(temp.next);
            }else{
                temp = temp.next;
            }
        }

        return result;
    }

    void remove(Node node){
        if(node == list){
            list = list.next;
        }else{
            Node temp = list;
            while (temp.next != node){
                temp = temp.next;
            }
            temp.next = node.next;
        }
    }

    void display(){
        Node temp = list;
        while (temp.next !=null){
            System.out.println(temp.value);
            temp = temp.next;
        }
        System.out.println(temp.value);
    }

    void display(Node list){
        Node temp = list;
        while (temp.next !=null){
            System.out.println(temp.value);
            temp = temp.next;
        }
        System.out.println(temp.value);
    }

    public static void main(String[] args) {
        Dupes dupes = new Dupes();
        dupes.push(2);
        dupes.push(2);
        dupes.push(3);
        dupes.push(3);
        dupes.push(3);
        dupes.push(5);
        dupes.push(5);
        dupes.push(5);
        dupes.push(5);
        dupes.push(6);
        dupes.push(7);
        dupes.display(dupes.removeDupes(dupes.list));
    }
}
