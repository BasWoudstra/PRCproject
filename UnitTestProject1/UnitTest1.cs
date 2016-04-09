using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Cat Testcat;
        Dog Testdog;
        Administration TestAdministration = new Administration();
        
        private void MakeCat()
        {
        //make a cat
        //range
        string catname = "thiscat";
        int catchipNumber = 123;
        SimpleDate catDateOfBirth = new SimpleDate(2, 5, 2015);
        string catbadHabits = "kan de kattebak niet vinden";

        //act
        Testcat = new Cat(catchipNumber, catDateOfBirth, catname, catbadHabits);
        }
        private void MakeAnotherCat()
        {
            //make a cat
            //range
            string catname = "newCat";
            int catchipNumber = 85725;
            SimpleDate catDateOfBirth = new SimpleDate(7, 5, 2000);
            string catbadHabits = "";

            //act
            Testcat = new Cat(catchipNumber, catDateOfBirth, catname, catbadHabits);
        }

        private void MakeDog()
        {
            //make a dog
            //range
            string dogname = "thisdog";
            int dogchipNumber = 123;
            SimpleDate dogDateOfBirth = new SimpleDate(2, 5, 2015);
            SimpleDate dogDateOfWalk = new SimpleDate(2, 6, 2015);

            //act
            Testdog = new Dog(dogchipNumber, dogDateOfBirth, dogname, dogDateOfWalk);

        }
        private void MakeAnotherDog()
        {
            //make a dog
            //range
            string dogname = "newdog";
            int dogchipNumber = 54685;
            SimpleDate dogDateOfBirth = new SimpleDate(7,7,1990);
            SimpleDate dogDateOfWalk = new SimpleDate(8,5,2005);

            //act
            Testdog = new Dog(dogchipNumber, dogDateOfBirth, dogname, dogDateOfWalk);

        }

        //test class: cat
        [TestMethod]
        public void Test_CatNumber1()
        {
            MakeCat();
            //assert
            int expectedNumber = 123;
            int accualNumber = Testcat.ChipRegistrationNumber;
            Assert.AreEqual(expectedNumber, accualNumber);
        }
        [TestMethod]
        public void Test_CatNumber2()
        {
            MakeAnotherCat();
            //assert
            int expectedNumber = 85725;
            int accualNumber = Testcat.ChipRegistrationNumber;
            Assert.AreEqual(expectedNumber, accualNumber);
        }
        [TestMethod]
        public void Test_CatDate1()
        {
            MakeCat();
            //assert
            string thisDate = Convert.ToString(Testcat.DateOfBirth);
            string wantedDate = Convert.ToString(new SimpleDate(2, 5, 2015));
            Assert.AreEqual(wantedDate, thisDate);
        }
        [TestMethod]
        public void Test_CatDate2()
        {
            MakeAnotherCat();
            //assert
            string thisDate = Convert.ToString(Testcat.DateOfBirth);
            string wantedDate = Convert.ToString(new SimpleDate(7, 5, 2000));
            Assert.AreEqual(wantedDate, thisDate);
        }
        [TestMethod]
        public void test_CatName1()
        {
            MakeCat();
            //assert
            string expectedname = "thiscat";
            string accualname = Testcat.Name;
            Assert.AreEqual(expectedname, accualname);
        }
        [TestMethod]
        public void test_CatName2()
        {
            MakeAnotherCat();
            //assert
            string expectedname = "newCat";
            string accualname = Testcat.Name;
            Assert.AreEqual(expectedname, accualname);
        }
        [TestMethod]
        public void test_CatHabits1()
        {
            MakeCat();
            //assert
            string expectedHabit = "kan de kattebak niet vinden";
            string accualHabit = Testcat.BadHabits;
            Assert.AreEqual(expectedHabit, accualHabit);
        }
        [TestMethod]
        public void test_CatHabits2()
        {
            MakeAnotherCat();
            //assert
            string expectedHabit = "";
            string accualHabit = Testcat.BadHabits;
            Assert.AreEqual(expectedHabit, accualHabit);
        }
        [TestMethod]
        public void Test_CatMakeNoise()
        {
            MakeCat();

            //assert 
            string expectednoise = "Miauw";
            string accualnoise = Testcat.MakeNoise();
            Assert.AreEqual(expectednoise, accualnoise);
        }
        [TestMethod]
        public void Test_CatGetPrice1()
        {
            MakeCat();

            //assert
            decimal expectedPrice = 33;
            decimal accualPrice = Testcat.Price;
            Assert.AreEqual(expectedPrice, accualPrice);
        }
        [TestMethod]
        public void Test_CatGetPrice2()
        {
            MakeAnotherCat();

            //assert
            decimal expectedPrice = 60;
            decimal accualPrice = Testcat.Price;
            Assert.AreEqual(expectedPrice, accualPrice);
        }
        //test class: dog
        [TestMethod]
        public void Test_DogNumber1()
        {
            MakeDog();
            //assert
            int expectedresult = 123;
            int accualresult = Testdog.ChipRegistrationNumber;
            Assert.AreEqual(expectedresult, accualresult);
        }
        [TestMethod]
        public void Test_DogNumber2()
        {
            MakeAnotherDog();
            //assert
            int expectedresult = 54685;
            int accualresult = Testdog.ChipRegistrationNumber;
            Assert.AreEqual(expectedresult, accualresult);
        }
        [TestMethod]
        public void Test_DogDateBirth1()
        {
            MakeDog();
            //assert
            string expectedDate = Convert.ToString(new SimpleDate(2, 5, 2015));
            string accualDate = Convert.ToString(Testdog.DateOfBirth);
            Assert.AreEqual(expectedDate, accualDate);
        }
        [TestMethod]
        public void Test_DogDateBirth2()
        {
            MakeAnotherDog();
            //assert
            string expectedDate = Convert.ToString(new SimpleDate(7, 7, 1990));
            string accualDate = Convert.ToString(Testdog.DateOfBirth);
            Assert.AreEqual(expectedDate, accualDate);
        }
        [TestMethod]
        public void Test_DogName1()
        {
            MakeDog();
            //assert
            string expectedName = "thisdog";
            string accualName = Testdog.Name;
            Assert.AreEqual(expectedName, accualName);
        }
        [TestMethod]
        public void Test_DogName2()
        {
            MakeAnotherDog();
            //assert
            string expectedName = "newdog";
            string accualName = Testdog.Name;
            Assert.AreEqual(expectedName, accualName);
        }
        [TestMethod]
        public void Test_DogWalk1()
        {
            MakeDog();
            //assert
            string expectedDate = Convert.ToString(new SimpleDate(2, 6, 2015));
            string accualDate = Convert.ToString(Testdog.LastWalkDate);
            Assert.AreEqual(expectedDate, accualDate);
        }
        [TestMethod]
        public void Test_DogWalk2()
        {
            MakeAnotherDog();
            //assert
            string expectedDate = Convert.ToString(new SimpleDate(8, 5, 2005));
            string accualDate = Convert.ToString(Testdog.LastWalkDate);
            Assert.AreEqual(expectedDate, accualDate);
        }
        [TestMethod]
        public void Test_DogMakeNoise()
        {
            MakeDog();
            //assert 
            string expectednoise = "Woof";
            string accualnoise = Testdog.MakeNoise();
            Assert.AreEqual(expectednoise, accualnoise);
        }
        [TestMethod]
        public void Test_DogPrice1()
        {
            MakeDog();

            //assert
            decimal expectedPrice = 200;
            decimal accualPrice = Testdog.Price;
            Assert.AreEqual(expectedPrice, accualPrice);
        }
        [TestMethod]
        public void Test_DogPrice2()
        {
            MakeAnotherDog();

            //assert
            decimal expectedPrice = 350;
            decimal accualPrice = Testdog.Price;
            Assert.AreEqual(expectedPrice, accualPrice);
        }
        //test class: administration
        [TestMethod]
        public void Test_AdministrationAddCat()
        {
            //range
            string catname = "thiscat";
            int catchipNumber = 123;
            SimpleDate catDateOfBirth = new SimpleDate(2, 5, 2015);
            string catbadHabits = "kan de kattebak niet vinden";
            //act
            Animal newtestcat = new Cat(catchipNumber, catDateOfBirth, catname, catbadHabits);
            TestAdministration.Add(newtestcat);
            //assert
            Animal expectedresult = newtestcat;
            Animal accualresult = TestAdministration.FindAnimal(newtestcat.ChipRegistrationNumber);
            Assert.AreEqual(expectedresult, accualresult);
        }
        [TestMethod]
        public void Test_AdministrationAddDog()
        {
            //range
            string dogname = "thisdog";
            int dogchipNumber = 123;
            SimpleDate dogDateOfBirth = new SimpleDate(2, 5, 2015);
            SimpleDate dogDateOfWalk = new SimpleDate(2, 6, 2015);
            //act
            Animal newtestdog = new Dog(dogchipNumber, dogDateOfBirth, dogname, dogDateOfWalk);
            TestAdministration.Add(newtestdog);
            //assert
            Animal expectedresult = newtestdog;
            Animal accualresult = TestAdministration.FindAnimal(newtestdog.ChipRegistrationNumber);
            Assert.AreEqual(expectedresult, accualresult);
        }
        [TestMethod]
        public void Test_AdministrationDelTrue()
        {
            //act
            MakeCat();
            TestAdministration.Add(Testcat);
            TestAdministration.RemoveAnimal(123);
            //assert
            Animal expectedResult = null;
            Animal accualResult = TestAdministration.FindAnimal(123);
            Assert.AreEqual(expectedResult, accualResult);
        }
        [TestMethod]
        public void Test_AdministrationDelFalse()
        {
            //act
            MakeCat();
            TestAdministration.Add(Testcat);
            TestAdministration.RemoveAnimal(123);
            //assert
            Animal expectedResult = null;
            Animal accualResult = TestAdministration.FindAnimal(123);
            Assert.AreEqual(expectedResult, accualResult);
        }
        [TestMethod]
        public void Test_AdministrationFindAnimal()
        {
            MakeCat();
            TestAdministration.Add(Testcat);
            //assert
            Animal expectedAnimal = Testcat;
            Animal accualAnimal = TestAdministration.FindAnimal(123);
            Assert.AreEqual(expectedAnimal, accualAnimal);
        }
        [TestMethod]
        public void Test_AdministrationFindAnimalNULL()
        {
            MakeCat();
            TestAdministration.Add(Testcat);
            //assert
            Animal expectedAnimal = null;
            Animal accualAnimal = TestAdministration.FindAnimal(456);
            Assert.AreEqual(expectedAnimal, accualAnimal);
        }
        [TestMethod]
        public void Test_AdministrationAlreadyInSystemTrue()
        {
            MakeCat();
            TestAdministration.Add(Testcat);
            //assert
            Animal expectedresult = Testcat;
            Animal accualResult = TestAdministration.FindAnimal(123);
            Assert.AreEqual(expectedresult, accualResult);
        }
        [TestMethod]
        public void Test_AdministrationAlreadyInSystemFalse()
        {
            MakeCat();
            TestAdministration.Add(Testcat);
            //assert
            Animal expectedResult = null;
            Animal accualResult = TestAdministration.FindAnimal(456);
            Assert.AreEqual(expectedResult, accualResult);
        }
        [TestMethod]
        public void Test_AdministrationChangeAnimal()
        {
            MakeDog();
            TestAdministration.Add(Testdog);
            TestAdministration.Change(Testdog = new Dog(123, new SimpleDate(2, 5, 2015), "ANewDog", new SimpleDate(2, 6, 2015)));
            //assert
            Animal expectedResult = Testdog;
            Animal accualResult = TestAdministration.FindAnimal(123);
            Assert.AreEqual(expectedResult, accualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_AdministrationChangeAnimalNULL()
        {
            MakeDog();
            TestAdministration.Add(Testdog);
            Testdog = null;
            TestAdministration.Change(Testdog);
        }
    }
}
