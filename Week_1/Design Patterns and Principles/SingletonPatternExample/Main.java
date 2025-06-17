public class Main {
    public static void main(String[] args) {
        Logger L1 = Logger.getInstance();
        L1.log("First log message");

        Logger L2 = Logger.getInstance();
        L2.log("Second log message");

        if (L1 == L2) {
            System.out.println("Single instance -> Singleton");
        } else {
            System.out.println("Multiple instances -> Singleton failed.");
        }
    }
}
