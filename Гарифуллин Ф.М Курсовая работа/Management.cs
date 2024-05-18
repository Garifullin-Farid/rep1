
using System;

namespace Гарифуллин_Ф.М_Курсовая_работа
{
    public class Management
    {

        public Realization? _realization;
        public Param? _param;
        public Storage? _storage;
        public State? _state;


        public void rel()
        {
            _realization = new Realization(_param.mas, _param.a);
        }
       
        public void PerformOperation()
        {

            rel();
         
            int[] mas = _realization!.mas;
           
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == _realization.num)
                {
                    for (int j = i; j < mas.Length - 1; j++)
                    {
                        int c = mas[j + 1];
                        mas[j] = c;
                        _storage!.AddState(_realization.SaveState((int[])mas.Clone(), j));
                    }


                }
                _storage!.AddState(_realization.SaveState((int[])mas.Clone(), i));

            }
            
            _realization.Resize (ref mas);
            _storage!.AddState(_realization.SaveState((int[])mas.Clone(), 0));

           
        }
        public Management(Param param)
        {
            _param = param;
            _storage = new Storage();
        }
      

    }
}
