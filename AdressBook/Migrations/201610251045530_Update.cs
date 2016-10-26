namespace AdressBook.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class Update : DbMigration
	{
		public override void Up()
		{
			AlterColumn("dbo.People", "Birthday", c => c.DateTime(nullable: false, storeType: "date"));
		}

		public override void Down()
		{
			AlterColumn("dbo.People", "Birthday", c => c.DateTime(nullable: false));
		}
	}
}