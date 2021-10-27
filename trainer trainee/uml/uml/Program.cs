using System;
using System.Collections.Generic;

namespace uml
{
    class Program
    {
        static void Main(string[] args)
        {
            //organization object
            Organization obj = new Organization("Pratian");
            //trainer object
            Trainer trainer = new Trainer(obj);
            Console.WriteLine("Trainer belongs to organization: "+trainer.getorganization());
            Trainee trainee = new Trainee("Vijay");
            trainer.trainees.Add(trainee);
            trainee = new Trainee("Ajay");
            trainer.trainees.Add(trainee);
            trainee = new Trainee("Sam");
            trainer.trainees.Add(trainee);
            
            //module object
            Module module = new Module();
            //course object
            Course course = new Course();
            module.moduleName= "introduction";
            course.modules.Add(module);
            module.moduleName = "Cntent";
            course.modules.Add(module);
            module.moduleName = "labs";
            course.modules.Add(module);
            module.moduleName = "Assessment";
            course.modules.Add(module);
            //unit object
            Unit unit = new Unit();
            unit.durationHrs = 10;
            module.units.Add(unit);
            //training object
            Training training = new Training(obj,course,module);
            training.trainee = trainer.trainees;
            Console.WriteLine("Number of Trainees: " + training.getNumberOfTrainees());
            Console.WriteLine("Trainee belongs to organization: " + training.getTrainingOrganizationName());
            Console.WriteLine("Total number of training hours: "+training.getTrainingDurationInHrs());
        }
    }
    public class Organization
    {
        public string organizationName;
        public Organization(string orgName)
        {
            organizationName = orgName;
        }
       public string getname()
        {
            return organizationName;
        }
    }
    public class Trainer
    {
        public string organizationName;
        public Trainer(Organization org)
        {
            organizationName = org.organizationName;
        }
        public List<Training> training = new List<Training>();
        public List<Trainee> trainees = new List<Trainee>();
        public string getorganization()
        {
            return organizationName;
        }
    }
    public class Trainee
    {
        public string name;
        public List<Training> training = new List<Training>();
        public Trainee(string trName)
        {
            name = trName;
        }
    }
    public class Training
    {
        public string name;
        public string organizationName;
        public int noOfHours=0;
        public List<Trainee> trainee = new List<Trainee>();
        Course course = new Course();
        Module module = new Module();
        public Training(Organization obj, Course courseobj, Module moduleobj)
        {
            organizationName = obj.organizationName;
            course = courseobj;
            module = moduleobj;
        }
        public int getNumberOfTrainees()
        {
            return trainee.Count;
        }
        public string getTrainingOrganizationName()
        {
            return organizationName;
        }
        public int getTrainingDurationInHrs()
        {
           foreach(Module module in course.modules)
            {
                foreach(Unit unit in module.units)
                {
                    noOfHours += unit.durationHrs;
                }
            }
            return noOfHours;
        }
    }
    public class Course
    {
        public List<Training> training = new List<Training>();
        public List<Module> modules = new List<Module>();
        public List<Module> GetModules()
        {
            return modules;
        }
    }
    public class Module
    {
        public string moduleName;
        public List<Unit> units = new List<Unit>();
    }
    public class Unit
    {
        public int durationHrs;
        public List<Topic> topics = new List<Topic>();
        
    }
    public class Topic
    {
        public string topicName;
    }
}
