public class OddEven {
    class Node{
        int Inf;
        Node node;
    }

    Node list;

    void push(int param){
        Node temp = new Node();
        temp.Inf = param;
        if(list == null){
            list = temp;
        }else{
            temp.node = list;
            Node copy = list;
            while (copy.node != null){
                copy = copy.node;
            }
            copy.node = temp;
        }

    }

    void count(Node ptr){
        if(list == null){
            System.out.println("empty");
        }else{
            boolean[] ar = new boolean[100];
            int c = 1;
            while (!ar[ptr.Inf]){
                c++;
                ptr = ptr.node;
            }
            System.out.println("Count " + c);
        }
    }
    void display(){
        while (list != null){
            System.out.print(list.Inf + " ");
            list = list.node;
        }
    }



    void displayOddEven(){
        int odd = 0;
        int even = 0;
        while(list != null){
            if(list.Inf % 2 == 0){
                even++;
            }else{
                odd++;
            }
            list = list.node;
        }
        System.out.println("The number of odd: " + odd);
        System.out.println("The number of even: " + even);
    }

    public static void main(String[] args) {
        OddEven oddEven = new OddEven();
        oddEven.push(1);
        oddEven.push(2);
        oddEven.push(3);
        oddEven.push(4);
        oddEven.push(5);
        oddEven.push(6);
        oddEven.push(7);
        oddEven.push(8);
        oddEven.push(9);
        oddEven.push(10);
        oddEven.display();
//        oddEven.displayOddEven();
//        oddEven.count();
    }
}
