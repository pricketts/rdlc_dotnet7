# rdlc_dotnet7
Experimenting with getting rdlc working in a dotnet 7 winforms application

11/3/2023
---------
I have spent a lot of time in the past getting applications to produce embedded reports using the ReportViewer and RDLC format report definitions, 
but not for years and using the framework, pre-dotnetcore.  I even wrote an application for generating the rdlc files for tabular reports based on 
a data table, which itself was created from an SQL statement, the report layout was based on the shape of the data in the data table

The ReportViewer appears to have been abandonned by Microsoft, and when I discovered that there was a nuget package I thought lets have a play with it.

I found a YouTube video where the various bugs and work arounds were shown to the point where a report was produced

This project shows how to get the ReportViewer installed and "kinda" working, but taking this to the next level means hooking it up to some data, and 
that just doesn't seem to be working (yet)
