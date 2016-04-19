package assignment6;

import java.net.*;
import java.io.*;


public class assignment6 {


	public static void main(String[] args) {
	
		try {
		//	@SuppressWarnings("resource")
			ServerSocket sock = new ServerSocket(6016);
			
			while (true) {
				Socket client = sock.accept();
				
				PrintWriter pout = new PrintWriter(client.getOutputStream(),true);
				
		
				
				pout.println("you can't just change someone's name, joel!");
				
				client.close();
			}
			
		}
		 catch (IOException ioe){
			 System.err.println(ioe);
		 }
		

	}

}
