using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Гарифуллин_Ф.М_Курсовая_работа
{
    public class Realization
    {


        /// <summary>
        /// массив
        /// </summary>
        public int[] mas;
        /// <summary>
        /// число которое надо найти
        /// </summary>
        public int num;

        /// <summary>
        /// поиск по значению
        /// </summary>
        /// <param name="mas">массив</param>
        /// <param name="num">число для поиска</param>
        /// <returns></returns>


        public void delByValue(int[] mas, int num)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == num)
                {
                    //step( mas, i);
                    i--;

                }

            }
        }
        /// <summary>
        /// создание объекта класса состояния
        /// </summary>

        public State SaveState(int[] mas, int Index) {
            
            return new State(mas, Index);
        }

        public void RestoreState(State state)
        {
            mas = state.Mas;
        }

        public void step(ref int[] mas, int i)
        {
            
        }
        public void Resize(ref int[] mas){
            int[] newArr = new int[mas.Length-1];
            for (int i = 0;i< mas.Length-1; i++)
            {
                newArr[i] = mas[i];
            }
            mas = newArr;
        }
        public Realization(int[] Mas, int Num)
        {
            mas = Mas;
            num = Num;
        }
    }
}

