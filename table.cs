

using System.Data.SQLite;

//Creating a database file
string cs = @"URI=file:C:\Users\Helena MacNeary\Desktop\c# work\test.db";


using var con = new SQLiteConnection(cs);
con.Open();

using var cmd = new SQLiteCommand(con);

//creating a table
cmd.CommandText = @"CREATE TABLE users
        (
        forename text,
        surname text,
        score integer
        ) ";
cmd.ExecuteNonQuery();

//Insert data
cmd.CommandText = "INSERT INTO users VALUES ('Wayne', 'Hemsley', 3)";
cmd.ExecuteNonQuery();
cmd.CommandText = "INSERT INTO users VALUES ('Tom', 'Costall', 20)";
cmd.ExecuteNonQuery();
cmd.CommandText = "INSERT INTO users VALUES ('John', 'Stall', 28)";
cmd.ExecuteNonQuery();

