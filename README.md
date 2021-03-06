 # Инкапсуляция 
 
**Инкапсуляция** - защита объекта от неправильного использования.


---


@ - означает что во время выполнения, эта функция не может показывать ошибки. Использование не рекоммендуется в большинстве случаев.

"_" - литерал, часть имени переменной.



---


`[SerializeField]` -  позволяет редактировать поле через инспектор, при этом закрывая его от другого кода. Эта практика доступна блягодаря инкапсуляции.

---

#region MonoBehaviour ??? *что это...*

---

**error CS1038: #endregion directive expected** - Директива #region не имеет соответствующую директиву #endregion . **Надо добавить #endregion!**


---

`SetActive` Активирует/дезактивирует GameObject. GameObject может быть неактивным, потому что родительский GameObject неактивен. 

---

# Полиморфизм
* полиморфизм подтипов - представлен через наследование и виртуализацию методов. Один интерфейс и множество реализаций интерфейса.


* полиморфизм параметрический - 

---

# ScriptableObject

**ScriptableObject** - объект определенного типа, который может хранить пользовательские данные любого типа в виде файла.

---

В работе с проектом мы создали instance ScriptableObject'а (MainMenuShop), чтобы потом использовать его на сцене. Так, в нескольких сценах можно использовать один список товаров. То же самое сделали и с Goods.

---


ScriptableObject мутабельны! Можно взять доступ к нему и изменить в случае прайвит филд или наличия методов, которые меняют его состояние. Если мы его сохраним, то он изменится, так как это приводит к изменеию ресурсов в проджекте. Можна использвать ScriptableObject как некий базис для системы сохранения игры, **НО** это не будет работать в билде.


Так как ScriptableObject - это объект, то он должен мочь в:

* инкапсуляцию 

* наследование 

* в нашем случае тут будет использоваться полиморфизм подтипов

---


# SOLID

**S**: Single Responsibility Principle (Принцип единственной ответственности).


**O**: Open-Closed Principle (Принцип открытости-закрытости).


**L**: Liskov Substitution Principle (Принцип подстановки Барбары Лисков).


**I**: Interface Segregation Principle (Принцип разделения интерфейса).


**D**: Dependency Inversion Principle (Принцип инверсии зависимостей).


## Single Responsibility Principle


В основе лежит декомпозиция кода. 

Класс должен иметь всего 1 причину для изменения. 

---

## Open-Closed Principle

Некий класс должен быть открыт для расширения, но закрыт для модификаций. Всё сводится к тому,  при разработке в команде стоит учитывать возможность модификации класса (любое изменение части программы может привести к неработоспособности другой части).


Расширение модулей без изменения его начального состояния вполне лояльно пройдет. Так, в С# это достигается с помощью полиморфизма. 

Так, в нашем проекте LootNode был расширен - закрыт для модификаций, но открыт для расширений.


Для иллюстрации этого принципа мы внечем изменения в скрипте `Incapsulation.cs`.


---

## Liskov Substitution Principle

**Базовый тип слуит неким контрактом, который производный тип обязывается соблюдать**

Необходимо, чтобы подклассы могли бы служить заменой для своих суперклассов.
Цель этого принципа заключаются в том, чтобы классы-наследники могли бы использоваться вместо родительских классов, от которых они образованы, не нарушая работу программы. Если оказывается, что в коде проверяется тип класса, значит принцип подстановки нарушается. 


Для иллюстрации этого принципа мы внечем изменения в скрипте `Incapsulation.cs`.


---

## Interface Segregation Principle

Этот принцип направлен на устранение недостатков, связанных с реализацией больших интерфейсов. **Чем больше интерфейс тем хуже**.

Если модуль А зависит от модуля Б, то зависимости длжны быть максимально узкими.


Принцип хорошо соблюдается в классе `GoodsList.cs`


* необходимо дробить интерфейсы на подинтерфейсы.

* при декларации типа необходимо писать максимально простой тип.


---

## Dependency Inversion Principle

Объектом зависимости должна быть абстракция, а не что-то конкретное. 

Он лежит в основе Dependency Injection.  **Классы верхнего уровня не должны зависеть от классов нижнего уровня и наоборот. Они должны быть зависимы от абстракции, а асбтракция не должна зависеть от деталей реализации**.


Однако, перманентная зависимость абстракции чревата слишком большим количеством уровней косвенности. 