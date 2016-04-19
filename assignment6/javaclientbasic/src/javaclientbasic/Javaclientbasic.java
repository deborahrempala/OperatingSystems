
package javaclientbasic;
import java.net.*;
import java.io.*;
import java.util.*;

public class Javaclientbasic {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        String name = " ";
		try {
			// this could be changed to an IP name or address other than the localhost
			Socket sock = new Socket("35.58.20.10",6016);
			InputStream in = sock.getInputStream();
			Scanner user_input = new Scanner(System.in);
			BufferedReader bin = new BufferedReader(new InputStreamReader(in));

			String line;
		//	while( (line = bin.readLine()) != null)
			line=bin.readLine();
				System.out.println(line);
				
				
				// write the Date to the socket
				
				
				
			sock.close();
		}
		catch (IOException ioe) {
				System.err.println(ioe);
		}
        
        
    }
    
}
