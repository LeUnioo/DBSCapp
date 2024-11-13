namespace ConsoleApp1.AppModel;

public class department
{
    private int departmentId;
    private string departmentName;
    private int numberOfStudents;


    public department(string departmentName, int numberOfStudents)
    {
        this.departmentName = departmentName;
        this.numberOfStudents = numberOfStudents;
    }
    
}