using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace InterviewTasks.SortHugeArray
{
    /// <summary>
    /// There's a huge array of ints, which has only numbers from 0 to 9, but in a random order
    /// The task is to implement the <see cref="Sort"/> method for this array in the most effective way
    /// Run tests from <see cref="HugeArrayTests"/> 
    /// </summary>
    public class HugeArray
    {
        public void Sort()
        {
            throw new NotImplementedException();
        }

        #region Test-related code, doesn't require correction

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