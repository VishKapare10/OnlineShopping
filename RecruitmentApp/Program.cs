using System;
using System.Collections.Generic;
//Hollywood principle
//Don't call us, we will call you

namespace RecruitmentApp
{

    public class Resume{
        public string Name{get;set;}
        public string Email{get;set;}
        public string Content{get;set;}

        public override string ToString(){
            return "Resume: [email="+Email+", name="+Name+", Content="+Content+"]";
        }
    }

    //Singleton class ---only 1 instance will be created
    public class JobPortal{
        private static JobPortal portal=new JobPortal();
        private List<Resume> resumeList=new List<Resume>();

        private JobPortal(){

        }

        public static JobPortal get(){
            return portal;
        }

        public void uploadContent(string email, string name, string content){

                Resume resume = new Resume();
                resume.Name=name;
                resume.Email=email;
                resume.Content=content;
                resumeList.Add(resume);
        }

        public void triggerCampusing(){
            foreach (Resume resume in resumeList)
            {
                Console.WriteLine("Sending to mail to "+resume.Name+" at "+resume.Email);                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Testing
            JobPortal.get().uploadContent("ganeshshinde@gmail.com","Ganesh Shinde","Java Developer");
            JobPortal.get().uploadContent("umeshsharma@gmail.com","Umesh Sharma","PHP Developer");
            JobPortal.get().uploadContent("vish10kapare@gmail.com","Vishwambhar Kapare","Full stack developer");
            JobPortal.get().uploadContent("kiranmuluk@gmail.com","Kiran Muluk","Process Executive");
            JobPortal.get().uploadContent("shubhamwadgoankar@gmail.com","Shubham Wadgaonkar","Network Engineer");
            JobPortal.get().triggerCampusing();
        }
    }
}
