#!/usr/local/bin/perl
use CGI qw(:standard);
print header;
print start_html('Store Manager');
print"<h1> Viewing All Items </h1>\n";

open(FH,"storeManagerItems.dat");

@data =<FH>;
close(FH);

print "<table border =\"2\">\n";
print"<tr> <th>Item Name</th><th>Item Type</th><th>Restriced</th><th>Cost</th><th>Quanity</th><th>Non-Muggle</th></tr>\n";


foreach $info(@data)
{

 ($Variable,$Name,$Type,$Restricted,$Cost,$Quanity,$Approval,$Something,$somethingelse,$somethingmore) =
     split (/,/,$info);
	
 if($Variable eq "I")
 {
   print"<tr><td>$Name</td><td>$Type</td><td>$Restricted</td><td>$Cost</td><td>$Quanity</td><td>$Approval</td></tr>\n";

}


}









print "</table>\n";
print end _html;







