using CoreLib.Application.Clonning.UnitTests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoreLib.Application.Clonning.UnitTests
{
    [TestClass]
    public class ClonerUnitTests
    {
        #region Fields
        private Random _random = new Random();
        #endregion

        #region Public Functions
        [TestMethod]
        public void Clone_CopiesAllObjectPropertyValues()
        {
            var barn = getNewBarn();
            var clone = Cloner.Clone(barn);

            Assert.AreEqual(barn.ID, clone.ID);
            Assert.AreEqual(barn.Name, clone.Name);

            barn.Animals.ForEach(a =>
            {
                var clonedAnimal = clone.Animals.Find(ca => ca.ID == a.ID);
                Assert.AreEqual(a.ID, clonedAnimal.ID);
                Assert.AreEqual(a.Name, clonedAnimal.Name);
            });
        }

        [TestMethod]
        public void Clone_NotSameReferenceAsOnject()
        {
            var barn = getNewBarn();
            var clone = Cloner.Clone(barn);

            Assert.AreEqual(barn, barn);
            Assert.AreEqual(clone, clone);
            Assert.AreNotEqual(barn, clone);
        }
        #endregion

        #region Private Functions
        private Barn getNewBarn()
        {
            var result = new Barn();
            result.Animals.Add(new Animal() { ID = 1, Name = "Cow" });
            result.Animals.Add(new Animal() { ID = 2, Name = "Pig" });
            result.Animals.Add(new Animal() { ID = 3, Name = "Chicken" });

            return result;
        }
        #endregion
    }
}
