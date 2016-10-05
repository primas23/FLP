// <copyright file="FantasyPremierLeagueInfoSummaryTests.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MSTestExtensions;

    using FPL.Data.Models.FullStats;
    using FPL.Data.Models.SummaryStats;

    /// <summary>
    /// Tests for FantasyPremierLeagueInfoSummary class
    /// </summary>
    [TestClass]
    public class FantasyPremierLeagueInfoSummaryTests
    {
        /// <summary>
        /// The Class should throw exception when null is provided in constructor.
        /// </summary>
        [TestMethod]
        public void Class_ShoudThrowException_WhenNullIsProvidedInConstructor()
        {
            ThrowsAssert.Throws<ArgumentNullException>(() => new FantasyPremierLeagueInfoSummary(null));
        }

        /// <summary>
        /// Classes the shoud throw exception when total points sum is bigger that int maximum.
        /// </summary>
        [TestMethod]
        public void Class_ShoudThrowException_WhenTotalPointsSumIsBiggerThatIntMax()
        {
            PlayerInformation playerInformation = new PlayerInformation
            {
                History = new List<History>()
                {
                    new History()
                    {
                        TotalPoints = int.MaxValue
                    },
                    new History()
                    {
                        TotalPoints = 1
                    }
                }
            };



            ThrowsAssert.Throws<ArgumentOutOfRangeException>(() => new FantasyPremierLeagueInfoSummary(playerInformation));
        }

        /// <summary>
        /// Forms the should return the same string for first name when Player information first name is provided.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnSameStringForFirstName_WhenPlayerInfoFirstNameIsProvided()
        {
            string name = "Peter";
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = name };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(name, summery.FirstName);
        }

        /// <summary>
        /// Form the should return empty sting for first name when Player information first name is empty.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnEmptyStingForFirstName_WhenPlayerInfoFirstNameIsEmpty()
        {
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = string.Empty };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.FirstName);
        }

        /// <summary>
        /// Forms the should return empty sting for first name when Player information first name is white space.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnEmptyStingForFirstName_WhenPlayerInfoFirstNameIsWhiteSpace()
        {
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = "   " };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.FirstName);
        }

        /// <summary>
        /// Forms the should return empty sting for first name when Player information first name is null.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnEmptyStingForFirstName_WhenPlayerInfoFirstNameIsNull()
        {
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.FirstName);
        }

        /// <summary>
        /// Forms the should return same string for last name when Player information last name is provided.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnSameStringForLastName_WhenPlayerInfoLastNameIsProvided()
        {
            string name = "Petrov";
            PlayerInformation playerInformation = new PlayerInformation() { LastName = name };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(name, summery.LastName);
        }

        /// <summary>
        /// Forms the should return empty sting for last name when Player information last name is empty.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnEmptyStingForLastName_WhenPlayerInfoLastNameIsEmpty()
        {
            PlayerInformation playerInformation = new PlayerInformation() { LastName = string.Empty };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.LastName);
        }

        /// <summary>
        /// Forms the should return empty sting for last name when Player information last name is white space.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnEmptyStingForLastName_WhenPlayerInfoLastNameIsWhiteSpace()
        {
            PlayerInformation playerInformation = new PlayerInformation() { LastName = "   " };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.LastName);
        }

        /// <summary>
        /// Forms the should return empty sting for last name when Player information last name is null.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnEmptyStingForLastName_WhenPlayerInfoLastNameIsNull()
        {
            PlayerInformation playerInformation = new PlayerInformation() { LastName = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.LastName);
        }

        /// <summary>
        /// The forms should return 0 when no list of history is Supplied.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnZero_WhenNoListOfHistoryIsSupplied()
        {
            PlayerInformation playerInformation = new PlayerInformation();

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Form);
        }

        /// <summary>
        /// The forms should return 0 when list of history is empty.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnZero_WhenListOfHistoryIsEmpty()
        {
            PlayerInformation playerInformation = new PlayerInformation() { History = new List<History>() };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Form);
        }

        /// <summary>
        /// The form should return zero when list of history is filled with negative total points.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnZero_WhenListOfHistoryIsFilledWithNegativeTotalPoints()
        {
            List<History> histories = new List<History>()
            {
                new History() { KickoffTime = DateTime.Today, TotalPoints = -1 },
                new History() { KickoffTime = DateTime.Today, TotalPoints = -1 },
                new History() { KickoffTime = DateTime.Today, TotalPoints = -1 }
            };

            PlayerInformation playerInformation = new PlayerInformation() { History = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Form);
        }

        /// <summary>
        /// The Form should return correct number when list of history is correct.
        /// </summary>
        [TestMethod]
        public void Form_ShouldReturnCorrectNumber_WhenListOfHistoryIsCorrect()
        {
            List<History> histories = new List<History>()
            {
                new History() { KickoffTime = DateTime.Today, TotalPoints = 1 },
                new History() { KickoffTime = DateTime.Today, TotalPoints = 1 },
                new History() { KickoffTime = DateTime.Today, TotalPoints = 1 }
            };

            PlayerInformation playerInformation = new PlayerInformation() { History = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(1, summery.Form);
        }

        /// <summary>
        /// Total points should return correct number when list of history points is correct.
        /// </summary>
        [TestMethod]
        public void TotalPoints_ShouldReturnCorrectNumber_WhenListOfHistoryPointsIsCorrect()
        {
            List<History> histories = new List<History>()
            {
                new History() { TotalPoints = 1 },
                new History() { TotalPoints = 1 },
                new History() { TotalPoints = 1 }
            };

            PlayerInformation playerInformation = new PlayerInformation() { History = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(3, summery.TotalPoints);
        }

        /// <summary>
        /// Total the points should return zero when list of history points are zero.
        /// </summary>
        [TestMethod]
        public void TotalPoints_ShouldReturnZero_WhenListOfHistoryPointsAreZero()
        {
            List<History> histories = new List<History>()
            {
                new History() { TotalPoints = 0 },
                new History() { TotalPoints = 0 },
                new History() { TotalPoints = 0 }
            };

            PlayerInformation playerInformation = new PlayerInformation() { History = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.TotalPoints);
        }

        /// <summary>
        /// Totals the points should return zero when no history is provided.
        /// </summary>
        [TestMethod]
        public void TotalPoints_ShouldReturnZero_WhenNoHistoryIsProvided()
        {
            PlayerInformation playerInformation = new PlayerInformation() { History = new List<History>() };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.TotalPoints);
        }
    }
}
