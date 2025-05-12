# How to setup DbContext in project

- First of all, we have to install few packages like Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools and Microsoft.EntityFrameworkCore.Design
- Then, create a "Data" folder 
- Create a file AppDbContext.cs in it
- Inherit DbContext class: DbContext provides all the methods and properties needed to query the database, track changes, and save data
- Create constructor in this class
- Now we would have to create connection string in program.cs file 
- Then we would have to create service in program.cs file to add DbContext for the provided connection string
- Then, we would have to pass this options data to AppDbContext.cs file and then passing that data to DbContext.cs file's constructor. So, basically we have to pass data from child contructor to parent constructor, so we have to use base() function

# Migration process

- Firstly we have to create a model or class file for particular database (Here - Data/Book.cs)
- Then, we have to indicate DB Context that a new table needs to be created (Here - ApDbContext.cs - public DbSet<Book> Books { get; set; })
- Next, we have to create a migration using:
```bash
Add-Migration InitDb
```
- Till now we have just created the migrations but not applied them yet. So, next we have to apply migration as
```bash
Update-Database
```
