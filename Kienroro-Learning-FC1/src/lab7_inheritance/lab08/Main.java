package lab7_inheritance.lab08;

import java.util.Scanner;

public class Main {
	static int UCLN(int x, int y){
		int temp;
		while(y != 0){
			temp = x % y;
			x = y;
			y = temp;
		}

		return x;
	}
	public static void main(String[] args) {
//		Complex complex = new Complex(2,1);
//		Complex complex2 = new Complex(0,0);
//		System.out.println("Add: " + complex.add(complex2));
//		System.out.println("Subtract: " + complex.subtract(complex2));
//		System.out.println("Multify: " + complex.multify(complex2));
//		System.out.println("Divide: " + complex.divide(complex2));
		Scanner scanner = new Scanner(System.in);
		int a = scanner.nextInt();
		while (a < 0){
			a = scanner.nextInt();
		}
		int b = scanner.nextInt();
		while (b <= 0){
			b = scanner.nextInt();
		}

		if(b == 1){
			System.out.println(a);
		}else if(a % b == 0){
			System.out.println(a / b);
		}else{
			int ucln = UCLN(a,b);
			int whole = a / b;
			a /= ucln;
			b /= ucln;
			System.out.println(whole + " " + a + "/" + b);
		}

	}
}
