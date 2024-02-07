package sort;

public class QuickSort {
    void swap(int[] array, int i, int j){
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    int partition(int[] array, int left, int right){
        int i = left;
        int p = array[i];
        int j = right + 1;
        while (i < j){
            i++;
            while (i < right && array[i] <= p) i++;
            j--;
            while (j > left && array[j] > p) j--;
            swap(array, i, j);
        }
        swap(array, i, j);
        swap(array, j, left);
        return j;
    }

    void quickSort(int[] array, int left, int right){
        if (left < right){
            int p = partition(array, left, right);
            quickSort(array, left, p);
            quickSort(array, p + 1, right);
        }
    }
}
