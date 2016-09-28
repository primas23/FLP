// <copyright file="FantasyPremierLeagueInfoSummary.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.SummaryStats
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FPL.Data.Models.FullStats;

    /// <summary>
    /// The Fantasy Premier League Information Summary
    /// </summary>
    public class FantasyPremierLeagueInfoSummary
    {
        /// <summary>
        /// The player information
        /// </summary>
        private readonly PlayerInformation _playerInformation = null;

        /// <summary>
        /// The total points
        /// </summary>
        private int _totalPoints = 0;

        /// <summary>
        /// The form
        /// </summary>
        private double _form = 0;

        /// <summary>
        /// The influence
        /// </summary>
        private double _influence = 0;

        /// <summary>
        /// The creativity
        /// </summary>
        private double _creativity = 0;

        /// <summary>
        /// The thread
        /// </summary>
        private double _thread = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="FantasyPremierLeagueInfoSummary"/> class.
        /// </summary>
        /// <param name="playerInformation">The player information.</param>
        public FantasyPremierLeagueInfoSummary(PlayerInformation playerInformation)
        {
            this._playerInformation = playerInformation;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get
            {
                return this._playerInformation.FirstName;
            }
        }

        /// <summary>
        /// Gets the name of the second.
        /// </summary>
        /// <value>
        /// The name of the second.
        /// </value>
        public string LastName
        {
            get
            {
                return this._playerInformation.LastName;
            }
        }

        /// <summary>
        /// Gets the form.
        /// </summary>
        /// <value>
        /// The form.
        /// </value>
        public double Form
        {
            get
            {
                if (Math.Abs(this._form) < 0.001)
                {
                    List<History> allMatches = this._playerInformation
                    .History
                    .Where(h => h.KickoffTime > DateTime.Now.AddMonths(-1))
                    .ToList();

                    double sum = allMatches
                        .Select(h => h.TotalPoints)
                        .Sum();

                    this._form = sum / allMatches.Count;
                }

                return this._form;
            }
        }

        /// <summary>
        /// Gets the total points.
        /// </summary>
        /// <value>
        /// The total points.
        /// </value>
        public int TotalPoints
        {
            get
            {
                if (this._totalPoints == 0)
                {
                    IEnumerable<int> historyPoints = this._playerInformation
                    .History
                    .Select(h => h.TotalPoints);

                    this._totalPoints = historyPoints.Sum();
                }

                return this._totalPoints;
            }
        }

        /// <summary>
        /// Gets the influence.
        /// </summary>
        /// <value>
        /// The influence.
        /// </value>
        public double Influence
        {
            get
            {
                if (Math.Abs(this._influence) < 0.001)
                {
                    List<string> influenceStrings = this._playerInformation
                    .History
                    .Select(h => h.Influence)
                    .ToList();

                    this._influence = GetsDoubleSumFromStringCollection(influenceStrings) / influenceStrings.Count;
                }

                return this._influence;
            }
        }

        /// <summary>
        /// Gets the creativity.
        /// </summary>
        /// <value>
        /// The creativity.
        /// </value>
        public double Creativity
        {
            get
            {
                if (Math.Abs(this._creativity) < 0.001)
                {
                    List<string> creativityStrings = this._playerInformation
                    .History
                    .Select(h => h.Creativity)
                    .ToList();

                    this._creativity = GetsDoubleSumFromStringCollection(creativityStrings) / creativityStrings.Count;
                }

                return this._creativity;
            }
        }

        /// <summary>
        /// Gets the threat.
        /// </summary>
        /// <value>
        /// The threat.
        /// </value>
        public double Threat
        {
            get
            {
                if (Math.Abs(this._thread) < 0.001)
                {
                    List<string> threadStrings = this._playerInformation
                    .History
                    .Select(h => h.Threat)
                    .ToList();

                    this._thread = GetsDoubleSumFromStringCollection(threadStrings) / threadStrings.Count;
                }

                return this._thread;
            }
        }

        /// <summary>
        /// Getses the double sum from string collection.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The sum.</returns>
        /// <exception cref="InvalidOperationException">The string:" + str + "was no converted to double.</exception>
        private double GetsDoubleSumFromStringCollection(ICollection<string> data)
        {
            double result = 0;

            foreach (string str in data)
            {
                double temp = 0;

                if (double.TryParse(str, out temp))
                {
                    result += temp;
                }
                else
                {
                    throw new InvalidOperationException("The string:" + str + "was no converted to double.");
                }
            }

            return result;
        }
    }
}
