package sort;

public class MergeSort {
    void mergeSort(int[] array, int left, int right){
        if(left < right){
            int mid = (left + right) / 2;
            mergeSort(array,left, mid);
            mergeSort(array, mid+1, right);
            merge(array,left, mid, right);
        }
    }
    void merge(int[] array, int left, int mid, int right){
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] arrLeft = new int[n1 + 1];
        int[] arrRight = new int[n2 + 1];
        int temp = left;
        for (int i = 0; i < n1; i++){
            arrLeft[i] = array[temp++];
        }
        arrLeft[arrLeft.length - 1] = Integer.MAX_VALUE;
        for (int i = 0 ; i < n2; i++){
            arrRight[i] = array[temp++];
        }
        arrRight[arrRight.length - 1] = Integer.MAX_VALUE;
        int i = 0;
        int j = 0;
        for (int k = left; k <= right; k++){
            if (arrLeft[i] <= arrRight[j]){
                array[k] = arrLeft[i];
                i++;
            }else {
                array[k] = arrRight[j];
                j++;
            }
        }
    }
    //    static void merge(int[] arr, int left, int mid, int right) {
//        int n1 = mid - left + 1;
//        int n2 = right - mid;
//
//        int[] L = new int[n1];
//        int[] R = new int[n2];
//
//        for (int i = 0; i < n1; i++)
//            L[i] = arr[left + i];
//        for (int j = 0; j < n2; j++)
//            R[j] = arr[mid + 1 + j];
//
//        int i = 0, j = 0, k = left;
//
//        while (i < n1 && j < n2) {
//            if (L[i] <= R[j]) {
//                arr[k] = L[i];
//                i++;
//            } else {
//                arr[k] = R[j];
//                j++;
//            }
//            k++;
//        }
//
//        while (i < n1) {
//            arr[k] = L[i];
//            i++;
//            k++;
//        }
//
//        while (j < n2) {
//            arr[k] = R[j];
//            j++;
//            k++;
//        }
//    }
}
