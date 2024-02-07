package exception;

public class NotFoundStudentException extends Exception{
    public NotFoundStudentException() {
        super("Sinh viên không tồn tại");
    }

    public NotFoundStudentException(String message) {
        super(message);
    }
}
