using Ten.Enums;

namespace Ten.Models
{
    public static class ModelFactory
    {
        public static IModel GetEmptyModel(ModelType type)
        {
            IModel result = null;

            switch(type)
            {
                case ModelType.Teacher:
                    result = new Teacher(null, null);
                    break;
                case ModelType.Subject:
                    result = new Subject(null, null);
                    break;
                case ModelType.TeacherSubject:
                    result = new TeacherSubject(null, null, null);
                    break;
                case ModelType.Group:
                    result = new Group(null, null);
                    break;
                case ModelType.Schedule:
                    result = new Schedule(null, null, null);
                    break;
            }

            return result;
        }
    }
}
