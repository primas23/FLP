// <copyright file="Startup.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Console
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;

    using FPL.Data;
    using FPL.Data.Utilities;
    using FPL.Data.Models;
    using FPL.Data.Models.FullStats;
    using FPL.WebCrawler;

    using Newtonsoft.Json;
    
    /// <summary>
    /// The startup class of the console
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            /*
            PlayerInformation information = FantasyPremierLeague.GetPlayerInformation(82);
            information.UrlId = 82;
            information.FirstName = "Eden";
            information.LastName = "Hazard";

            using (var db = new FplContext())
            {
                db.PlayerInformations.Add(information);
                db.SaveChanges();
            }
            */

            List<PlayerInformation> informations = new List<PlayerInformation>();

            for (int i = 1; i < 10; i++)
            {
                var infoPl = FantasyPremierLeague.GetPlayerInformationFromWeb(i);
                informations.Add(infoPl);
                System.Console.WriteLine("Added player with id={0} to info List", i);
            }

            using (var db = new FplContext())
            {
                for (int i = 0; i < informations.Count; i++)
                {
                    PlayerInformation pi = PlayerInformationDbMapper.MapPlayerInformationFromDataBase(informations[i], db);

                    db.PlayerInformations.AddOrUpdate(pi);
                    db.SaveChanges();

                    Console.WriteLine("Added player with id={0} to db", i);
                }

                db.SaveChanges();
            }

            Console.WriteLine("Done");

            /*
            using (var db = new FplContext())
            {
                PlayerInformation information = FantasyPremierLeague.GetPlayerInformation(4);
                var eden = db.PlayerInformations
                    .FirstOrDefault(p => p.Id == 4);
                System.Console.WriteLine();

            }

            using (var db = new FplContext())
            {
                var plyer = db.PlayerInformations.FirstOrDefault(p => p.Id == 1);
                db.PlayerInformations.Remove(plyer);
                db.SaveChanges();
            }
            */
        }
    }
}
