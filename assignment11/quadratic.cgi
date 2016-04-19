#!/usr/local/bin/perl
#solver
#Deborah Rempala
use Math::Complex;
use CGI qw(:standard);
print header;
print start_html('quadratic');
my  $a = param('avalue');
 my $b = param('bvalue');
 my $c = param('cvalue'); 

my $temp = (($b*$b) - (4*($a*$c)));


if($temp > 0)
{
	my $root1 = (-($b) + sqrt($temp)) / (2*$a);
     	my $root2 = (-($b) - sqrt($temp)) / (2*$a);
	print "<h1> ($a X^2) +  ($b X) + $c = 0  has exactly two roots: ";
       $root1 =  printf("%.2f", $root1);
        print " and " ;
       $root2 = printf("%.2f", $root2);
       print " . </h1>";
      print "<h1> Value A:  ";
 printf("%.2f",$a);
print "</h1>";
print "<h1> Value B:  ";
  printf("%.2f",$b);
print "</h1>";
print "<h1> Value C:  ";
 printf("%.2f",$c);
print "</h1>";

 
 

}
if($temp == 0)
{
  my $root1 = -$b /(2 * $a);
  my $root2 = -$b /( 2 * $a);

   print "<h1> ($a X^2) +  ($b X) + $c = 0  has exactly one root: ";
   $root1 =  printf("%.2f", $root1);
   print " . </h1>";

print "<h1> Value A:  ";
 printf("%.2f",$a);
print "</h1>";
print "<h1> Value B:  ";
 printf("%.2f",$b);
print "</h1>";
print "<h1> Value C:  ";
 printf("%.2f",$c);
print "</h1>";


}

if($temp <0)
 {   


        print "<h1> ( ";
          printf("%.2f",$a);
        print"X^2) + ";
          printf("%.2f",$b);
          print"X - ";
         printf("%.2f",$c);
        print"= 0 : has no real roots </h1>";

	print "<h1> Value A:  ";
	  printf("%.2f",$a);
	print "</h1>";
	print "<h1> Value B:  ";
	  printf("%.2f",$b);
	print "</h1>";
	print "<h1> Value C:  ";
	 printf("%.2f",$c);
	print "</h1>";

        
}

print end_html;
