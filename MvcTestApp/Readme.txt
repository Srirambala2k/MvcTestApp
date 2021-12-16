1. Install the packages
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

2. Create DB and Table using SQL Management Studio

3. Create Model using Scaffole command, make sure that your DB name is correct in the below command

Scaffold-DbContext "Server=.\SQLEXPRESS;Database=School;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

4. Add CSS and JS files under wwwroot\css and wwwroot\js folder

5. Refer css and js files in _layout.cshtml file

6. To change the Table row color
// Odd row
table.dataTable.stripe tbody tr.odd, table.dataTable.display tbody tr.odd {      
        background-color: #2F5D83
    }

// Even row
table.dataTable.stripe tbody tr.even, table.dataTable.display tbody tr.even {        
        background-color: #A6D259
    }
    

    Colors:

#2F5D83 - Blue
#A6D259 - Green

Test
