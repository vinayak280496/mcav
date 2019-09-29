import org.testng.annotations.Test;

// 1. Setup
// 2 . Login
// 3
public class FirstTestCase {
    @Test(priority = 1)
    void  setup(){
        System.out.print("Opening Browser.");
    }

    @Test(priority = 2)
    void login(){
        System.out.print("This is login test");
    }

    @Test(priority = 3)
    void teardown(){
        System.out.print("Closing Browser");
    }
}
