**Условие задачи:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

**Решение:**

1. Необходимо внести исходные данные из которых будет производиться выборка (строки массива).

2. Необходимо внести ограниечение по количеству символов в искомых словах (меньше либо равна 3).

3. Задается метод поиска слов требуемой длины:
   - определяется длина нового массива и устанавливается счетчик count;
   - пока i меньше длины массива, производится сравнение длины элементов (слов) массива с заданной в пункте 2 вкличиной;
   - если условие соблюдается, элемент переносится в новый массив;
   - к count прибавляется 1, пока не выйдем из цикла.

4. Сформированный новый массив выводится на печать.
