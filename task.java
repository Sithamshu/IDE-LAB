import java.util.Scanner;
public class Main
{
      public static void main(String args[])
      {
          String name;
          int roll,sub1, sub2, sub3, sub4;
           
          Scanner SC=new Scanner(System.in);
           
          System.out.print("Enter Name: ");
          name=SC.nextLine();
          System.out.print("Enter Roll Number: ");
          roll=SC.nextInt();
          System.out.print("Enter marks out of 60\n");
          System.out.print("Enter marks in Subject 1, Subject 2, Subject 3, Subject 4 :");
          sub1=SC.nextInt();
          sub2=SC.nextInt();
          sub3=SC.nextInt();
          sub4=SC.nextInt();
           
          int total=sub1+sub2+sub3+sub4;
          float percentage=(float)total/240*100;
           
          System.out.println("Roll Number:" + roll +"\tName: "+name);
          System.out.println("Marks (sub1, sub2, sub3, sub4:) " +sub1+", "+sub2+", "+sub3+", "+sub4);
          System.out.println("Total: "+total +"\tPercentage: "+percentage);
          System.out.println("Average marks = "+total/4);

      }
          
}