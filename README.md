## Задача: ##
----
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## Описание алгоритма решения: ##
-----
Объявим два массива одинаковой длины. Далее метод, где цикл соразмерный длине массива, внутри цикла проверка условия (<=3), если условие выполняется, то элемент из первого массива переносится в count элемент второго массива. Переменная count, чтобы по очереди закидывать из первого массива во второй и чтобы потом не было пробелов. После присвоения увеличивается переменная count на 1 и возвращается к циклу в котором i+1. Цикл закончится при прохождении всех элементов.