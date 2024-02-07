package search;

public class Main {
    public static void main(String[] args) {
        TreeNode tree = new TreeNode();
        BinarySearch binarySearch = new BinarySearch();
        binarySearch.makeTree(tree);
        binarySearch.printInorder(tree);

    }
}
