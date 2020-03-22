using System;
using System.Collections.Generic;

namespace CoreLib.Application.Cloning.UnitTests.Model
{
    [Serializable]
    internal class Animal
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        #endregion

        #region Events
        [field: NonSerialized]
        public event EventHandler MakeNoise;
        #endregion
    }
}