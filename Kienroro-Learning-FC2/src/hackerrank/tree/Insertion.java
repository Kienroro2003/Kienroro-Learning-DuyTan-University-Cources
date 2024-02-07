package hackerrank.tree;

import java.util.*;


public class Insertion {

    public static void preOrder( Node root ) {

        if( root == null)
            return;

        System.out.print(root.data + " ");
        preOrder(root.left);
        preOrder(root.right);

    }

 /* Node is defined as :
 class Node
    int data;
    Node left;
    Node right;

    */

    public static Node insert(Node root, int data) {
        if(root == null){
            root = new Node(data);
        }else if(root.data > data){
            root.left = insert(root.left, data);
        }else{
            root.right = insert(root.right, data);
        }
        return root;
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int t = scan.nextInt();
        Node root = null;
        while(t-- > 0) {
            int data = scan.nextInt();
//            System.out.println(insert(root, data).data);
            root = insert(root, data);
        }
        scan.close();
        preOrder(root);
    }
}
