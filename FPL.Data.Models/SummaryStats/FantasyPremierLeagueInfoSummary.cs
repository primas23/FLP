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
        /// The first name
        /// </summary>
        private string _firstName = string.Empty;

        /// <summary>
        /// The last name
        /// </summary>
        private string _lastName = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="FantasyPremierLeagueInfoSummary"/> class.
        /// </summary>
        /// <param name="playerInformation">The player information.</param>
        /// <exception cref="System.ArgumentNullException">The playerInformation shold not be null!</exception>
        public FantasyPremierLeagueInfoSummary(PlayerInformation playerInformation)
        {
            if (playerInformation == null)
            {
                throw new ArgumentNullException("The playerInformation shold not be null!");
            }

            if (playerInformation.Histories != null)
            {
                IEnumerable<int> totalPointsList = playerInformation
                    .Histories
                    .Where(h => h != null)
                    .Select(h => h.TotalPoints);

                if (this.IsOverflowing(totalPointsList, int.MaxValue))
                {
                    throw new ArgumentOutOfRangeException("The total points should not exceed 2,147,483,647");
                }
            }

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
                if (string.IsNullOrWhiteSpace(this._firstName) && !string.IsNullOrWhiteSpace(this._playerInformation.FirstName))
                {
                    this._firstName = this._playerInformation.FirstName;
                }

                return this._firstName;
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
                if (string.IsNullOrWhiteSpace(this._lastName) && !string.IsNullOrWhiteSpace(this._playerInformation.LastName))
                {
                    this._lastName = this._playerInformation.LastName;
                }

                return this._lastName;
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
                    .Histories
                    .Where(h => h.KickoffTime > DateTime.Now.AddMonths(-1))
                    .ToList();

                    double sum = allMatches
                        .Select(h => h.TotalPoints)
                        .Sum();

                    if (sum > 0)
                    {
                        this._form = sum / allMatches.Count;
                    }
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
                if ((this._totalPoints == 0) && (this._playerInformation.Histories != null))
                {
                    IEnumerable<int> historyPoints = this._playerInformation
                    .Histories
                    .Where(h => h != null)
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
                if ((Math.Abs(this._influence) < 0.001) && (this._playerInformation.Histories != null))
                {
                    List<string> influenceStrings = this._playerInformation
                    .Histories
                    .Where(h => h != null)
                    .Where(h => h.Influence != null)
                    .Select(h => h.Influence)
                    .ToList();

                    double influenceSum = this.GetsDoubleSumFromStringCollection(influenceStrings);

                    if (influenceSum > 0)
                    {
                        this._influence = influenceSum / influenceStrings.Count;
                    }
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
                if ((Math.Abs(this._creativity) < 0.001) && (this._playerInformation.Histories != null))
                {
                    List<string> creativityStrings = this._playerInformation
                    .Histories
                    .Where(h => h != null)
                    .Where(h => h.Creativity != null)
                    .Select(h => h.Creativity)
                    .ToList();

                    double creativitySum = this.GetsDoubleSumFromStringCollection(creativityStrings);

                    if (creativitySum > 0)
                    {
                        this._creativity = creativitySum / creativityStrings.Count;
                    }
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
                if ((Math.Abs(this._thread) < 0.001) && (this._playerInformation.Histories != null))
                {
                    List<string> threadStrings = this._playerInformation
                    .Histories
                     .Where(h => h != null)
                    .Where(h => h.Threat != null)
                    .Select(h => h.Threat)
                    .ToList();

                    double threadSum = this.GetsDoubleSumFromStringCollection(threadStrings);

                    if (threadSum > 0)
                    {
                        this._thread = threadSum / threadStrings.Count;
                    }
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

        /// <summary>
        /// Determines whether the specified enumeration is overflowing the limit.
        /// </summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="maxValue">The maximum value limit.</param>
        /// <returns>
        ///   <c>true</c> if the specified enumeration is overflowing; otherwise, <c>false</c>.
        /// </returns>
        private bool IsOverflowing(IEnumerable<int> enumeration, long maxValue)
        {
            long sum = 0;

            foreach (int num in enumeration)
            {
                if ((maxValue - sum) < num)
                {
                    return true;
                }

                sum += num;
            }

            return false;
        }
    }
}
