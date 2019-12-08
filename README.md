<img src="https://raw.githubusercontent.com/yemrekeskin/DataCube/master/cube.png" width="50" height="50"> 

# DataCube

### EF Core Concepts

- Approaches
  - DatabaseFirst
  - CodeFirst
- Relationships
  - One-To-Many
  - One-To-One
  - Many-To-Many
- Conventions
  - Data Annotation
  - Fluent API
- Scenarios
  - Connected Scenario
  - Disconnected Scenario

### Installation from nuget

  - ``` Install-Package Microsoft.EntityFrameworkCore.SqlServer ```
  - ``` Install-Package Microsoft.EntityFrameworkCore.Design ```
  - ``` Install-Package Microsoft.EntityFrameworkCore.Tools ```

### EF Core Subjects


  
 

- Modeling
  - Including-Excluding Types
    - [NotMapped] or Ignore
  - Including-Excluding Properties
    - [NotMapped] or Ignore
  - Keys
    - By default Id or (typename)Id
    - [Key] .HasKey
  - Generated Value
    - Data Annotation
      - [DatabaseGenerated(DatabaseGeneratedOption.None)]
      - [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      - [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    - Fluent API
      - .ValueGeneratedNever();
      - .ValueGeneratedOnAdd();
      - .ValueGeneratedOnAddOrUpdate();
   - Required and Optional Properties
      - [Required] , .IsRequired()
   - Shadow Properties
- Data Seeding
- Manage Database 
  - Migration
     - Seperate Project
  - Scaffolding 
    - Generate entities from existing database
  
  
## Useful Links
- [https://docs.microsoft.com/en-us/ef/core](https://docs.microsoft.com/en-us/ef/core/)
- [https://www.learnentityframeworkcore.com](https://www.learnentityframeworkcore.com/)
- [https://entityframeworkcore.com](https://entityframeworkcore.com/)
- [https://www.entityframeworktutorial.net](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)

## Contribution
Pull requests are welcome, but make sure you sign the Contributor License Agreement.

## License

SwiftRefData is licensed under the MIT license. Check the [LICENSE](LICENSE) file for details.
