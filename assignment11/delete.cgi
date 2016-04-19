#!/usr/local/bin/perl
 use CGI qw(:standard);
use File::Path;
 print header;
 print start_html ('Delete');
$pass = param('password');
$user = param('username');
$path = "data/$user";
 if( $pass eq "dcr1114")
{

  rmtree($path);

}
  
else 
{

 print "you suck";
}




print end_html;
