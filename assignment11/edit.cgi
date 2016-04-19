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


print "<center><h1><font color ='purple'> Edit A Page!</font> </h1></center>";
print "<body bgcolor='black'>";
 print "<form action ='savepage.cgi' method ='post' enctype='multipart/form-data'>";

print "<p><font color ='white'> Enter Password: </font> <input type='textbox' name='password' />/n</p>";
 print "<form action ='savepage.cgi' method ='post' enctype='multipart/form-data'>";
 print "<h2><font color ='purple'>Basic Information</font> </h2>";
 print "<font color ='white'> First Name: </font> <input type='textbox' name='first' value ='$data[0]' />";
print "<font color ='white'> Last Name: </font> <input type='textbox' name='lastname' value = '$data[1]' />/n";
print "<font color ='white'> Email: </font> <input type='textbox' name='email' value ='$data[11]' />/n</p>";

print "<h2><font color ='purple'>WebSite Information</font> </h2>";
print "<font color ='white'> Link One: </font> <input type='textbox' name='link1' value ='$data[5]'/>";
print "<font color ='white'> Link Two: </font> <input type='textbox' name='link2' value='$data[6]' />/n";
print "<font color ='white'> Link Three: </font> <input type='textbox' name='link3' value='$data[7]'/>/n</p>";

print "<h2><font color ='purple'>Color Information</font> </h2>";
print "<font color ='white'> Background Color: </font> <input type='textbox' name='bcolor' value='$data[2]' />";
print "<font color ='white'> Text Color: </font> <input type='textbox' name='tcolor' value ='$data[3]'/>/n";
print "<font color ='white'> Link Color: </font> <input type='textbox' name='lcolor' value='$data[4]'/>/n</p>";

print "<h2><font color ='purple'>picture Information</font> </h2>";
print "<font color ='white'> Image 1: </font> <input type='file' name='pic1' value='$data[8]'/>/n</p>";
print "<font color ='white'> Image 2: </font> <input type='file' name='pic2' value='$data[9]'/>/n</p>";
print "<font color ='white'> Image 3: </font> <input type='file' name='pic3' value='$data[10]'/>/n</p>";

print "<input type ='submit' value='Save'>";

$checkpass = param('password');
$AB = 'dr';
 $pwd = crypt($checkpassword,$AB);
rmdir("data/$user/user.dat");
rmdir ("data/$user");
if( $pwd eq $data[9])

{
 
print"<h1><font color ='white'>  </h1></font>";


}
else
{


}


print end_html;
