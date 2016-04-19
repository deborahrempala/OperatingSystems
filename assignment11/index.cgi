#!/usr/local/bin/perl

use CGI qw(:standard);
print header;
print start_html('Boger Elementary School');
print "<h1><font color='blue' size ='30'>Boger Elementary School Web Pages</font></h1>\n";

opendir (STUFF , "data");
while(defined ($file = readdir(STUFF)))
				    {
			if($file && !($file eq ".") && !($file eq ".."))
				{
					open DIR, "data/$file/user.dat";
					@list = <DIR>;
					chomp(@list);
					print "<h2>$list[0] $list[1] <\h2> \n";
					print "<p> <a href = \"view.cgi?user=$file\"> View Page </a> &nbsp; &nbsp; 
					 <a href =\"edit.cgi?user=$file\" value = \"$file\"> Edit Page </a></p>\n";
                                }
				    }
print "<h3>To create your very own page, just <a href=\"new.html\">Enter here.</a></h3>\n";
print "<h3>Delete directory <a href=\"delete.html\">Delete</a></h3>\n";




closedir(STUFF);







print end_html;
