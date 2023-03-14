# rdlc_dotnet7
Experimenting with getting rdlc working in a dotnet 7 winforms application and displaying data from an Oracle database

## 11/3/2023
I have spent a lot of time in the past getting applications to produce embedded reports using the ReportViewer and RDLC format report definitions, 
but not for years and using the framework, pre-dotnetcore.  I even wrote an application for generating the rdlc files for tabular reports based on 
a data table, which itself was created from an SQL statement, the report layout was based on the shape of the data in the data table.

The ReportViewer appears to have been abandonned by Microsoft, and when I discovered that there was a nuget package I thought lets have a play with it.

I found a YouTube video https://www.youtube.com/watch?v=Ul6r0GZXgsg where the various bugs and work arounds were shown to the point where a report was 
produced, that helped, but it was just the start of the journey.  The ReportViewerCore control doesn't seem to be properly integrated into the Visual 
Studio Designer, but you dont really need it to be there at design time anyway, it can be added in code at run time.

This project is split into a number of examples
### ex1 
- explains about installing the RDLC Report Designer Extension
- installing the ReportViewerCore.Winforms nuget extension
- getting the control to display in the designer
- and then how to get it to show up at run time
### ex2
- extends this to show a table being added and configured at design time
- and then some hard coded data being displayed at run time
### ex3
- extends this again to display some random data pulled out of an Oracle database
- the Oracle.ManagedDataAccess.Core nuget package has to be installed and then some code to connect to the database and issue a select query

I chose Oracle because that is my background, thats what I have installed on my machine and there are already loads of examples on line for SQL 
Server.  You will need to have access to an Oracle Server for this to work.  There is a free Oracle XE database download available online.  My personal 
preference is for version 11g, I missed out on 18c and now 21c, I have looked at 21c and it is structured different internally which I haven't got a
handle on yet, 11g is pretty straight forward in an "it just works" sense, Oracle have hidden the links to the 11g download, you will have to register 
to download it but it is here:

https://www.oracle.com/database/technologies/xe-prior-release-downloads.html


The column names of the Oracle data has to match the column names in the DataSet that was used for the report in the designer.

The conventional way to bind the report to the database object would be to connect to the database in the Server Explorer, then find the table or 
view with the columns you want to display in the report, I would create a view in the database then use that to do the designer part, then once the 
report was there I would drop the view and delete any additional things like DataSets that were created in the project, 

### ex4
- shows how to add the control at run time bypassing all the designer bugs

