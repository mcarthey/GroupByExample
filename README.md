# GroupByExample
## Context
This class represents the equivalent of a DbContext and implements IDisposable so it can be used in the using() block in Program.cs

## Restaurant / Review
These models are the equivalent of the DbSet types (entities) that would be created in the database

## Program
Note that we are directly using the Context class, but in your program you might want to create a Repository class to wrap the Context.  
This would give you more flexibility in writing your business logic and keep it out of the Program.cs
