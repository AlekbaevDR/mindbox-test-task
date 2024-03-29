/*
 * Интерфейс для создания фигур, необходим для сокрытия прямого создания фигур через new оператор. 
 * Это в свою очередь не дает пользователю возможность создать некорректную с точки зрения геометрии фугуру.
 * Так же у пользователя появляется общий подход по созданию фигур это вызов наследников класса IShapeCreator метода Create. 
 * Конструкторы по созданию Creator-ов могут быть перегружены, таким образом можно будет добиться создания одних и тех же фигур через 
 * различное количество параметров. Например квадрат может быть создан по 1 стороне, по 2 сторонам или по 4 сторонам
 */
using Shape.Calculation.Interfaces;

namespace Shape.Calculation.Creators
{
    /// <summary>
    /// Defines a factory for creating shapes.
    /// </summary>
    public interface IShapeCreator
    {
        /// <summary>
        /// Creates an instance of a shape.
        /// </summary>
        /// <returns>An IShape instance.</returns>
        IShape Create();
    }
}
