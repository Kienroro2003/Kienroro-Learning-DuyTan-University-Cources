package sort;

public class TestQuickSort {
//    static void swap(int[] array, int index1, int index2){
//        int temp = array[index1];
//        array[index1] = array[index2];
//        array[index2] = temp;
//    }
//
//    static int partition(int[] array, int left, int right){
//        int i, j, p;
//        i = left;
//        j = right + 1;
//        p = array[left];
//        while (i < j){
//            i = i + 1;
//            while ((i <= right) && array[i] < p) i++;
//            j--;
//            while ((j >= left) && array[j] > p) j--;
//            swap(array, i, j);
//        }
//        swap(array, i, j);
//        swap(array, j, left);
//        return j;
//    }
//
//    static void quickSort(int[] array, int left, int right){
//        int pivot;
//        if (left < right) {
//            pivot = partition(array, left, right);
//            quickSort(array, left, pivot - 1);
//            quickSort(array, pivot + 1, right);
//        }
//    }

    public static void quickSort(int[] arr, int left, int right) {
        if (left < right) {
            int pivotIndex = partition(arr, left, right); // Lấy pivotIndex sau khi phân mảng
            quickSort(arr, left, pivotIndex - 1);  // Sắp xếp phần bên trái của pivot
            quickSort(arr, pivotIndex + 1, right); // Sắp xếp phần bên phải của pivot
        }
    }

    private static int partition(int[] arr, int left, int right) {
        int pivot = arr[right]; // Chọn phần tử cuối cùng của mảng làm pivot
        int i = left - 1; // i là chỉ số của phần tử nhỏ hơn pivot
        for (int j = left; j < right; j++) {
            if (arr[j] < pivot) {
                i++;
                swap(arr, i, j); // Hoán đổi phần tử nhỏ hơn pivot sang bên trái của pivot
            }
        }
        swap(arr, ++i, right); // Hoán đổi pivot với phần tử đầu tiên lớn hơn pivot
        return i;
    }

    private static void swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void display(int[] array){
        for(int i = 0; i < array.length; i++){
            System.out.print(array[i] + " ");
        }
    }

    public static void main(String[] args) {
        int[] arr3 = {30,19,24,28,41,34,15,43,20,12,36};
        quickSort(arr3, 0, arr3.length - 1);
        display(arr3);
    }
}
