/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package conexion_simple;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;

/**
 *
 * @author aiep
 */
public class conexion1 
{
    private String server;
    private String user;
    private String pass;
    private Connection conexion2; //la cadena de conexion1
   
    
    public void datos_conexion(String server, String user, String pass)
    {
        this.user=user;
        this.pass=pass;
        this.server=server;
        
    }
    
     public void driver(String driver)
    {
        try
        {
            Class.forName(driver); 
        
        }
        catch(ClassNotFoundException ex)
        {
            JOptionPane.showMessageDialog(null,"ERROR","Error en la Conexión con la BD "+ex.getMessage(),JOptionPane.ERROR_MESSAGE);
            conexion2=null;
        

        }
    
    }
    
    public void conectar()
    {
        Connection conectar=null;
        try
        {
            conexion2= DriverManager.getConnection(server,user,pass);
            JOptionPane.showMessageDialog(null,"CONEXION EXITOSA A SERVIDOR: "+this.server);
        }
        catch(SQLException ex)
        {
            JOptionPane.showMessageDialog(null, "Error SQL en la Conexión con la BD "+ex.getMessage(),"ERROR", JOptionPane.ERROR_MESSAGE);
            conexion2=null;
            
        }
      
    }
    
    public void desconectar()
    {
        try
        {
            conexion2.close();
            conexion2=null;
            
        }
        catch(SQLException ex)
        {
            JOptionPane.showMessageDialog(null,"Error en la Desconexion con la BD "+ex.getMessage(), "ERROR" ,JOptionPane.ERROR_MESSAGE);
            conexion2=null;
            
        
        }
        
    }

    void insertData(String tienda, String text, String text0, String text1, String text2) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    Statement createStatement() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    PreparedStatement PrepareStatement(String insert_into_productoscodprodesproprepro_V) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    Connection conexio() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    conexion1() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

   

    Connection conexion2() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
 
    
}

