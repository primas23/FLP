namespace FPL.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ExtractedFullStatsBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoryPasts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                    FantasyPremierLeagueId = c.Int(nullable: false),
                    SeasonName = c.String(),
                    ElementCode = c.Int(nullable: false),
                    StartCost = c.Int(nullable: false),
                    EndCost = c.Int(nullable: false),
                    TotalPoints = c.Int(nullable: false),
                    Minutes = c.Int(nullable: false),
                    GoalsScored = c.Int(nullable: false),
                    Assists = c.Int(nullable: false),
                    CleanSheets = c.Int(nullable: false),
                    GoalsConceded = c.Int(nullable: false),
                    OwnGoals = c.Int(nullable: false),
                    PenaltiesSaved = c.Int(nullable: false),
                    PenaltiesMissed = c.Int(nullable: false),
                    YellowCards = c.Int(nullable: false),
                    RedCards = c.Int(nullable: false),
                    Saves = c.Int(nullable: false),
                    Bonus = c.Int(nullable: false),
                    Bps = c.Int(nullable: false),
                    Influence = c.String(),
                    Creativity = c.String(),
                    Threat = c.String(),
                    IctIndex = c.String(),
                    EaIndex = c.Int(nullable: false),
                    Season = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.PlayerInformations",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UrlId = c.Int(nullable: false),
                    FirstName = c.String(),
                    LastName = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Explains",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                    ExplainDetails_Id = c.Int(),
                    ExplainFixture_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExplainDetails", t => t.ExplainDetails_Id)
                .ForeignKey("dbo.ExplainFixtures", t => t.ExplainFixture_Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId)
                .Index(t => t.ExplainDetails_Id)
                .Index(t => t.ExplainFixture_Id);

            CreateTable(
                "dbo.ExplainDetails",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                    Bonus_Id = c.Int(),
                    CleanSheets_Id = c.Int(),
                    GoalsScored_Id = c.Int(),
                    Minutes_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bonus", t => t.Bonus_Id)
                .ForeignKey("dbo.CleanSheets", t => t.CleanSheets_Id)
                .ForeignKey("dbo.GoalsScoreds", t => t.GoalsScored_Id)
                .ForeignKey("dbo.Minutes", t => t.Minutes_Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId)
                .Index(t => t.Bonus_Id)
                .Index(t => t.CleanSheets_Id)
                .Index(t => t.GoalsScored_Id)
                .Index(t => t.Minutes_Id);

            CreateTable(
                "dbo.Bonus",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Points = c.Int(nullable: false),
                    Name = c.String(),
                    Value = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.CleanSheets",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Points = c.Int(nullable: false),
                    Name = c.String(),
                    Value = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.GoalsScoreds",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Points = c.Int(nullable: false),
                    Name = c.String(),
                    Value = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.Minutes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Points = c.Int(nullable: false),
                    Name = c.String(),
                    Value = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.ExplainFixtures",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FantasyPremierLeagueId = c.Int(nullable: false),
                    KickoffTimeFormatted = c.String(),
                    Started = c.Boolean(nullable: false),
                    EventDay = c.Int(nullable: false),
                    DeadlineTime = c.DateTime(nullable: false),
                    DeadlineTimeFormatted = c.String(),
                    Code = c.Int(nullable: false),
                    KickoffTime = c.DateTime(nullable: false),
                    TeamHomeScore = c.Int(nullable: false),
                    TeamAwayScore = c.Int(nullable: false),
                    Finished = c.Boolean(nullable: false),
                    Minutes = c.Int(nullable: false),
                    ProvisionalStartTime = c.Boolean(nullable: false),
                    FinishedProvisional = c.Boolean(nullable: false),
                    Event = c.Int(nullable: false),
                    TeamAway = c.Int(nullable: false),
                    TeamHome = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.Stats",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                    Assists_Id = c.Int(),
                    Bonus_Id = c.Int(),
                    Bps_Id = c.Int(),
                    GoalsScored_Id = c.Int(),
                    OwnGoals_Id = c.Int(),
                    PenaltiesMissed_Id = c.Int(),
                    PenaltiesSaved_Id = c.Int(),
                    RedCards_Id = c.Int(),
                    Saves_Id = c.Int(),
                    YellowCards_Id = c.Int(),
                    ExplainFixture_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Assists", t => t.Assists_Id)
                .ForeignKey("dbo.Bonus", t => t.Bonus_Id)
                .ForeignKey("dbo.Bps", t => t.Bps_Id)
                .ForeignKey("dbo.GoalsScoreds", t => t.GoalsScored_Id)
                .ForeignKey("dbo.OwnGoals", t => t.OwnGoals_Id)
                .ForeignKey("dbo.PenaltiesMisseds", t => t.PenaltiesMissed_Id)
                .ForeignKey("dbo.PenaltiesSaveds", t => t.PenaltiesSaved_Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .ForeignKey("dbo.RedCards", t => t.RedCards_Id)
                .ForeignKey("dbo.Saves", t => t.Saves_Id)
                .ForeignKey("dbo.YellowCards", t => t.YellowCards_Id)
                .ForeignKey("dbo.ExplainFixtures", t => t.ExplainFixture_Id)
                .Index(t => t.PlayerInformationId)
                .Index(t => t.Assists_Id)
                .Index(t => t.Bonus_Id)
                .Index(t => t.Bps_Id)
                .Index(t => t.GoalsScored_Id)
                .Index(t => t.OwnGoals_Id)
                .Index(t => t.PenaltiesMissed_Id)
                .Index(t => t.PenaltiesSaved_Id)
                .Index(t => t.RedCards_Id)
                .Index(t => t.Saves_Id)
                .Index(t => t.YellowCards_Id)
                .Index(t => t.ExplainFixture_Id);

            CreateTable(
                "dbo.Assists",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.Homes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Value = c.Int(nullable: false),
                    Element = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                    Assists_Id = c.Int(),
                    Bps_Id = c.Int(),
                    OwnGoals_Id = c.Int(),
                    PenaltiesMissed_Id = c.Int(),
                    PenaltiesSaved_Id = c.Int(),
                    RedCards_Id = c.Int(),
                    Saves_Id = c.Int(),
                    YellowCards_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .ForeignKey("dbo.Assists", t => t.Assists_Id)
                .ForeignKey("dbo.Bps", t => t.Bps_Id)
                .ForeignKey("dbo.OwnGoals", t => t.OwnGoals_Id)
                .ForeignKey("dbo.PenaltiesMisseds", t => t.PenaltiesMissed_Id)
                .ForeignKey("dbo.PenaltiesSaveds", t => t.PenaltiesSaved_Id)
                .ForeignKey("dbo.RedCards", t => t.RedCards_Id)
                .ForeignKey("dbo.Saves", t => t.Saves_Id)
                .ForeignKey("dbo.YellowCards", t => t.YellowCards_Id)
                .Index(t => t.PlayerInformationId)
                .Index(t => t.Assists_Id)
                .Index(t => t.Bps_Id)
                .Index(t => t.OwnGoals_Id)
                .Index(t => t.PenaltiesMissed_Id)
                .Index(t => t.PenaltiesSaved_Id)
                .Index(t => t.RedCards_Id)
                .Index(t => t.Saves_Id)
                .Index(t => t.YellowCards_Id);

            CreateTable(
                "dbo.Bps",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.Aways",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Value = c.Int(nullable: false),
                    Element = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                    Bps_Id = c.Int(),
                    OwnGoals_Id = c.Int(),
                    PenaltiesMissed_Id = c.Int(),
                    PenaltiesSaved_Id = c.Int(),
                    RedCards_Id = c.Int(),
                    Saves_Id = c.Int(),
                    YellowCards_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .ForeignKey("dbo.Bps", t => t.Bps_Id)
                .ForeignKey("dbo.OwnGoals", t => t.OwnGoals_Id)
                .ForeignKey("dbo.PenaltiesMisseds", t => t.PenaltiesMissed_Id)
                .ForeignKey("dbo.PenaltiesSaveds", t => t.PenaltiesSaved_Id)
                .ForeignKey("dbo.RedCards", t => t.RedCards_Id)
                .ForeignKey("dbo.Saves", t => t.Saves_Id)
                .ForeignKey("dbo.YellowCards", t => t.YellowCards_Id)
                .Index(t => t.PlayerInformationId)
                .Index(t => t.Bps_Id)
                .Index(t => t.OwnGoals_Id)
                .Index(t => t.PenaltiesMissed_Id)
                .Index(t => t.PenaltiesSaved_Id)
                .Index(t => t.RedCards_Id)
                .Index(t => t.Saves_Id)
                .Index(t => t.YellowCards_Id);

            CreateTable(
                "dbo.OwnGoals",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.PenaltiesMisseds",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.PenaltiesSaveds",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.RedCards",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.Saves",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.YellowCards",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.Fixtures",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FantasyPremierLeagueId = c.Int(nullable: false),
                    KickoffTimeFormatted = c.String(),
                    EventName = c.String(),
                    OpponentName = c.String(),
                    OpponentShortName = c.String(),
                    IsHome = c.Boolean(nullable: false),
                    Difficulty = c.Int(nullable: false),
                    Code = c.Int(nullable: false),
                    KickoffTime = c.DateTime(nullable: false),
                    Finished = c.Boolean(nullable: false),
                    Minutes = c.Int(nullable: false),
                    ProvisionalStartTime = c.Boolean(nullable: false),
                    FinishedProvisional = c.Boolean(nullable: false),
                    Event = c.Int(nullable: false),
                    TeamAway = c.Int(nullable: false),
                    TeamHome = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.FixturesSummaries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FantasyPremierLeagueId = c.Int(nullable: false),
                    KickoffTimeFormatted = c.String(),
                    EventName = c.String(),
                    OpponentName = c.String(),
                    OpponentShortName = c.String(),
                    IsHome = c.Boolean(nullable: false),
                    Difficulty = c.Int(nullable: false),
                    Code = c.Int(nullable: false),
                    KickoffTime = c.DateTime(nullable: false),
                    Finished = c.Boolean(nullable: false),
                    Minutes = c.Int(nullable: false),
                    ProvisionalStartTime = c.Boolean(nullable: false),
                    FinishedProvisional = c.Boolean(nullable: false),
                    Event = c.Int(nullable: false),
                    TeamAway = c.Int(nullable: false),
                    TeamHome = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.Histories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FantasyPremierLeagueId = c.Int(nullable: false),
                    KickoffTime = c.DateTime(nullable: false),
                    KickoffTimeFormatted = c.String(),
                    TeamHomeScore = c.Int(nullable: false),
                    TeamAwayScore = c.Int(nullable: false),
                    WasHome = c.Boolean(nullable: false),
                    Round = c.Int(nullable: false),
                    TotalPoints = c.Int(nullable: false),
                    Value = c.Int(nullable: false),
                    TransfersBalance = c.Int(nullable: false),
                    Selected = c.Int(nullable: false),
                    TransfersIn = c.Int(nullable: false),
                    TransfersOut = c.Int(nullable: false),
                    LoanedIn = c.Int(nullable: false),
                    LoanedOut = c.Int(nullable: false),
                    Minutes = c.Int(nullable: false),
                    GoalsScored = c.Int(nullable: false),
                    Assists = c.Int(nullable: false),
                    CleanSheets = c.Int(nullable: false),
                    GoalsConceded = c.Int(nullable: false),
                    OwnGoals = c.Int(nullable: false),
                    PenaltiesSaved = c.Int(nullable: false),
                    PenaltiesMissed = c.Int(nullable: false),
                    YellowCards = c.Int(nullable: false),
                    RedCards = c.Int(nullable: false),
                    Saves = c.Int(nullable: false),
                    Bonus = c.Int(nullable: false),
                    Bps = c.Int(nullable: false),
                    Influence = c.String(),
                    Creativity = c.String(),
                    Threat = c.String(),
                    IctIndex = c.String(),
                    EaIndex = c.Int(nullable: false),
                    OpenPlayCrosses = c.Int(nullable: false),
                    BigChancesCreated = c.Int(nullable: false),
                    ClearancesBlocksInterceptions = c.Int(nullable: false),
                    Recoveries = c.Int(nullable: false),
                    KeyPasses = c.Int(nullable: false),
                    Tackles = c.Int(nullable: false),
                    WinningGoals = c.Int(nullable: false),
                    AttemptedPasses = c.Int(nullable: false),
                    CompletedPasses = c.Int(nullable: false),
                    PenaltiesConceded = c.Int(nullable: false),
                    BigChancesMissed = c.Int(nullable: false),
                    ErrorsLeadingToGoal = c.Int(nullable: false),
                    ErrorsLeadingToGoalAttempt = c.Int(nullable: false),
                    Tackled = c.Int(nullable: false),
                    Offside = c.Int(nullable: false),
                    TargetMissed = c.Int(nullable: false),
                    Fouls = c.Int(nullable: false),
                    Dribbles = c.Int(nullable: false),
                    Element = c.Int(nullable: false),
                    Fixture = c.Int(nullable: false),
                    OpponentTeam = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

            CreateTable(
                "dbo.HistorySummaries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FantasyPremierLeagueId = c.Int(nullable: false),
                    KickoffTime = c.DateTime(nullable: false),
                    KickoffTimeFormatted = c.String(),
                    TeamHomeScore = c.Int(nullable: false),
                    TeamAwayScore = c.Int(nullable: false),
                    WasHome = c.Boolean(nullable: false),
                    Round = c.Int(nullable: false),
                    TotalPoints = c.Int(nullable: false),
                    Value = c.Int(nullable: false),
                    TransfersBalance = c.Int(nullable: false),
                    Selected = c.Int(nullable: false),
                    TransfersIn = c.Int(nullable: false),
                    TransfersOut = c.Int(nullable: false),
                    LoanedIn = c.Int(nullable: false),
                    LoanedOut = c.Int(nullable: false),
                    Minutes = c.Int(nullable: false),
                    GoalsScored = c.Int(nullable: false),
                    Assists = c.Int(nullable: false),
                    CleanSheets = c.Int(nullable: false),
                    GoalsConceded = c.Int(nullable: false),
                    OwnGoals = c.Int(nullable: false),
                    PenaltiesSaved = c.Int(nullable: false),
                    PenaltiesMissed = c.Int(nullable: false),
                    YellowCards = c.Int(nullable: false),
                    RedCards = c.Int(nullable: false),
                    Saves = c.Int(nullable: false),
                    Bonus = c.Int(nullable: false),
                    Bps = c.Int(nullable: false),
                    Influence = c.String(),
                    Creativity = c.String(),
                    Threat = c.String(),
                    IctIndex = c.String(),
                    EaIndex = c.Int(nullable: false),
                    OpenPlayCrosses = c.Int(nullable: false),
                    BigChancesCreated = c.Int(nullable: false),
                    ClearancesBlocksInterceptions = c.Int(nullable: false),
                    Recoveries = c.Int(nullable: false),
                    KeyPasses = c.Int(nullable: false),
                    Tackles = c.Int(nullable: false),
                    WinningGoals = c.Int(nullable: false),
                    AttemptedPasses = c.Int(nullable: false),
                    CompletedPasses = c.Int(nullable: false),
                    PenaltiesConceded = c.Int(nullable: false),
                    BigChancesMissed = c.Int(nullable: false),
                    ErrorsLeadingToGoal = c.Int(nullable: false),
                    ErrorsLeadingToGoalAttempt = c.Int(nullable: false),
                    Tackled = c.Int(nullable: false),
                    Offside = c.Int(nullable: false),
                    TargetMissed = c.Int(nullable: false),
                    Fouls = c.Int(nullable: false),
                    Dribbles = c.Int(nullable: false),
                    Element = c.Int(nullable: false),
                    HistorySummaryFixture = c.Int(nullable: false),
                    OpponentTeam = c.Int(nullable: false),
                    PlayerInformationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformationId, cascadeDelete: true)
                .Index(t => t.PlayerInformationId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.HistorySummaries", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.HistoryPasts", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Histories", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.FixturesSummaries", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Fixtures", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Explains", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Explains", "ExplainFixture_Id", "dbo.ExplainFixtures");
            DropForeignKey("dbo.Stats", "ExplainFixture_Id", "dbo.ExplainFixtures");
            DropForeignKey("dbo.Stats", "YellowCards_Id", "dbo.YellowCards");
            DropForeignKey("dbo.YellowCards", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "YellowCards_Id", "dbo.YellowCards");
            DropForeignKey("dbo.Aways", "YellowCards_Id", "dbo.YellowCards");
            DropForeignKey("dbo.Stats", "Saves_Id", "dbo.Saves");
            DropForeignKey("dbo.Saves", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "Saves_Id", "dbo.Saves");
            DropForeignKey("dbo.Aways", "Saves_Id", "dbo.Saves");
            DropForeignKey("dbo.Stats", "RedCards_Id", "dbo.RedCards");
            DropForeignKey("dbo.RedCards", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "RedCards_Id", "dbo.RedCards");
            DropForeignKey("dbo.Aways", "RedCards_Id", "dbo.RedCards");
            DropForeignKey("dbo.Stats", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Stats", "PenaltiesSaved_Id", "dbo.PenaltiesSaveds");
            DropForeignKey("dbo.PenaltiesSaveds", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "PenaltiesSaved_Id", "dbo.PenaltiesSaveds");
            DropForeignKey("dbo.Aways", "PenaltiesSaved_Id", "dbo.PenaltiesSaveds");
            DropForeignKey("dbo.Stats", "PenaltiesMissed_Id", "dbo.PenaltiesMisseds");
            DropForeignKey("dbo.PenaltiesMisseds", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "PenaltiesMissed_Id", "dbo.PenaltiesMisseds");
            DropForeignKey("dbo.Aways", "PenaltiesMissed_Id", "dbo.PenaltiesMisseds");
            DropForeignKey("dbo.Stats", "OwnGoals_Id", "dbo.OwnGoals");
            DropForeignKey("dbo.OwnGoals", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "OwnGoals_Id", "dbo.OwnGoals");
            DropForeignKey("dbo.Aways", "OwnGoals_Id", "dbo.OwnGoals");
            DropForeignKey("dbo.Stats", "GoalsScored_Id", "dbo.GoalsScoreds");
            DropForeignKey("dbo.Stats", "Bps_Id", "dbo.Bps");
            DropForeignKey("dbo.Bps", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "Bps_Id", "dbo.Bps");
            DropForeignKey("dbo.Aways", "Bps_Id", "dbo.Bps");
            DropForeignKey("dbo.Aways", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Stats", "Bonus_Id", "dbo.Bonus");
            DropForeignKey("dbo.Stats", "Assists_Id", "dbo.Assists");
            DropForeignKey("dbo.Assists", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Homes", "Assists_Id", "dbo.Assists");
            DropForeignKey("dbo.Homes", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.ExplainFixtures", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.Explains", "ExplainDetails_Id", "dbo.ExplainDetails");
            DropForeignKey("dbo.ExplainDetails", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.ExplainDetails", "Minutes_Id", "dbo.Minutes");
            DropForeignKey("dbo.Minutes", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.ExplainDetails", "GoalsScored_Id", "dbo.GoalsScoreds");
            DropForeignKey("dbo.GoalsScoreds", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.ExplainDetails", "CleanSheets_Id", "dbo.CleanSheets");
            DropForeignKey("dbo.CleanSheets", "PlayerInformationId", "dbo.PlayerInformations");
            DropForeignKey("dbo.ExplainDetails", "Bonus_Id", "dbo.Bonus");
            DropForeignKey("dbo.Bonus", "PlayerInformationId", "dbo.PlayerInformations");
            DropIndex("dbo.HistorySummaries", new[] { "PlayerInformationId" });
            DropIndex("dbo.Histories", new[] { "PlayerInformationId" });
            DropIndex("dbo.FixturesSummaries", new[] { "PlayerInformationId" });
            DropIndex("dbo.Fixtures", new[] { "PlayerInformationId" });
            DropIndex("dbo.YellowCards", new[] { "PlayerInformationId" });
            DropIndex("dbo.Saves", new[] { "PlayerInformationId" });
            DropIndex("dbo.RedCards", new[] { "PlayerInformationId" });
            DropIndex("dbo.PenaltiesSaveds", new[] { "PlayerInformationId" });
            DropIndex("dbo.PenaltiesMisseds", new[] { "PlayerInformationId" });
            DropIndex("dbo.OwnGoals", new[] { "PlayerInformationId" });
            DropIndex("dbo.Aways", new[] { "YellowCards_Id" });
            DropIndex("dbo.Aways", new[] { "Saves_Id" });
            DropIndex("dbo.Aways", new[] { "RedCards_Id" });
            DropIndex("dbo.Aways", new[] { "PenaltiesSaved_Id" });
            DropIndex("dbo.Aways", new[] { "PenaltiesMissed_Id" });
            DropIndex("dbo.Aways", new[] { "OwnGoals_Id" });
            DropIndex("dbo.Aways", new[] { "Bps_Id" });
            DropIndex("dbo.Aways", new[] { "PlayerInformationId" });
            DropIndex("dbo.Bps", new[] { "PlayerInformationId" });
            DropIndex("dbo.Homes", new[] { "YellowCards_Id" });
            DropIndex("dbo.Homes", new[] { "Saves_Id" });
            DropIndex("dbo.Homes", new[] { "RedCards_Id" });
            DropIndex("dbo.Homes", new[] { "PenaltiesSaved_Id" });
            DropIndex("dbo.Homes", new[] { "PenaltiesMissed_Id" });
            DropIndex("dbo.Homes", new[] { "OwnGoals_Id" });
            DropIndex("dbo.Homes", new[] { "Bps_Id" });
            DropIndex("dbo.Homes", new[] { "Assists_Id" });
            DropIndex("dbo.Homes", new[] { "PlayerInformationId" });
            DropIndex("dbo.Assists", new[] { "PlayerInformationId" });
            DropIndex("dbo.Stats", new[] { "ExplainFixture_Id" });
            DropIndex("dbo.Stats", new[] { "YellowCards_Id" });
            DropIndex("dbo.Stats", new[] { "Saves_Id" });
            DropIndex("dbo.Stats", new[] { "RedCards_Id" });
            DropIndex("dbo.Stats", new[] { "PenaltiesSaved_Id" });
            DropIndex("dbo.Stats", new[] { "PenaltiesMissed_Id" });
            DropIndex("dbo.Stats", new[] { "OwnGoals_Id" });
            DropIndex("dbo.Stats", new[] { "GoalsScored_Id" });
            DropIndex("dbo.Stats", new[] { "Bps_Id" });
            DropIndex("dbo.Stats", new[] { "Bonus_Id" });
            DropIndex("dbo.Stats", new[] { "Assists_Id" });
            DropIndex("dbo.Stats", new[] { "PlayerInformationId" });
            DropIndex("dbo.ExplainFixtures", new[] { "PlayerInformationId" });
            DropIndex("dbo.Minutes", new[] { "PlayerInformationId" });
            DropIndex("dbo.GoalsScoreds", new[] { "PlayerInformationId" });
            DropIndex("dbo.CleanSheets", new[] { "PlayerInformationId" });
            DropIndex("dbo.Bonus", new[] { "PlayerInformationId" });
            DropIndex("dbo.ExplainDetails", new[] { "Minutes_Id" });
            DropIndex("dbo.ExplainDetails", new[] { "GoalsScored_Id" });
            DropIndex("dbo.ExplainDetails", new[] { "CleanSheets_Id" });
            DropIndex("dbo.ExplainDetails", new[] { "Bonus_Id" });
            DropIndex("dbo.ExplainDetails", new[] { "PlayerInformationId" });
            DropIndex("dbo.Explains", new[] { "ExplainFixture_Id" });
            DropIndex("dbo.Explains", new[] { "ExplainDetails_Id" });
            DropIndex("dbo.Explains", new[] { "PlayerInformationId" });
            DropIndex("dbo.HistoryPasts", new[] { "PlayerInformationId" });
            DropTable("dbo.HistorySummaries");
            DropTable("dbo.Histories");
            DropTable("dbo.FixturesSummaries");
            DropTable("dbo.Fixtures");
            DropTable("dbo.YellowCards");
            DropTable("dbo.Saves");
            DropTable("dbo.RedCards");
            DropTable("dbo.PenaltiesSaveds");
            DropTable("dbo.PenaltiesMisseds");
            DropTable("dbo.OwnGoals");
            DropTable("dbo.Aways");
            DropTable("dbo.Bps");
            DropTable("dbo.Homes");
            DropTable("dbo.Assists");
            DropTable("dbo.Stats");
            DropTable("dbo.ExplainFixtures");
            DropTable("dbo.Minutes");
            DropTable("dbo.GoalsScoreds");
            DropTable("dbo.CleanSheets");
            DropTable("dbo.Bonus");
            DropTable("dbo.ExplainDetails");
            DropTable("dbo.Explains");
            DropTable("dbo.PlayerInformations");
            DropTable("dbo.HistoryPasts");
        }
    }
}
