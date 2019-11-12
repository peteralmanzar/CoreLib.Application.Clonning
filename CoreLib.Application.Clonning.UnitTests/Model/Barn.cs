using System;
using System.Collections.Generic;

namespace CoreLib.Application.Clonning.UnitTests.Model
{
    [Serializable]
    internal class Barn
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }
        #endregion

        #region Constructors
        public Barn()
        {
            Animals = new List<Animal>();
        }
        #endregion
    }
}
