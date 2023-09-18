using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public class Calculator
    {

        private int currentId;
        public List<Object> ListArea { get; set; }
        public Calculator() // лист объектов
        {
            ListArea = new List<Object>();
            ListArea.Add(new Circle());
            ListArea.Add(new Triangle());            
        }
        public Object GetObj(int id) // функция для нахождения объекта из списка ListArea
        {
            foreach (Object obj in ListArea)
            {
                if (obj.id == id)
                {
                    currentId = obj.id;
                    return obj;
                }
            }
            return null;
        }
        public string ListOfObjects()
        {
            string s = "";
            foreach (Object obj in ListArea)
            {
                s = s + obj.ToString() + Environment.NewLine;
            }
            return s;
        }
        public string AskParam(int id) // функция, ссылающая на вопрос от класса 
        {
            Object obj = GetObj(id);
            if (obj == null)
            {
                return "Неверно указан номер фигуры";
            }            

            string s = " ";
                    switch (id)
                    {
                        case 1:
                            s = ((Circle)obj).Ask();
                            break;
                        case 2:
                            s = ((Triangle)obj).Ask();
                            break;

                    }
            return s;
        }
        public bool CheckParams(string Params, ref string result) // проверка параметров для каждого класса
        {
            Object obj = GetObj(currentId);
            if (obj == null)
            {
                return false;
            }

            bool res = false;
            result = "";
                    switch (currentId)
                    {
                        case 1:
                            res = ((Circle)obj).Check(Params, ref result);
                            break;
                        case 2:
                            res = ((Triangle)obj).Check(Params, ref result);
                            break;

                    }
            return res;

        }
        public string Calculat(string Params) // вычисление площади
        {
            Object obj = GetObj(currentId);
            if (obj == null)
            {
                return "";
            }
            string info = "";
                    switch (currentId)
                    {
                        case 1:
                            info = ((Circle)obj).Info();                            
                            break;
                        case 2:
                            info = ((Triangle)obj).Info();
                            break;
                    }
            return info;

        }

    }
}
