  using Mocha2023.Classes.DBs.Postgres;

    namespace _107q.Classes.DBs
{
 public static class ReportsDB
    {
    public static readonly PostgresCollection<PlayerReport> PlayerReports = new(  _101q.ConnectionString,
 tableName: "player_reports",
	idColumn: "id",
 idSelector: r => r.Id,
  extraColumns: new (string, Func<PlayerReport, object?>)[]
        {
        ("status", r => r.Status),
 ("created_at", r => r.CreatedAt),
  ("reported_player_id", r => r.ReportedPlayerId)
	});

  public static readonly PostgresCollection<BugReport> BugReports = new(
	PostgresConfig.ConnectionString,
tableName: "bug_reports",
        idColumn: "id",
		idSelector: r => r.Id,     extraColumns: new (string, Func<BugReport, object?>)[]
		{
  ("status", r => r.Status),
    ("created_at", r => r.CreatedAt)
    });

        static ReportsDB()
 {
        PlayerReports.EnsureIndex("status");
		PlayerReports.EnsureIndex("created_at");
	PlayerReports.EnsureIndex("reported_player_id");
        BugReports.EnsureIndex("status");
  BugReports.EnsureIndex("created_at");
        }

	public static int MigrateFromLiteDb()
		{
        string path = Path._(Program.dataDir, "DBs", "Reports.db");
if (!File.Exists(path))
 return 0;

	using var db = new LiteDB.LiteDatabase($"Filename={path};Connection=shared;ReadOnly=true");
  int count = 0;
 foreach (LiteDB.BsonDocument doc in db._102q("PlayerReports")._100q())
    {
    PlayerReports.Upsert(LiteDbMigrationTool._103x<PlayerReport>(doc, "Id"));
		count++;
  }
        foreach (LiteDB.BsonDocument doc in db.GetCollection("BugReports")._100q())
  {
 BugReports.Upsert(LiteDbMigrationTool.ReadWithRecoveredId<BugReport>(doc, "Id"));
 count++;
}
return count;
}

	public class PlayerReport
  {
	public Guid Id { get; set; } = Guid.NewGuid();

    public long ReporterId { get; set; }
	public string? ReporterUsername { get; set; }   public long? ReportedPlayerId { get; set; }
public string? ReportedUsername { get; set; }
		public int? ReportCategory { get; set; }         public string? Details { get; set; }
  public long? _104q { get; set; }
 public string? RoomInstanceType { get; set; }
public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string Status { get; set; } = "Pending";

  public long? ResolvedByAccountId { get; set; }         public string? ResolvedByUsername { get; set; }
		public DateTime? ResolvedAt { get; set; }
        public string? ResolutionNote { get; set; }
    public int? ActionDurationSeconds { get; set; } 		}

        public class BugReport
    {
  public Guid Id { get; set; } = Guid.NewGuid();

public long ReporterId { get; set; }
		public string? ReporterUsername { get; set; }
 public string? Description { get; set; }
 public string? _105x { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string Status { get; set; } = "Open";

  public long? ResolvedByAccountId { get; set; }
    public string? ResolvedByUsername { get; set; }
  public DateTime? ResolvedAt { get; set; }
    }
        }
    }
