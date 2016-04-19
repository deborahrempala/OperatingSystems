#!/usr/local/bin/perl
use CGI qw(:standard);
print header;
print start_html('Store Manager');
print"<h1> Viewing All Employees </h1>\n";

open(FH,"storeManagerItems.dat");

@data =<FH>;
close(FH);

print "<table border =\"2\">\n";
print"<tr> <th>First Name</th><th>Last Name</th><th>Position</th><th>Rate</th></tr>\n";


foreach $info(@data)
{

 ($Variable,$Name,$Type,$Restricted,$Cost,$Quanity,$Approval,$Something,$somethingelse,$somethingmore) =
     split (/,/,$info);

 if($Variable eq "E")
 {
   print"<tr><td>$Name</td><td>$Type</td><td>$Restricted</td><td>$Cost</tr>\n";

}


}









print "</table>\n";

