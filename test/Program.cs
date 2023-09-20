using test;

using (StudentContext db = new StudentContext())
{
    Direction direction1 = new Direction { DirectionName = "ФИИТ" };
    Direction direction2 = new Direction { DirectionName = "ПМИ" };
    Group group1 = new Group { GroupName = "61", Direction = direction1 };
    Group group2 = new Group { GroupName = "62", Direction = direction2 };
    Student student1 = new Student { Name = "Tom", Age =  12, Group = group1 };
    Student student2 = new Student { Name = "Andrew", Age = 16, Group = group2 };

    db.Groups.AddRange(group1, group2);
    db.Students.AddRange(student1, student2);
    db.SaveChanges();   
}