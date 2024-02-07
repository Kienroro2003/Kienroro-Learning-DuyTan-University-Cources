//package hackerrank.linkedlist;
//
//import hackerrank.Solution2;
//
//import java.io.BufferedWriter;
//import java.io.File;
//import java.io.FileWriter;
//import java.io.IOException;
//import java.util.Scanner;
//
//public class InsertHead {
//    static class  Node {
//        int value;
//        Node next;
//
//        public Node(int value, Node next) {
//            this.value = value;
//            this.next = next;
//        }
//    }
//    Node root;
//
//
//    public void display(){
//        while(root != null){
//            System.out.println(root.value);
//            root = root.next;
//        }
//    }
//
//
//    public static void main(String[] args) throws IOException {
//        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(new File("/Users/kienroro2003/Documents/My MacOS/DuyTan/Fundamentals of Computing/FC2/src/hackerrank/result")));
//
//
//        int llistCount = scanner.nextInt();
////        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
//
//        for (int i = 0; i < llistCount; i++) {
//            int llistItem = scanner.nextInt();
////            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
//
//            llist.insertNode(llistItem);
//        }
//
////        int data = scanner.nextInt();
////        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
//
//        int position = scanner.nextInt();
////        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
//
//        Solution2.SinglyLinkedListNode llist_head = deleteNode(llist.head, position);
//
//        printSinglyLinkedList(llist_head, " ", bufferedWriter);
//        bufferedWriter.newLine();
//
//        bufferedWriter.close();
//
//        scanner.close();
//    }
//}
