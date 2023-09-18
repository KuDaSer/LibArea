using System.Text;

namespace AreaFigures
{
    public class Circle : Object
    {
        float radius = 0;
        public Circle() // конструктор Circle
        {
            id = 1;
            name = "Circle";
        }
        public float Area() // площадь фигуры
        {
            if (radius > 0 )
            {
                const float p = 3.14f;
                area = p * (radius * radius);
            }
            return area;
        }

        public string Ask() // вопрос пользователю
        {
            return "Введите радиус";
        }
        public bool Check(string Params, ref string result) // разбиваем строчку на параметры и проверяем их
        {
            string[] strings = Params.Split('/');
            if (strings.Length != 1 ) 
            {
                result = "Неверное кол-во параметров";
                return false;
            }
            else
            {
                try
                {
                    radius = Int32.Parse(strings[0].Trim());

                }
                catch
                {
                    result = "Неверное значение радиуса";
                    return false;
                }
                
            }

            return true;

        }
        public string Info() // вызываем функцию Area и форматируем вывод
        {
            Area();
            return string.Format("Площадь: {0}", area);

        }

    }
}