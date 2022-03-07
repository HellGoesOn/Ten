using System;

namespace Ten.Models
{
    public class Schedule : IModel
    {
        public Schedule(int? id, int? teacherSubjectId, DateTime? dateTime)
        {
            Id = id;
            TeacherSubjectId = teacherSubjectId;
            DateTime = dateTime;
        }

        public int? Id { get; set; }

        public int? TeacherSubjectId { get; set; }

        public DateTime? DateTime { get; set; }

        public override string ToString()
        {
            return $"[ {this.GetType().Name} : (Id={Id}, TeacherSubjectId={TeacherSubjectId}, DateTime={DateTime}) ]";
        }
    }
}
