# EPAM_Task3
Task3. Inheritance. Interfaces and Abstract Classes
Задача 1
1.1. Разработать иерархию классов для решения поставленной задачи, используя возможности
ООП: классы, наследование, полиморфизм, инкапсуляция, возможности интерфейсов и
множественное наследование, использовать возможности Enum и внутренних классов.
1.2. Каждый класс должен иметь исчерпывающие смысл, название и информативный состав.
1.3. Классы сгрупировать по смыслу в соответсвующие библиотеки классов
1.4. При кодировании должны быть использованы соглашения об оформлении кода C# code
convention.
1.5. В классах должны быть методы ToString(), GetHashCode() и Equals().
1.6. Используя классы StreamReader и StreamWriter обеспечить загрузку/сохранение данных из
XML-файла
1.7. Используя классы XmlReader и XmlWriter обеспечить чтение/сохранение данных в XML-файл
1.8. Обеспечить взаимное чтение/сохранение данных классами XmlWriter и StreamReader,
StreamWriter и XmlReader
1.9. Широкий ассортимент типов данных, различный уровень доступа к полям и методам,
использование статических полей и методов, констант приветствуются.
1.10. У девочки есть безразмерные листы пленки и бумаги. Из них она может вырезать различные
геометрические фигуры (круг, прямоугольник, равносторонний треугольник и т.п.) определенного
размера, причем из одних фигур можно вырезать другие. Вырезаемая фигура должна быть меньше
той, из которой ее вырезают.
1.11. Еще у девочки есть набор красок. Бумажные фигуры можно красить, но только 1 раз. Фигуры
из пленки бесцветные и красить их нельзя.
1.12. Все фигуры должны обеспечивать возможность расчета площади и периметра
1.13. Так же, у девочки есть коробка на 20 фигур, куда можно складывать и доставать любые
фигуры.
1.14. У коробки есть ряд функций:
 добавить фигуру, (нельзя добавить одну и ту же фигуру дважды)
 просмотреть по номеру (при этом фигура остается в коробке)
 извлечь по номеру (при этом фигура удаляется из коробки)
 заменить по номеру
 найти фигуру по образцу (эквивалентную по своим характеристикам)
 показать наличное количество фигур
 суммарную площадь
 суммарный периметр
 достать все Круги
 достать все Пленочные фигуры
 сохранить все фигуры / только бумажные / только плёночные из коробки в XML-файл,
используя StreamWriter
 сохранить все фигуры / только бумажные / только плёночные из коробки в XML-файл,
используя XmlWriter
 загрузить все фигуры в коробку из XML-файла, используя StreamReader
 загрузить все фигуры в коробку из XML-файла, используя XmlReader
1.15. Требования к реализации:
 материал и форма не могут быть полями класса
 вырезание фигуры из другой фигуры реализовать как соотв. конструктор
 использовать возможности Enum с цветом
 невозможность вырезания реализовать как соответсвующее исключение
 невозможность окрашивания фигуры реализовать как соответсвующее исключение
 обязательно использовать автодокументирование
 реализовать модульные тесты для разработанных классов
