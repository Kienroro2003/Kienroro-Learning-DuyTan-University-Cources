import java.util.Scanner;

public class StudentsCouncilBreakfast {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int pink = sc.nextInt();
        int green = sc.nextInt();
        int red = sc.nextInt();
        int orange = sc.nextInt();
        int target = sc.nextInt();
        int count = 0;
        int minPrint = Integer.MAX_VALUE;

        for (int i = 0; i <= target / pink; i++) {
            for (int j = 0; j <= target / green; j++) {
                for (int k = 0; k <= target / red; k++) {
                    for (int l = 0; l <= target / orange; l++) {
                        int total = i * pink + j * green + k * red + l * orange;
                        if (total == target) {
                            System.out.printf("# of PINK is %d # of GREEN is %d # of RED is %d # of ORANGE is %d\n", i, j, k, l);
                            count++;
                            minPrint = Math.min(minPrint, i + j + k + l);
                        }
                    }
                }
            }
        }

        System.out.println("Total combinations is " + count + ".");
        System.out.println("Minimum number of tickets to print is " + minPrint + ".");
    }
}
