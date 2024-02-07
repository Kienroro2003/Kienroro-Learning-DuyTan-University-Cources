package search;

import java.util.Random;
import java.util.Scanner;

public class BinarySearch {
    TreeNode makeTreeNode(int value){
        return null;
    }

    TreeNode findMin(TreeNode node){
        TreeNode temp = node;
        while (temp.left != null){
            temp = temp.left;
        }
        return temp;
    }

    TreeNode findMax(TreeNode node){
        TreeNode temp = node;
        while (temp.right != null){
            temp = temp.right;
        }
        return temp;
    }

    TreeNode insert(TreeNode node, int value){
        TreeNode temp = node;
        if(temp == null){
            return new TreeNode(value);
        }else if(node.value > value){
            temp.left = insert(temp.left, value);
        }else if(node.value < value){
            temp.right = insert(temp.right, value);
        }
        return temp;
    }

    void makeTree(TreeNode node){
        Random random = new Random(1);
        if(node.value == 0){
            node.value = random.nextInt(100000);
        }
        System.out.println("Enter the number of elements: ");
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt() - 1;
        for (int i = 0 ; i < n ; i++){
            insert(node, random.nextInt(100000));
        }
    }

    TreeNode search(TreeNode node, int item){
        TreeNode temp = node;
        if(temp.value < item){
            search(temp.right, item);
        }else if(temp.value > item){
            search(temp.left, item);
        }else{
            return temp;
        }
        return null;
    }



    void printInorder(TreeNode node){
        if(node != null){
            printInorder(node.left);
            System.out.print(node.value + " ");
            printInorder(node.right);
        }

    }

    void printPreorder(TreeNode node){
        if(node != null){
            System.out.print(node.value + " ");
            printPreorder(node.left);
            printPreorder(node.right);
        }
    }

    public TreeNode delete(TreeNode node, int x){
        TreeNode tmp;
        if(node == null)return null;
        else if(x < node.value) node.left = delete(node.left, x);
        else if(x > node.value) node.right = delete(node.right, x);
        else if(node.right != null && node.left != null){
            tmp = findMin(node.right);
            node.value = tmp.value;
            node.right = delete(node.right, x);
        }else{
            if(node.left == null){
                node = node.right;
            }else{
                node = node.left;
            }
        }
        return node;
    }

    void printPostorder(TreeNode node){
        if(node != null){
            printPostorder(node.left);
            printPostorder(node.right);
            System.out.print(node.value + " ");
        }
    }

    public TreeNode successor(TreeNode node){
        if(node.right != null){
            return findMin(node.right);
        }else{

        }
        return null;
    }


}
