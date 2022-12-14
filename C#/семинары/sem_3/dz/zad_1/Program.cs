// 4. метод, формирующий новый массив на основе имеющегося
//! ДЗ ОПИСАТЬ БЛОК-СХЕМУ РЕШЕНИЯ ЗАДАЧИ
int[] Solution(int[] collectionElements, int evenCounts)
{

  //       v
  // 1 2 3 4 5 6 7 8 9 0 collectionElements
  // 2 0 0 0 0 items
  //   ^ 

  int[] items = new int[evenCounts];
  int length = collectionElements.Length;
  int position = 0;
  int indexInItems = 0;
  while (position < length)
  {
    if (collectionElements[position] % 2 == 0)
    {
      items[indexInItems] = collectionElements[position];
      indexInItems++;
    }
    position++;
  }

  return items;
}
