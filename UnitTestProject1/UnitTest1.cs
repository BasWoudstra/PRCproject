﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Cat Testcat;
        Dog Testdog;

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
        
        //cat
        [TestMethod]
        public void Test_CatNumber()
        {
            MakeCat();
            //assert
            int expectedNumber = 123;
            int accualNumber = Testcat.ChipRegistrationNumber;
            Assert.AreEqual(expectedNumber, accualNumber);
        }
        [TestMethod]
        public void Test_CatDate()
        {
            MakeCat();
            //assert
            string thisDate = Convert.ToString(Testcat.DateOfBirth);
            string wantedDate = Convert.ToString(new SimpleDate(2, 5, 2015));
            Assert.AreEqual(wantedDate, thisDate);
        }
        [TestMethod]
        public void test_CatName()
        {
            MakeCat();
            //assert
            string expectedname = "thiscat";
            string accualname = Testcat.Name;
            Assert.AreEqual(expectedname, accualname);
        }
        [TestMethod]
        public void test_CatHabits()
        {
            MakeCat();
            //assert
            string expectedHabit = "kan de kattebak niet vinden";
            string accualHabit = Testcat.BadHabits;
            Assert.AreEqual(expectedHabit, accualHabit);
        }
        [TestMethod]
        public void Test_CatMakeNoise()
        {
            MakeCat();

            //assert 
            string expectednoise = "Miauw";
            string accualnoise = Testcat.makeNoise();
            Assert.AreEqual(expectednoise, accualnoise);
        }
        //dog
        [TestMethod]
        public void Test_DogNumber()
        {
            MakeDog();
            //assert
            int expectedresult = 123;
            int accualresult = Testdog.ChipRegistrationNumber;
            Assert.AreEqual(expectedresult, accualresult);
        }
        [TestMethod]
        public void Test_DogDateBirth()
        {
            MakeDog();
            //assert
            string expectedDate =Convert.ToString( new SimpleDate(2, 5, 2015));
            string accualDate = Convert.ToString( Testdog.DateOfBirth);
            Assert.AreEqual(expectedDate, accualDate);
        }
        [TestMethod]
        public void Test_DogName()
        {
            MakeDog();
            //assert
            string expectedName = "thisdog";
            string accualName = Testdog.Name;
            Assert.AreEqual(expectedName, accualName);
        }
        [TestMethod]
        public void Test_DogWalk()
        {
            MakeDog();
            //assert
            string expectedDate =Convert.ToString( new SimpleDate(2, 6, 2015));
            string accualDate =Convert.ToString( Testdog.LastWalkDate );
            Assert.AreEqual(expectedDate, accualDate);
        }
        [TestMethod]
        public void Test_DogMakeNoise()
        {
            MakeDog();
            //assert 
            string expectednoise = "Woof";
            string accualnoise = Testdog.makeNoise();
            Assert.AreEqual(expectednoise, accualnoise);
        }
    }
}
