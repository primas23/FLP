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
        #region Constructor tests

        /// <summary>
        /// The Class should throw exception when null is provided in constructor.
        /// </summary>
        [TestMethod]
        public void Class_ShoudThrowException_WhenNullIsProvidedInConstructor()
        {
            ThrowsAssert.Throws<ArgumentNullException>(() => new FantasyPremierLeagueInfoSummary(null));
        }

        /// <summary>
        /// Classes the should throw exception when total points sum is bigger that integer maximum.
        /// </summary>
        [TestMethod]
        public void Class_ShouldThrowException_WhenTotalPointsSumIsBiggerThatIntMax()
        {
            PlayerInformation playerInformation = new PlayerInformation
            {
                Histories = new List<History>()
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

        #endregion

        #region Firs name tests

        /// <summary>
        /// First name the should return the same string for first name when Player information first name is provided.
        /// </summary>
        [TestMethod]
        public void FirstName_ShouldReturnSameStringForFirstName_WhenPlayerInfoFirstNameIsProvided()
        {
            string name = "Peter";
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = name };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(name, summery.FirstName);
        }

        /// <summary>
        /// First name the should return empty sting for first name when Player information first name is empty.
        /// </summary>
        [TestMethod]
        public void FirstName_ShouldReturnEmptyStingForFirstName_WhenPlayerInfoFirstNameIsEmpty()
        {
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = string.Empty };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.FirstName);
        }

        /// <summary>
        /// First name the should return empty sting for first name when Player information first name is white space.
        /// </summary>
        [TestMethod]
        public void FirstName_ShouldReturnEmptyStingForFirstName_WhenPlayerInfoFirstNameIsWhiteSpace()
        {
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = "   " };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.FirstName);
        }

        /// <summary>
        /// First name the should return empty sting for first name when Player information first name is null.
        /// </summary>
        [TestMethod]
        public void FirstName_ShouldReturnEmptyStingForFirstName_WhenPlayerInfoFirstNameIsNull()
        {
            PlayerInformation playerInformation = new PlayerInformation() { FirstName = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.FirstName);
        }
        #endregion

        #region Last name tests

        /// <summary>
        /// Last name the should return same string for last name when Player information last name is provided.
        /// </summary>
        [TestMethod]
        public void LastName_ShouldReturnSameStringForLastName_WhenPlayerInfoLastNameIsProvided()
        {
            string name = "Petrov";
            PlayerInformation playerInformation = new PlayerInformation() { LastName = name };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(name, summery.LastName);
        }

        /// <summary>
        /// Last name the should return empty sting for last name when Player information last name is empty.
        /// </summary>
        [TestMethod]
        public void LastName_ShouldReturnEmptyStingForLastName_WhenPlayerInfoLastNameIsEmpty()
        {
            PlayerInformation playerInformation = new PlayerInformation() { LastName = string.Empty };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.LastName);
        }

        /// <summary>
        /// Last name the should return empty sting for last name when Player information last name is white space.
        /// </summary>
        [TestMethod]
        public void LastName_ShouldReturnEmptyStingForLastName_WhenPlayerInfoLastNameIsWhiteSpace()
        {
            PlayerInformation playerInformation = new PlayerInformation() { LastName = "   " };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.LastName);
        }

        /// <summary>
        /// Last name the should return empty sting for last name when Player information last name is null.
        /// </summary>
        [TestMethod]
        public void LastName_ShouldReturnEmptyStingForLastName_WhenPlayerInfoLastNameIsNull()
        {
            PlayerInformation playerInformation = new PlayerInformation() { LastName = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(string.Empty, summery.LastName);
        }

        #endregion

        #region Form tests

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
            PlayerInformation playerInformation = new PlayerInformation() { Histories = new List<History>() };

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

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

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

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(1, summery.Form);
        }

        #endregion

        #region Total points tests

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

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(3, summery.TotalPoints);
        }

        /// <summary>
        /// Total the points should return correct number when list of history points is correct and one is null.
        /// </summary>
        [TestMethod]
        public void TotalPoints_ShouldReturnCorrectNumber_WhenListOfHistoryPointsIsCorrectAndOneIsNull()
        {
            List<History> histories = new List<History>()
            {
                new History() { TotalPoints = 1 },
                new History() { TotalPoints = 1 },
                null
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.TotalPoints);
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

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.TotalPoints);
        }

        /// <summary>
        /// Total the points should return zero when history is null.
        /// </summary>
        [TestMethod]
        public void TotalPoints_ShouldReturnZero_WhenHistoryIsNull()
        {
            PlayerInformation playerInformation = new PlayerInformation() { Histories = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.TotalPoints);
        }

        /// <summary>
        /// Totals the points should return zero when no history is provided.
        /// </summary>
        [TestMethod]
        public void TotalPoints_ShouldReturnZero_WhenNoHistoryIsProvided()
        {
            PlayerInformation playerInformation = new PlayerInformation() { Histories = new List<History>() };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.TotalPoints);
        }

        #endregion

        #region Influence tests

        /// <summary>
        /// Influence should return correct number when list of history influence is correct.
        /// </summary>
        [TestMethod]
        public void Influence_ShouldReturnCorrectNumber_WhenListOfHistoryInfluenceIsCorrect()
        {
            List<History> histories = new List<History>()
            {
                new History() { Influence = "2" },
                new History() { Influence = "2" },
                new History() { Influence = "2" }
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.Influence);
        }

        /// <summary>
        /// Influence should return 0 when no history is provided.
        /// </summary>
        [TestMethod]
        public void Influence_ShouldReturnZero_WhenNoHistoryIsProvided()
        {
            PlayerInformation playerInformation = new PlayerInformation();

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Influence);
        }

        /// <summary>
        /// Influence should return 0 when null history is provided.
        /// </summary>
        [TestMethod]
        public void Influence_ShouldReturnZero__WhenNullHistoryIsProvided()
        {
            PlayerInformation playerInformation = new PlayerInformation() { Histories = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Influence);
        }

        /// <summary>
        /// Influence should return correct number when list of history influence is correct and one is null.
        /// </summary>
        [TestMethod]
        public void Influence_ShouldReturnCorrectNumber_WhenListOfHistoryInfluenceIsCorrectAndOneIsNull()
        {
            List<History> histories = new List<History>()
            {
                new History() { Influence = "1" },
                new History() { Influence = "1" },
                null
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(1, summery.Influence);
        }

        /// <summary>
        /// Influence should return zero when list of history influences are zero.
        /// </summary>
        [TestMethod]
        public void Influence_ShouldReturnZeor_WhenListOfHistoryInfluenceAreZero()
        {
            List<History> histories = new List<History>()
            {
                new History() { Influence = "0" },
                new History() { Influence = "0" }
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Influence);
        }

        /// <summary>
        /// Influence should return correct number when list of history influence are correct and one is null.
        /// </summary>
        [TestMethod]
        public void Influence_ShouldReturnCorrectNumber_WhenListOfHistoryInfluenceAreCorrectAndOneIsNull()
        {
            List<History> histories = new List<History>()
            {
                new History() { Influence = "0" },
                new History() { Influence = "0" },
                new History() { Influence = null },
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Influence);
        }

        #endregion

        #region Creativity tests

        /// <summary>
        /// Creativity should return 0 when list of history creativities are 0.
        /// </summary>
        [TestMethod]
        public void Creativity_ShouldReturnZero_WhenListOfHistoryCreativityAreZero()
        {
            List<History> histories = new List<History>()
            {
                new History() { Creativity = "0" },
                new History() { Creativity = "0" }
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Creativity);
        }

        /// <summary>
        /// Creativity should return correct number when list of history creativities are correct.
        /// </summary>
        [TestMethod]
        public void Creativity_ShouldReturnCorrectNumber_WhenListOfHistoryCreativityAreCorrect()
        {
            List<History> histories = new List<History>()
            {
                new History() { Creativity = "2" },
                new History() { Creativity = "2" }
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.Creativity);
        }

        /// <summary>
        /// Creativity should return correct number when list of history creativities are correct and one is null.
        /// </summary>
        [TestMethod]
        public void Creativity_ShouldReturnCorrectNumber_WhenListOfHistoryCreativityAreCorrectAndOneIsNull()
        {
            List<History> histories = new List<History>()
            {
                new History() { Creativity = "2" },
                new History() { Creativity = "2" },
                new History() { Creativity = null },
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.Creativity);
        }

        /// <summary>
        /// Creativity should return correct number when list of history creativity are correct and one history is null.
        /// </summary>
        [TestMethod]
        public void Creativity_ShouldReturnCorrectNumber_WhenListOfHistoryCreativityAreCorrectAndOneHistoryIsNull()
        {
            List<History> histories = new List<History>()
            {
                new History() { Creativity = "2" },
                new History() { Creativity = "2" },
                null
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.Creativity);
        }

        /// <summary>
        /// Creativity should return zero when history is null.
        /// </summary>
        [TestMethod]
        public void Creativity_ShouldReturnZero_WhenHistoryIsNull()
        {
            PlayerInformation playerInformation = new PlayerInformation() { Histories = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Creativity);
        }

        /// <summary>
        /// Creativity should return zero when no history is provided.
        /// </summary>
        [TestMethod]
        public void Creativity_ShouldReturnZero_WhenNoHistoryIsProvided()
        {
            PlayerInformation playerInformation = new PlayerInformation();

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Creativity);
        }

        #endregion

        #region Threat tests

        /// <summary>
        /// Threat should return 0 when list of history threats are 0.
        /// </summary>
        [TestMethod]
        public void Threat_ShouldReturnZero_WhenListOfHistoryThreatsAreZero()
        {
            List<History> histories = new List<History>()
            {
                new History() { Threat = "0" },
                new History() { Threat = "0" }
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Threat);
        }

        /// <summary>
        /// Threat should return correct number when list of history threats are correct.
        /// </summary>
        [TestMethod]
        public void Threat_ShouldReturnCorrectNumber_WhenListOfHistoryThreatsAreCorrect()
        {
            List<History> histories = new List<History>()
            {
                new History() { Threat = "2" },
                new History() { Threat = "2" }
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.Threat);
        }

        /// <summary>
        /// Threat should return correct number when list of history threats are correct and one is null.
        /// </summary>
        [TestMethod]
        public void Threat_ShouldReturnCorrectNumber_WhenListOfHistoryThreatsAreCorrectAndOneIsNull()
        {
            List<History> histories = new List<History>()
            {
                new History() { Threat = "2" },
                new History() { Threat = "2" },
                new History() { Threat = null },
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.Threat);
        }

        /// <summary>
        /// Threat should return correct number when list of history threats are correct and one history is null.
        /// </summary>
        [TestMethod]
        public void Threat_ShouldReturnCorrectNumber_WhenListOfHistoryThreatsAreCorrectAndOneHistoryIsNull()
        {
            List<History> histories = new List<History>()
            {
                new History() { Threat = "2" },
                new History() { Threat = "2" },
                null
            };

            PlayerInformation playerInformation = new PlayerInformation() { Histories = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(2, summery.Threat);
        }

        /// <summary>
        /// Threat should return zero when history is null.
        /// </summary>
        [TestMethod]
        public void Threat_ShouldReturnZero_WhenHistoryIsNull()
        {
            PlayerInformation playerInformation = new PlayerInformation() { Histories = null };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Threat);
        }

        /// <summary>
        /// Threat should return zero when no history is provided.
        /// </summary>
        [TestMethod]
        public void Threat_ShouldReturnZero_WhenNoHistoryIsProvided()
        {
            PlayerInformation playerInformation = new PlayerInformation();

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(0, summery.Threat);
        }

        #endregion
    }
}
