package exercise_Nam;

public class Circle {
    private static final double PI = 3.14;
    private double radius;
    private String color;
    private boolean filled;

    public Circle() {
        this.radius = 1.0;
        this.color = "red";
        this.filled = false;
    }

    public Circle(double radius, String color, boolean filled) {
        this.radius = radius;
        this.color = color;
        this.filled = filled;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public boolean isFilled() {
        return filled;
    }

    public void setFilled(boolean filled) {
        this.filled = filled;
    }

    public void output(){
        System.out.println("Circle{" +
                "radius=" + radius +
                ", color='" + color + '\'' +
                ", filled=" + filled +
                '}');
    }

    public double getArea() {
        return this.radius * this.radius * PI;
    }
}
