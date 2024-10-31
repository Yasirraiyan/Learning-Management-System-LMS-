public class Course
{
    public int coursecode;
    public string coursetype;
    public string coursetitle;
    
    public string teachertype;
    public Course(int coursecode, string coursetitle)
    {
        this.coursecode = coursecode;
        this.coursetitle = coursetitle;
    }
         
    public int getcoursecode()
    {
        return coursecode;
    }
    public string getcoursetitle()
    {
        return coursetitle;
    }
    public int getsemester(int coursecode)
    {
        Console.WriteLine($"The course is in the semester:{(coursecode / 100) % 10}");
        return (coursecode / 100) % 10;
    }
    public void getcoursetype(int coursecode)
    {
        if (coursecode % 2 == 0)
        {
            Console.WriteLine($"The course is a lab course.The course code is:{coursecode}");
        }
        else
        {
            Console.WriteLine($"The course is a theory course.The course code is:{coursecode}");

        }
    }
    public void getteachertype(int coursecode)
    {
        if(coursecode % 2 == 0)
        {
            Console.WriteLine($"The teacher is a lecturer.He take the lab course");
        }
        else
        {
            Console.WriteLine($"The teacher is a professor.He take the lab course");
        }
    }
    public void getsemestertype(int coursecode)
    {
        if((coursecode / 100)%10%2== 0)
        {
            Console.WriteLine("The course is a summer semester course.");
        }
        else
        {
            Console.WriteLine("The course is winter summer semester course.");
        }

    }
}
