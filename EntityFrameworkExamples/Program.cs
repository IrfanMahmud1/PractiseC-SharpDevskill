//Console.WriteLine();

using EntityFrameworkExamples;

using TrainingDbContext trainingDbContext = new TrainingDbContext();
/*********************
 * Single table example
 * *******************
Course course = new Course();
course.Title = "Professional PHP";
course.StartDate = DateTime.Now;
course.IsActive = true;
course.Fees = 5000;

//trainingDbContext.Courses.Add(course);
//trainingDbContext.Update(course);
var course2 = trainingDbContext.Courses.ToList().FirstOrDefault();
//course2.Fees = 5000;
//trainingDbContext.Update(course);
trainingDbContext?.Remove(course2);
trainingDbContext?.SaveChanges();
***********/

/**************************
 * One to one relationship example
Course course = new Course();
course.Title = "Asp.Net";
course.StartDate = new DateTime(2024,12,7);
course.IsActive = false;
course.Fees = 30000;

Topic topic = new Topic();
topic.Name = "Gettign Started";
topic.Duration = new DateTime(2025, 6, 1);

Topic topic1 = new Topic();
topic1.Name = "Getting Started";
topic1.Duration = DateTime.Now;

course.Topics = new List<Topic>();
course.Topics.Add(topic);
course.Topics.Add(topic1);

trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();

********************/

Course course = new Course();
course.Title = "Machile Learning";
course.StartDate = new DateTime(2024, 12, 7);
course.IsActive = false;
course.Fees = 28000;

Topic topic = new Topic();
topic.Name = "Gettign Started";
topic.Duration = new DateTime(2025, 6, 1);

course.Topics = new List<Topic>();
course.Topics.Add(topic);


Student student = new Student();
student.Name = "Ashik";

Student student1 = new Student();
student1.Name = "Babu";

CourseEnrollment courseEnrollment1 = new CourseEnrollment();
courseEnrollment1.Student = student;

CourseEnrollment courseEnrollment2 = new CourseEnrollment();
courseEnrollment2.Student = student1;

course.CourseStudents = new List<CourseEnrollment>();
course.CourseStudents.Add(courseEnrollment1);
course.CourseStudents.Add(courseEnrollment2);

trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();