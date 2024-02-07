import java.util.Scanner;

public class SevenSegmentDisplay {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a single digit (0-9): ");
        int digit = scanner.nextInt();
        String[] segments = getSegments(digit);
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < segments.length; j++) {
                System.out.print(segments[j].charAt(i) + " ");
            }
            System.out.println();
        }
    }

    public static String[] getSegments(int digit) {
        String[] segments = new String[7];
        switch (digit) {
            case 0:
                segments[0] = " * * * ";
                segments[1] = "*     *";
                segments[2] = "*     *";
                segments[3] = "*     *";
                segments[4] = "       ";
                segments[5] = "*     *";
                segments[6] = "*     *";
                break;
            case 1:
                segments[0] = "       ";
                segments[1] = "      *";
                segments[2] = "      *";
                segments[3] = "      *";
                segments[4] = "       ";
                segments[5] = "      *";
                segments[6] = "      *";
                break;
            case 2:
                segments[0] = " * * * ";
                segments[1] = "      *";
                segments[2] = "      *";
                segments[3] = "      *";
                segments[4] = " * * * ";
                segments[5] = "*      ";
                segments[6] = "*      ";
                break;
            case 3:
                segments[0] = " * * * ";
                segments[1] = "      *";
                segments[2] = "      *";
                segments[3] = "      *";
                segments[4] = " * * * ";
                segments[5] = "      *";
                segments[6] = "      *";
                break;
            case 4:
                segments[0] = "       ";
                segments[1] = "*     *";
                segments[2] = "*     *";
                segments[3] = "*     *";
                segments[4] = " * * * ";
                segments[5] = "      *";
                segments[6] = "      *";
                break;
            case 5:
                segments[0] = " * * * ";
                segments[1] = "*      ";
                segments[2] = "*      ";
                segments[3] = "*      ";
                segments[4] = " * * * ";
                segments[5] = "      *";
                segments[6] = "      *";
                break;
            case 6:
                segments[0] = " * * * ";
                segments[1] = "*      ";
                segments[2] = "*      ";
                segments[3] = "*      ";
                segments[4] = " * * * ";
                segments[5] = "*     *";
                segments[6] = "*     *";
                break;
            case 7:
                segments[0] = " * * * ";
                segments[1] = "      *";
                segments[2] = "      *";
                segments[3] = "      *";
                segments[4] = "";
                break;
        }
        return segments;
    }
}
