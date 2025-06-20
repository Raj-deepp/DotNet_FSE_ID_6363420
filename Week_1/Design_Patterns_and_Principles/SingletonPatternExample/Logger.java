public class Logger{
    private static Logger instance;

    private Logger(){
        System.out.println("Initialised Logger");
    }

    public static Logger getInstance(){
        if (instance == null) {
            instance = new Logger();
        }
        return instance;
    }

    public void log(String mesg){
        System.out.println("Log: "+ mesg);
    }
}