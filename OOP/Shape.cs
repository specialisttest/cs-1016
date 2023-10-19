using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
/* В программе создать объекты классов
 * Point, Circle Line.
 * Создать массив Shape[] scene и добавить
 * в него ссылки на созданные объекты
 * Сделать метод DrawScene, которые 
 * перебирает этот массив и для каждого 
 * объекта вызывает метод Draw()
 * 
 * 
 */
    
    public abstract class Shape
    {
        public const string DEFAULT_COLOR = "black";
        public string Color { get; set; }
        public Shape(string color = DEFAULT_COLOR)
        {
            Color = color;
        }

        public abstract void Draw();

        /*public virtual void Draw()
        {
            //Console.WriteLine($"Shape. {Color}");
        }*/
    }
}
