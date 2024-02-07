package exercise_Nam;

import java.util.Scanner;

public class CircleList {
    private int n;
    private Circle[] a;

    public void input(){
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter n: ");
        this.n = scanner.nextInt();
        scanner.nextLine();
        a = new Circle[n];
        for (int i = 0; i < n; i++) {
            System.out.println("Circle " + (i + 1));
            a[i] = new Circle();
            System.out.println("Enter radius: ");
            a[i].setRadius(Double.parseDouble(scanner.nextLine()));
            System.out.println("Enter color: ");
            a[i].setColor(scanner.nextLine());
            System.out.println("Enter filled: ");
            a[i].setFilled(Boolean.parseBoolean(scanner.nextLine()));
        }
    }

    public void output(){
        for (int i = 0; i < n; i++) {
            System.out.println("Circle " + (i + 1));
            a[i].output();
        }
    }

    public void maxArea(){
        Circle max = a[0];
        for (int i = 1; i < n; i++) {
            if(max.getArea() < a[i].getArea()){
                max = a[i];
            }
        }
        System.out.println("Max area: " + max.getArea());

    }


}
