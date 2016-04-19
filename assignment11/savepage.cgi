#!/usr/local/bin/perl
$url = "http://tacosalad.lssu.edu/~drempala/csci434/assignment11";
print "Location: $url\n\n";
use CGI qw(:standard);
print header;
print start_html ('Save Confirmation');
# personal info
$firstname = param('first');
$lastnames = param('lastname');
$emails = param('email');
$password = param('pass');
$cpassword = param('cpass');
$AB = 'dr';
if ($password ne $cpassword) {
   print "<p><h1>Those passwords do not match</h1></p>\n";
  }
else
{
 $pwd = crypt($cpassword,$AB);
}

#website info
$backcolor = param('bcolor');
$linkcolor = param('lcolor');
$textcolor =param('tcolor');
$link1 = param('link1');
$link2 = param('link2');
$link3 = param('link3');
$username = substr(lc($firstname),0,1) .lc($lastnames);
mkdir "data/$username",0707;
open (FH,">data/$username/user.dat");

# picture info
	#photo 1
 my $file1 = param ('pic1');
 my $info1 = uploadInfo ($file1);
 my $type1 = $info1 -> {'Content-Type'};
@stuff1 = split(/\\/,$file1);
$new1 = $stuff1[$#stuff];
if ($file1) {
	open (UPLOAD, ">data/$username/$new1") || Error ();
	
	my ($data1, $length1, $chunk1);
	while ($chunk1 = read ($file1, $data1, 1024)) {
		print UPLOAD $data1;
		$length1 += $chunk1;
		if ($length1 > 500000) {
			print "That file is too big. The limit is 500K.";
			exit;
			}
		}
	close (UPLOAD);
     	
   	print "<p>You uploaded <b>$file1</b> which had a MIME type of <b>$type1</b>.";
       

} else {
		print "No file was chosen.";	}

# photo 2
my $file2 = param ('pic2');
my $info2 = uploadInfo ($file2);
my $type2 = $info2 -> {'Content-Type'};

@stuff2 = split(/\\/,$file2);
$new2 = $stuff2[$#stuff];

if ($file2) {
	open (UPLOAD, ">data/$username/$new2") || Error ();
	
	my ($data2, $length2, $chunk2);
	while ($chunk2 = read ($file2, $data2, 1024)) {
		print UPLOAD $data2;
		$length2 += $chunk2;
		if ($length2 > 500000) {
			print "That file is too big. The limit is 500K.";
			exit;
			}
		}
	close (UPLOAD);	
     print "<p>You uploaded <b>$file1</b> which had a MIME type of <b>$type1</b>.";


} else {
                print "No file was chosen.";    }

	
#photo 3
my $file3 = param ('pic3');
my $info3 = uploadInfo ($file3);
my $type3 = $info3 -> {'Content-Type'};

@stuff3 = split(/\\/,$file3);
$new3 = $stuff3[$#stuff];

if ($file3) {
        open (UPLOAD, ">data/$username/$new3") || Error ();

        my ($data3, $length3, $chunk3);
        while ($chunk3 = read ($file3, $data3, 1024)) {
                print UPLOAD $data3;
                $length3 += $chunk3;
                if ($length3 > 500000) {
                        print "That file is too big. The limit is 500K.";
                        exit;
                        }
                }
        close (UPLOAD);

     print "<p>You uploaded <b>$file1</b> which had a MIME type of <b>$type1</b>.";


} else {
                print "No file was chosen.";    }











print FH "$firstname\n";
print FH "$lastnames\n";
print FH "$backcolor\n";
print FH " $linkcolor\n";
print FH " $textcolor\n";
print FH "$link1\n";
print FH "$link2\n";
print FH "$link3\n";
print FH "$new1\n";
print FH "$new2\n";
print FH "$new3\n";
print FH "$emails\n";
print FH "$pwd\n";
close (FH);




print end_html;


