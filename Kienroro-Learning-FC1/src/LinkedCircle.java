public class LinkedCircle {
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
            list.next = list;
        } else {
            Node temp = list;
            while (temp.next != list) {
                temp = temp.next;
            }
            temp.next = node;
            node.next = list;
        }
    }

    int count(Node node){
        int result = 0;
        if(node == null){
            return 0;
        }else {
            Node temp = node;
            while (temp.next != node){
                result++;
                temp = temp.next;
            }
        }
        return result;
    }

    void display() {
        Node temp = list;
        while (temp.next != list) {
            System.out.println(temp.value);
            temp = temp.next;
        }
    }

    public static void main(String[] args) {
        LinkedCircle linkedCircle = new LinkedCircle();
        linkedCircle.push(1);
        linkedCircle.push(2);
        linkedCircle.push(3);
        linkedCircle.push(4);
        linkedCircle.push(5);
        linkedCircle.display();
        System.out.println("Count: " + linkedCircle.count(linkedCircle.list));
    }
}
