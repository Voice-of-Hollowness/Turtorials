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

