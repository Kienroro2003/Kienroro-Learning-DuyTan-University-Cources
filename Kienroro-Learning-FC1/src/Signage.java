import java.util.Scanner;

public class Signage {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int w = Integer.parseInt(sc.nextLine());
        while(w < 7){
            w = Integer.parseInt(sc.nextLine());
        }
        sc.close();

        String[] words = {"WELCOME", "TO", "HMD", "GOOD", "LUCK", "TODAY"};

        int curLen = 0;
        int startWord = 0;
        for (int i = 0; i < words.length; i++) {
            int newLen = curLen + words[i].length() + (i - startWord);
            if (newLen > w) {
                // Print the current line
                int numSpaces = w - curLen;
                int numGaps = i - startWord - 1;
                int smallGap = numSpaces / numGaps;
                int largeGaps = numSpaces % numGaps;

                for (int j = startWord; j < i; j++) {
                    System.out.print(words[j]);
                    if (j < i - 1) {
                        for (int k = 0; k < smallGap; k++) {
                            System.out.print(".");
                        }
                        if (j - startWord < largeGaps) {
                            System.out.print(".");
                        }
                    }
                }
                System.out.println();

                // Reset current line
                curLen = 0;
                startWord = i;
            }

            curLen += words[i].length();
        }

        // Print the final line
        int numSpaces = w - curLen - (words.length - startWord - 1);
        for (int i = startWord; i < words.length; i++) {
            System.out.print(words[i]);
            if (i < words.length - 1) {
                System.out.print(".");
                numSpaces--;
            }
        }
        for (int i = 0; i < numSpaces; i++) {
            System.out.print(".");
        }
        System.out.println();
    }
}
