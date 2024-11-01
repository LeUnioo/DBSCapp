namespace ConsoleApp1.AppModel;

public class Student
{
    private int StudentId;
    private string Name;
    private string Sex;
    private int Age;
    private DateTime Birthday;
    private float GPA;

    public Student(int studentId, string name, string sex, int age ,DateTime birthday)
    {
        this.StudentId = studentId;
        this.Name = name;
        this.Sex = sex;
        this.Age = age;
        this.Birthday = birthday;

    }

    public void SetGpa(float gpa)
    {
        this.GPA = gpa;
    }

    public float GetGpa()
    {
        return this.GPA;
    }
    
    

}