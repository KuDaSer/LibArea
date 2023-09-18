using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public class Triangle: Object
    {
        public bool IsRectangular {  get; set; }
        float a, b, c;
        public Triangle() // конструктор Triangle
        {
            id = 2;
            name = "Triangle";
        }

        public float Area() // площадь фигуры
        {
            IsRectangular = Math.Pow(c,2) == Math.Pow(a,2) + Math.Pow(b,2); // проверка треугольника на прямоугольность

            area = 0;            
            if ((a > 0) && (b > 0))
            {
                area = (a * b) * 0.5f;
            }
            return area;
        }
        public string Ask() // вопрос пользователю
        {
            return "Введите три значения стороны треугольника через / ";
        }

        public bool Check(string Params, ref string result) // разбиваем строчку на параметры и проверяем их
        {
            string[] strings = Params.Split('/');
            if ((strings.Length < 2) || (strings.Length > 4)) 
            {
                result = "Неверное кол-во параметров";
                return false;
            }
            else
            {
                try
                {
                    a = Int32.Parse(strings[0].Trim());
                    b = Int32.Parse(strings[1].Trim());
                    c = Int32.Parse(strings[2].Trim());

                }
                catch
                {
                    result = "Неверное значение стороны";
                    return false;
                }

            }

            return true;

        }
        public string Info() // вызываем функцию Area и форматируем вывод
        {
            Area();
            return string.Format("Треугольник прямоугольный: {0}; Площадь: {1}", IsRectangular, area);

        }

    }
}