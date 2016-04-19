#!/usr/local/bin/perl
use CGI qw(:standard);
print header;
print start_html('Store Manager');
print"<h1> Viewing All Orders </h1>\n";

open(FH,"storeManagerItems.dat");

@data =<FH>;
close(FH);

print "<table border =\"2\">\n";
print"<tr> <th>Customer's First Name</th><th>Customer's Last Name</th><th>Item </th><th>Type</th><th>Cost</th><th>Quanity</th><th>Restriced</th><th>Approval</th></tr>\n";


foreach $info(@data)
{

 ($Variable,$Name,$Type,$Restricted,$Cost,$Quanity,$Approval,$Something,$somethingelse,$somethingmore) =
     split (/,/,$info);

 if($Variable eq "S")
 {
   print"<tr><td>$Name</td><td>$Type</td><td>$Restricted</td><td>$Cost<td>$Quanity</td><td>$Approval</td><td>$Something</td><td>$somethingelse</td></tr>\n";

}


}





