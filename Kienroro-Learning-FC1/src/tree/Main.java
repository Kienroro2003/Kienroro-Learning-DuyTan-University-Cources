package tree;


public class Main {
    static class Node{
        int key;
        Node left;
        Node right;

        public Node() {
        }

        public Node(int key) {
            this.key = key;
        }

        public Node(int key, Node left, Node right) {
            this.key = key;
            this.left = left;
            this.right = right;
        }
    }

    Node root;

    int evenLeaf(Node node, int k){
        if(node != null){
            int left = evenLeaf(node.left, k);
            int right = evenLeaf(node.right, k);
            return left + right + (node.key % 2 == 0 ? 1 : 0);

        }else{
            return 0;
        }
    }

    int countNodes(Node node, int k){
        if(node != null){
            int left = countNodes(node.left, k);
            int right = countNodes(node.right, k);
            return left + right + (node.key > k  ? 1 : 0);
        }
        return 0;
    }

    int countLeaf(Node node, int k){
        if(node != null){
            int left = countLeaf(node.left, k);
            int right = countLeaf(node.right, k);
            if(left == right && left == 0){
                return 1;
            }
            return  left + right;
        }
        return 0;
    }

    boolean iosmetric(Node t1, Node t2){
        if(t1 != null && t2 != null){
            boolean left = iosmetric(t1.left, t2.left);
            boolean right = iosmetric(t2.right, t2.right);
            return left == right;
        }
        if(t1 == null && t2 !=null || t2 == null && t1 != null){
            return false;
        }
        return true;
    }

    int oddSum(Node node){
        if(node != null){
            int left = oddSum(node.left);
            int right = oddSum(node.right);
            return (node.key % 2 == 1 ? node.key : 0)  + (left % 2 == 1 ? left : 0) + (right % 2 == 1 ? right : 0);
        }
        return 0;
    }

    Node mirror(Node root){
        return null;
    }

    int sum(Node node){
        if(node != null){
            int left = sum(node.left);
            int right = sum(node.right);
            return left + right + node.key;
        }
        return 0;
    }

    int evenMax(Node node){
        if(node != null){
            int left = evenMax(node.left);
            int right = evenMax(node.right);
            return Math.max(Math.max(left, right),node.key);
        }else{
            return Integer.MIN_VALUE;
        }
    }

    boolean isBST(Node node){
        if(node == null){
            return true;
        }

        if(!isBST(node.left) || !isBST(node.right)){
            return false;
        }

        if(node.left != null){
            return false;
        }

        if(node.right != null){
            return false;
        }

        return true;
    }

    void preorderTree(Node root){
        if(root != null){
            System.out.println(root.key);
            preorderTree(root.left);
            preorderTree(root.right);
        }
    }

    public static void main(String[] args) {
        Node root = new Node(27,new Node(19, new Node(13, null, new Node(2,null, null)), new Node(29, new Node(16,null, new Node(25, null, null)),new Node(8,new Node(77,null,new Node(22, null,null)), null))),null);
        Node tree = new Node(0,new Node(0,new Node(0,new Node(0, new Node(0),null),new Node(0)), new Node(0,null,null)),new Node(0, null, null));
        Main main = new Main();
        main.preorderTree(root);
        System.out.println("So nut la co truong du lieu la so chan: " + main.evenLeaf(root, 0));
        System.out.println("So nut lon hon 20 la: " +main.countNodes(root, 20) );
        System.out.println("So la cua cay la: " + main.countLeaf(root, 0));
        System.out.println("Tong cua cac so le duoc cat giu trong nut: " + main.oddSum(root));
        System.out.println("Tong cua cac nut trong cay: " + main.sum(root));
        System.out.println("Info chan lon nhat: " + main.evenMax(root));
        System.out.println("Cay can bang: " + main.isBST(tree));
    }

}
