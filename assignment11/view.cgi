#!/usr/local/bin/perl
use CGI qw(:standard);
use URI::Escape qw( uri_escape );

print header;
print start_html('Student Webpage');
$user = param('user');
open(FH,"data/$user/user.dat");
@data = <FH>;
chomp @data;
close (FH);
$font =$data[3];
$lcolor =$data[4];
$bg =  $data[2];
print "<html>";
print "<style>";
print "a:link{color:$lcolor } ";
print "</style>";
print "</html>";
print "<body bgcolor='$bg'>";
print "<center><h1><font color ='$font'>Welcome to $data[0] $data[1]'s Web Page!</font></h1>\n</center>";

print"<h1><font color ='$font'> My Favorite Links </font></h1> \n";
$link1 = $data[5];
$link2 = $data[6];
$link3 = $data[7];

print "<h3><p> <a href =' //$link1'>$link1 </a></font>\n</p>";
print "<p> <a href = '//$link2'>$link2 </a></font>\n</p>";
print "<p> <a href = '//$link3'>$link3 </a></font>\n</p></h3>";


print"<h1><font color ='$font'> My Favorite Pictures</font></h1> \n";
$pic1 = $data[8];
$pic2 = $data[9];
$pic3 = $data[10];
print "<img src=data/$user/$pic1><p>\n"; 
print "<img src=data/$user/$pic2><p>\n";
print "<img src=data/$user/$pic3><p>\n";



#print "Content-type: image/jpeg\n\n";


$email =$data[8];
$realemail = "mailto:" .$email;
print "<p><a href ='$realemail' ><font color = '$font'> Email Me!</font></a></p>"; 

























print end_html;
