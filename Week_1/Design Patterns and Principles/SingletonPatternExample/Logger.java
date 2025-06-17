public class Logger{
    private static Logger instance;

    private Logger(){
        system.out.prinln("Initialised Logger");
    }

    public static Logger getInstance(){
        return instance;
    }

    public void log(String mesg){
        system.out.prinln("Log: "+ mesg);
    }
}