package sort;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

public class MainSort {

    static void insertionSort(int[] array){
        for (int i = 1; i < array.length; i++) {
            int last = array[i];
            int j = i;
            for ( ; j > 1 && array[j - 1] > last; j--){
                array[j] = array[j - 1];
            }
            array[j] = last;
        }
    }



    static void swap(int[] array, int index1, int index2){
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    static int partition(int[] array, int left, int right){
        int i, j, p;
        i = left;
        j = right + 1;
        p = array[left];
        while (i < j){
            i = i + 1;
            while ((i <= right) && array[i] < p)i++;
            j--;
            while ((j >= left) && array[j] > p) j--;
            swap(array, i , j);
        }
        swap(array, i, j);
        swap(array, j, left);
        return j;
    }

//    static void quickSort(int[] array, int left, int right){
//        int pivot;
//        if(left < right){
//            pivot = partition(array, left,right);
//            if(left < pivot - 1){
//                quickSort(array,left,pivot - 1);
//            }
//            if(right > pivot + 1) {
//                quickSort(array, pivot + 1, right);
//            }
//        }
//    }

    static void quickSort(int[] array, int left, int right){
        int pivot;
        if(left < right){
            pivot = partition(array, left, right);
            if(left <= pivot - 1){
                quickSort(array, left, pivot - 1);
            }
            if(right >= pivot + 1) {
                quickSort(array, pivot + 1, right);
            }
        }
    }

    static void display(int[] array){
        for(int i = 0; i < array.length; i++){
            System.out.print(array[i] + " ");
        }
    }

    public static void main(String[] args) {
        int[] arr = {1,2,3,8,7,9,10,12,23,18,15,16,17,14};
        int[] arr2 ={8,2,9,4,5,3,16};
        int[] arr3 = {30,19,24,28,41,34,15,43,20,12,36};
        int[] arr4 = {40,30,65,25,35,50,76,10,28,27,33,36,34,48,60,68,80,69};
        int[] arr5 = {46,34,83,75,25,57,93,27,17,39,52,31,93,44};
//        QuickSort quickSort = new QuickSort();
//        quickSort.quickSort(arr, 0, arr.length - 1);
        HeapSort heapSort = new HeapSort();
//        heapSort.sortMaxHeap(arr);
        heapSort.buildMinHeap(arr5);
        heapSort.buildMaxHeap(arr5);
//        heapSort.heapIncreaseKey(arr4, 16, 13);
//        display(arr4);
//        System.out.println();
//        heapSort.heapExtractMax(arr4);
        display(arr5);

    }
}
