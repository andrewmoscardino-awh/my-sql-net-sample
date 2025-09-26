# MySQL .NET Sample Application

This repo contains a simple application to demonstrate an error with the Devart dotConnect MySQL EF Core library.

## Running

1. Create a file in the repo root called `devart.key` and put the license key in that file.
2. Create an empty MySQL database and run the `sample.sql` file to create the sample table and some data.
3. Update `MySQLSample/Program.cs` with your connection information (if necessary).
4. Run from the repo root: `dotnet run --project MySQLSample`
