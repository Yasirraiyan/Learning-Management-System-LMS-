class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("Asif",3,"Data Structures",0174325678,"abidurrahman@gmail.com","Mymensingh","IUT",4303);
        Student s2 = new Student("Anik",4,"Algorithm",0157896543,"anik@gmail.com","Dhaka","BUET",4404);
        Console.WriteLine(s1.getname());
        Console.WriteLine(s1.getsemester(4303));
        s1.getsemestertype(4303, 3);
        Console.WriteLine(s1.getcoursetitle());
        Console.WriteLine(s1.getcontactno());
        Console.WriteLine(s1.getemail());
        Console.WriteLine(s1.getaddress());
        Console.WriteLine(s1.getschool());
        Console.WriteLine(s1.getcoursecode());
        Console.WriteLine(s2.getname());
        Console.WriteLine(s2.getsemester(4404));
        s2.getsemestertype(4404, 4);
        Console.WriteLine(s2.getcoursetitle());
        Console.WriteLine(s2.getcontactno());
        Console.WriteLine(s2.getemail());
        Console.WriteLine(s2.getaddress());
        Console.WriteLine(s2.getschool());
        Console.WriteLine(s2.getcoursecode());

        Course c1 = new Course(4537,"Server Programming");
        Course c2 = new Course(4506,"Design Project-I");
        Console.WriteLine(c1.getcoursecode());
        Console.WriteLine(c1.getcoursetitle());
        Console.WriteLine(c1.getsemester(4537));
        c1.getcoursetype(4537);
        c1.getteachertype(4537);
        c1.getsemestertype(4537);
        Console.WriteLine(c2.getcoursecode());
        Console.WriteLine(c2.getcoursetitle());
        Console.WriteLine(c2.getsemester(4506));
        c2.getcoursetype(4506);
        c2.getteachertype(4506);
        c2.getsemestertype(4506);
        Teacher t1 = new Teacher("Abul",01550987654,"abul@iut-dhaka.edu","Gazipur","OIC",4205);
        Teacher t2 = new Teacher("Babul",0193562108,"babul@buet.edu","Dhaka","BD",4308);
        Console.WriteLine(t1.getname());
        Console.WriteLine(t1.getcontactno());
        Console.WriteLine(t1.getemail());
        Console.WriteLine(t1.getaddress());
        Console.WriteLine(t1.getorganization());
        t1.getcoursetype(4205);
        Console.WriteLine(t1.getcoursecode());
        t1.getteachertype(4205);
        Console.WriteLine(t2.getname());
        Console.WriteLine(t2.getcontactno());
        Console.WriteLine(t2.getemail());
        Console.WriteLine(t2.getaddress());
        Console.WriteLine(t2.getorganization());
        t2.getcoursetype(4308);
        Console.WriteLine(t2.getcoursecode());
        t2.getteachertype(4308);



    }
}
