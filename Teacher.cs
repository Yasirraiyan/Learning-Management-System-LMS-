 public class Teacher
 {
     public string name;
     
     public long contactno;
     public string email;
     public string address;
     public string organization;
     public int coursecode;
     public string coursetype;
     public string teachertype;
     public Teacher(string name, long contactno, string email, string address, string organization, int coursecode)
     {
         this.name = name;
         
         this.contactno = contactno;
         this.email = email;
         this.address = address;
         this.organization = organization;
         this.coursecode = coursecode;
         
     }
     public string getname() 
     { 
         return name; 
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
         return address;
     }
     public string getorganization()
     {
         return organization;
     }
     public void getcoursetype(int coursecode)
     {
         if (coursecode % 2 == 0)
         {
             Console.WriteLine($"The course is a lab course.The code of course is:{coursecode}");
         }
         else
         {
             Console.WriteLine($"The course is a theory course.The code of course is:{coursecode}");
         }

     }
     public int getcoursecode()
     {
         return coursecode;
          
     }
     public void getteachertype(int coursecode)
     {
         if(coursecode % 2 == 0)
         {

             Console.WriteLine("The teacher type is lecturer.He take lab course");
         }
         else
         {
             Console.WriteLine("The teacher type is professor.He take theory course");
         }
     }
 }
