using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypesTests
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }


        [TestMethod]
        public void UppercaseString()
        {
            string name = "guga";
            name = name.ToUpper();
            Assert.AreEqual("GUGA", name);
        }

        [TestMethod]
        public void AddDaysToDate()
        {
            DateTime date = new DateTime(2018, 5, 16);
            date = date.AddDays(1);

            Assert.AreEqual(17, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }


        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2);
            Assert.AreEqual("A GradeBook", book2.Name);
        }


        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }



        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Guga";
            string name2 = "guga";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            
            g1.Name = "Guga's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
