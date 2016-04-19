/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaserver;
import java.net.*;
import java.io.*;

/**
 *
 * @author Deborah
 */
public class Javaserver {

    /**
     * @param args the command line arguments
     */
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
		
        
        // TODO code application logic here
    }
    
}
