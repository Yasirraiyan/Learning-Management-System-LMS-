 public class Student
 {
     public string name;
     public int semester;
     public string coursetitle;
     public long contactno;
     public string email;
     public string adress;
     public string school;
     public int coursecode;
     public Student(string name, int semester, string coursetitle, long contactno, string email, string adress, string school,int coursecode)
     {
         this.name = name;
         this.semester = semester;
         this.coursetitle = coursetitle;
         this.contactno = contactno;
         this.email = email;
         this.adress = adress;
         this.school = school;
         this.coursecode = coursecode;
     }
     public string getname()
     {
         return name;
     }
     public int getsemester(int coursecode)
     {
        return (coursecode/100) % 10;
         
     }
     public void getsemestertype(int coursecode, int semester)
     {
         int d = (coursecode / 100) % 10;
         if (d % 2 == 0 && semester % 2 == 0)
         {
             Console.WriteLine($"The semester is a summer semester.The current semester is:{semester}");
         }
         if (d % 2 == 1 && semester % 2 == 1)
         {
             Console.WriteLine($"The semester is a winter semester.The current semester is:{semester}");
         }
     }
     public string getcoursetitle()
     {
         return coursetitle;
          
     }
     public long getcontactno()
     {
         return contactno;
     }
     public string getemail()
     {
         return email;
     }
     public string getaddress()
     {
         return adress;
     }
     public string getschool()
     {
         return school;
     }
     public int getcoursecode()
     {
        return coursecode; 
     }
 }
 }
 
