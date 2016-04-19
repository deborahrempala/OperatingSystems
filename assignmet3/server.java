/**
 * Client program requesting current date from server.
 *
 * Figure 3.20
 *
 * @author Gagne, Galvin, Silberschatz
 * Operating System Concepts  - Eighth Edition
 */ 

import java.net.*;
import java.io.*;
import java.util.*;
public class server
{
	public static void main(String[] args)  {
		String name = " ";
		try {
			// this could be changed to an IP name or address other than the localhost
			Socket sock = new Socket("198.110.216.168",5011);
			InputStream in = sock.getInputStream();
			Scanner user_input = new Scanner(System.in);
			BufferedReader bin = new BufferedReader(new InputStreamReader(in));

			String line;
		//	while( (line = bin.readLine()) != null)
			line=bin.readLine();
				System.out.println(line);
				
				PrintWriter pout = new PrintWriter(sock.getOutputStream(), true);
				// write the Date to the socket
				System.out.println("What is Your Name?");
				name =user_input.next();
				pout.println("Your name is " + name);

				
				
			sock.close();
		}
		catch (IOException ioe) {
				System.err.println(ioe);
		}
	}
}
