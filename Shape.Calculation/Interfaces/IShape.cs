/*
 * Базовый интерфейс по созданию фигур. Основным свойством является Area, которое хранит площадь данной фигуры, 
 * площадь рассчитывается единожды и при обращении к данной фигуре возвращается одно и то же значение
 * 
 * Возможным улучшением библиотеки может быть вынесение подсчета площади в отдельный сервис класс. 
 * Таким образом можно будет реализовать различные методы подсчета фигур. Напирмер дополнительный подсчет для квадрата a^2.
 * Данный метод можно реализовать через передачу IShape или же IShapeCreator объектов. Для данного тех задания такое усложнение
 * не имеет практического смысла. 
 */
namespace Shape.Calculation.Interfaces
{
    /// <summary>
    /// Defines a general shape with methods to calculate its area.
    /// </summary>
    public interface IShape
    {    /// <summary>
         /// Gets the area of the shape. This property calls <see cref="CalculateArea"/> internally.
         /// </summary>
        double Area {  get; }
    }
}
