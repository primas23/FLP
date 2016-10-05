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
                new History() { KickoffTime = DateTime.Today, TotalPoints = -1},
                new History() { KickoffTime = DateTime.Today, TotalPoints = -1},
                new History() { KickoffTime = DateTime.Today, TotalPoints = -1}
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
                new History() { KickoffTime = DateTime.Today, TotalPoints = 1},
                new History() { KickoffTime = DateTime.Today, TotalPoints = 1},
                new History() { KickoffTime = DateTime.Today, TotalPoints = 1}
            };

            PlayerInformation playerInformation = new PlayerInformation() { History = histories };

            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);

            Assert.AreEqual(1, summery.Form);
        }
    }
}
