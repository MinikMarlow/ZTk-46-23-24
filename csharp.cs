public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MathGrade { get; set; }
    public int PhysicsGrade { get; set; }
    public int ChemistryGrade { get; set; }
}

public class StudentService
{
    private List<Student> _students = new List<Student>
    {
        new Student { Id = 1, Name = "Иван Иванов", MathGrade = 5, PhysicsGrade = 4, ChemistryGrade = 5 },
        new Student { Id = 2, Name = "Петр Петров", MathGrade = 4, PhysicsGrade = 4, ChemistryGrade = 3 },
        new Student { Id = 3, Name = "Сидор Сидоров", MathGrade = 3, PhysicsGrade = 3, ChemistryGrade = 4 }
    };

    public List<Student> GetStudents() => _students;

    public void UpdateStudent(Student student)
    {
        var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
        if (existingStudent != null)
        {
            existingStudent.Name = student.Name;
            existingStudent.MathGrade = student.MathGrade;
            existingStudent.PhysicsGrade = student.PhysicsGrade;
            existingStudent.ChemistryGrade = student.ChemistryGrade;
        }
    }

    public void DeleteStudent(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            _students.Remove(student);
        }
    }
}