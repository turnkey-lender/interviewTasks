using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace InterviewTasks.SortHugeArray
{
    /// <summary>
    /// The array may only contain int numbers from 0 to 9
    /// </summary>
    public class HugeArray
    {
        private readonly int _size = 100000000;
        private List<int> _array;

        public HugeArray(int? size=null)
        {
            if (size != null)
                _size = size.Value;
            _array = new List<int>(_size);
            FillRandomValues();
        }

        public List<int> Value => _array;

        public void Sort()
        {
            throw new NotImplementedException();
        }

        #region Private methods

        private void FillRandomValues()
        {
            var rnd = new Random();
            for (int i = 0; i < _size; i++)
            {
                _array.Add(rnd.Next(10));
            }
        }

        #endregion
    }
}