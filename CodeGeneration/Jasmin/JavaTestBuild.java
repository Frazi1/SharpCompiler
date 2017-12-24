class JavaTestBuild {
    public static void main(String[] args){
       
    }

    public void compare(int a, int b)
    {
        if (a < b)
        {
            Library.printString("a < b");
        }
        else if (a > b)
        {
            Library.printString("a > b");
        }
        else
        {
            Library.printString("a==b");
        }

    }

    
}