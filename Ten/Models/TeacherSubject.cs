using System;
using System.Collections.Generic;
using System.Text;

namespace Ten.Models
{
    public class TeacherSubject : IModel
    {
        public TeacherSubject(int? id, int? teacherId, int? subjectId)
        {
            Id = id;
            TeacherId = teacherId;
            SubjectId = subjectId;
        }

        public int? Id { get; set; }

        public int? TeacherId { get; set; }

        public int? SubjectId { get; set; }

        public override string ToString()
        {
            return $"[ {this.GetType().Name} : (Id={Id}, TeacherId={TeacherId}, SubjectId={SubjectId}) ]";
        }
    }
}
