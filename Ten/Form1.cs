using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ten.Enums;
using Ten.Models;

namespace Ten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void PrintModelInfo(IModel model)
        {
            outputBox.Text = model.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Clear();

            string[] lines = inputBox.Text.Split('\n');

            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace("\n", "");
            }

            ModelType type = ModelType.Group;

            try
            {
                type = Enum.Parse<ModelType>(lines[0]);
            }
            catch
            {
                outputBox.Text = " # Неверный тип модели. Допустимые типы модели включают: ";

                for (int i = 0; i < 5; i++)
                    outputBox.Text += "\n" + ((ModelType)i).ToString();

                return;
            }

            IModel model = ModelFactory.GetEmptyModel(type);

            try
            {
                switch (type)
                {
                    case ModelType.Teacher:
                        Teacher t = model as Teacher;

                        t.Id = Convert.ToInt32(lines[1]);

                        t.Name = lines[2];

                        break;
                    case ModelType.Subject:
                        Subject s = model as Subject;
                        s.Id = Convert.ToInt32(lines[1]);
                        s.Name = lines[2];
                        break;
                    case ModelType.TeacherSubject:
                        TeacherSubject ts = model as TeacherSubject;
                        ts.Id = Convert.ToInt32(lines[1]);
                        ts.TeacherId = Convert.ToInt32(lines[2]);
                        ts.SubjectId = Convert.ToInt32(lines[3]);
                        break;
                    case ModelType.Group:
                        Group g = model as Group;
                        g.Id = Convert.ToInt32(lines[1]);
                        g.Name = lines[2];
                        break;
                    case ModelType.Schedule:
                        Schedule sc = model as Schedule;
                        sc.Id = Convert.ToInt32(lines[1]);
                        sc.TeacherSubjectId = Convert.ToInt32(lines[2]);
                        break;
                }
            }
            catch
            {
                /*
                * Предполагалось выводить ошибку, но это не нужно
                * outputBox.Text = " # Ошибка: Введены неверные или не полные данные для указанного типа модели";
                */
            }

            PrintModelInfo(model);
        }
    }
}
