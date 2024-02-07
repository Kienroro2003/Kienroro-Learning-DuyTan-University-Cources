import java.io.File;
import java.util.Arrays;
import java.util.stream.Stream;

public class StreamExample {
    public static void main(String[] args) {
        File[] hiddenFiles = new File(".").listFiles(File::isHidden);
    }
}
