#include <iostream>
#include <cmath>
#include <fstream>
#include <cstring>
using namespace std;

int main()
{
ifstream input;
ofstream output;
string line;
char check[81];

int casnum =0;
int ws =0;
int vowel =0;
int consts = 0;
int punct =0;


input.open("prob2.in");
output.open("prob2.out");
 while (getline( input, line ))  
      {
      
for (int i = 0; i < line.length(); i++){
   	 check[i] = line[i];
   	 consts ++;
   	 if(check[i]== ' ')
   	 {
		
   	 ws++;
   	 consts = consts - 1;
   	 
   }
   	  if(check[i]== 'a' )
   	  {
		 
   	 vowel++;
   	 consts = consts - 1;
   }
   if(check[i]== 'A' )
   {
   
   	 vowel++;
   	consts = consts - 1;
   }
   
   
   	  if(check[i]== 'e' )
   	  {
		 
   	 vowel++;
   	 consts = consts - 1;
   }
   if(check[i]== 'E' )
   {
   
   	 vowel++;
   	 consts = consts - 1;
   }
   	  if(check[i]== 'i' )
   	  {
   
   	 vowel++;
   	 consts = consts - 1;
   }
   if(check[i]== 'I' )
   	  {
   
   	 vowel++;
   	 consts = consts - 1;
   }
   	  if(check[i]== 'o' )
   	  {
   
   	 vowel++;
   	 consts = consts - 1;
   }
   if(check[i]== 'O' )
   	 {
   
   	 vowel++;
   	 consts = consts - 1;
   }
   	  if(check[i]== 'u' )
    {
   
   	 vowel++;
   	 consts = consts - 1;
   }
   if(check[i]== 'U' )
   	 {
   
   	 vowel++;
   	 consts = consts - 1;
   }
   	 
   	  if(check[i]== '.' )
   	  {
   
   	 punct++;
   	 consts = consts - 1;
   }
   	  if(check[i]== '!' )
   	 	  {
   
   	 punct++;
   	 consts = consts - 1;
   }
   if(check[i]== '?' )
   	 	  {
   
   	 punct++;
   	 consts = consts - 1;
   }
   	  if(check[i]== ',' )
   	 	  {
   
   	 punct++;
   	 consts = consts - 1;
   }
   if(check[i]== ':' )
   		  {
   
   	 punct++;
   	 consts = consts - 1;
   }


}

   
 casnum ++;
	output<<"Case "<<casnum<<": " <<vowel<<" "<<consts<<" "<<ws<<" "<<punct<<endl;
	ws =0;
 vowel =0;
consts = 0;
 punct =0;

}
input.close();
output.close();


}
