package sort;

import java.util.Arrays;

public class HeapSort {
    void maxHeap(int[] array, int n, int i) {
        int largest = 0;
        int left = i * 2 + 1;
        int right = i * 2 + 2;
        if (left <= n && array[left] > array[i]) {
            largest = left;
        } else {
            largest = i;
        }
        if (right <= n && array[right] > array[largest]) {
            largest = right;
        }
        if (largest != i) {
            int swap = array[i];
            array[i] = array[largest];
            array[largest] = swap;
            maxHeap(array, n, largest);
        }
    }

    void minHeap(int[] array, int n, int i) {
        int smallest = i;
        int left = i * 2 + 1;
        int right = i * 2 + 2;
        if (left <= n && array[left] < array[i]) {
            smallest = left;
        }
        if (right <= n && array[right] < array[smallest]) {
            smallest = right;
        }
        if (smallest != i) {
            int swap = array[i];
            array[i] = array[smallest];
            array[smallest] = swap;
            minHeap(array, n, smallest);
        }
    }

    void buildMaxHeap(int[] array) {
        for (int i = (array.length - 1) / 2; i >= 0; i--) {
            maxHeap(array, array.length - 1, i);
        }
    }

    void buildMinHeap(int[] array) {
        for (int i = (array.length - 1) / 2; i >= 0; i--) {
            minHeap(array, array.length - 1, i);
        }
    }

    void sortMaxHeap(int[] array) {
        buildMaxHeap(array);
        for (int i = array.length - 1; i >= 1; i--) {
            int swap = array[0];
            array[0] = array[i];
            array[i] = swap;
            maxHeap(array, i - 1, 0);
        }
    }

    void sortMinHeap(int[] array) {
        buildMinHeap(array);
        for (int i = array.length - 1; i >= 0; i--) {
            int swap = array[0];
            array[0] = array[i];
            array[i] = swap;
            minHeap(array, i - 1, 0);
        }
    }

    int extractMax(int[] array) {
        if (array.length < 1) {
            System.out.println("heap underflow");
        }
        int max = array[0];
        array[0] = array[array.length - 1];
        maxHeap(array, array.length - 2, 0);
        return max;
    }

    int parent(int i){
        if(i == 0)return 0;
        else{
            if(i % 2 == 0){
                return i / 2 - 1;
            }else{
                return  i / 2;
            }
        }
    }

    void heapIncreaseKey(int[] array, int i, int key){
//        if (key < array[i]) {
//            System.out.println("New key is smaller than current key.");
//            return;
//        }
        array[i] = key;
        int p = parent(i);
        while (i > 0 && array[p] < array[i]){
            int temp = array[i];
            array[i] = array[p];
            array[p] = temp;
            i = p;
        }
    }

    int[] maxHeapInsert(int[] array, int key){
        int[] temp = new int[array.length + 1];
        System.arraycopy(array, 0, temp, 0, array.length);
        heapIncreaseKey(array, array.length - 1, key);
        return temp;
    }

    int heapMaximum(int[] array){
        return array[0];
    }

    void heapExtractMax(int[] array){
        int max = array[0];
        array[0] = array[array.length - 1];
//        array= Arrays.copyOfRange(array, 0, array.length - 1);
        maxHeap(array, array.length - 2, 0);
    }


}
