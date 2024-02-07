import tree.Main;

public class Mian {
    class Node {
        int value;
        Node next;

        public Node() {
        }

        public Node(int value) {
            this.value = value;
        }
    }

    class Tree{
        int[] arrayTree;
        int[] label;
        Node node;
    }

    class BinaryTree{
        int value;
        Node nodeLeft;
        Node nodeRight;
    }

    Node list;

    void push(int value) {
        Node node = new Node(value);
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

    void display() {
        Node temp = list;
        while (temp.next != null) {
            System.out.print(temp.value + " ");
            temp = temp.next;
        }
        System.out.println(temp.value);
    }

    int delete(int value){
        Node node = null;
        Node temp = list;
        while (temp.next.value != value){
            temp = temp.next;
        }
        node = temp.next;
        temp.next = temp.next.next;
        return node.value;
    }

    int deleteArray(int[] arr, int value){
        for (int i = 0; i < arr.length - 1; i++){
          if(arr[i] == value){
              for (int j = i + 1; j < arr.length; j++) {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
              }
          }
        }
        return value;
    }

    static int fib(int value){
        if(value == 1 || value == 0)return value;

        int fib = fib(value - 1);
        int fib1 = fib(value - 2);
        return fib + fib1;
    }

    static void displayRecurse(int[] arr, int length){
        if(length >= 0){
            System.out.println(arr[length]);
            displayRecurse(arr, length-1);
        }
    }


    public static void main(String[] args) {
        int[] array = {1, 2, 3, 4};
        /**
         * hao phi tai nguyen
         * dung trong truong hop truy xuat phan tu
         * them xoa sua cham
         */
        displayRecurse(array, array.length - 1);
    }
}
