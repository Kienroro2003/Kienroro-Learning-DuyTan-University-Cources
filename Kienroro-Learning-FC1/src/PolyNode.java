import javax.xml.soap.Node;
import java.util.Scanner;

public class PolyNode {
    class Node{
        int coeff;
        int pow;
        Node next;

        public Node() {
        }

        public Node(int coeff, int pow) {
            this.coeff = coeff;
            this.pow = pow;
        }

        @Override
        public String toString() {
            String newLine = coeff + "^" + pow;
            return newLine;
        }
    }
    Node poly1;
    Node poly2;

    public PolyNode() {
    }

    void inputPoly(){
        System.out.println("Nhap so bac cua da thuc 1: ");
        int n1 = Integer.parseInt(new Scanner(System.in).nextLine());
        System.out.println("Nhap so bac cua da thuc 2: ");
        int n2 = Integer.parseInt(new Scanner(System.in).nextLine());
        System.out.println("Nhap he so: ");
        int coeff = Integer.parseInt(new Scanner(System.in).nextLine());
        System.out.println("Nhap so mu: ");
        int pow = Integer.parseInt(new Scanner(System.in).nextLine());
        poly1 = new Node(coeff, pow);
        for (int i = 0; i < n1 - 1; i++) {
            System.out.println("Nhap he so: ");
            coeff = Integer.parseInt(new Scanner(System.in).nextLine());
            System.out.println("Nhap so mu: ");
            pow = Integer.parseInt(new Scanner(System.in).nextLine());
            Node node = new Node(coeff,pow);
            node.next = poly1;
            poly1 = node;
        }
        while (poly1 != null){
            System.out.println(poly1);
            poly1 = poly1.next;
        }

    }

    public static void main(String[] args) {
PolyNode polyNode = new PolyNode();
polyNode.inputPoly();
    }
}
