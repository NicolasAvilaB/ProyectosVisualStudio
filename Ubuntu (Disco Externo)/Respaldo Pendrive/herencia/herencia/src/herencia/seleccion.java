/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package herencia;

/**
 *
 * @author aiep
 */
public class seleccion 
{
    protected String nombre;
    protected String apellidos;
    protected int edad;
    
    protected String tipo_integrante;
    
    public seleccion()
    {
        
    }
           
    // constructor
    public seleccion(String nombre, String apellidos, int edad) 
    {
    	this.nombre = nombre;
	this.apellidos = apellidos;
	this.edad = edad;
    }
    
    public void setintegrante(String tipo)
    {
        this.tipo_integrante=tipo;
    }    
    
    public String getintegrante()
    {
        return this.tipo_integrante;
    }    

    public String getNombre() {
        return nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public int getEdad() {
        return edad;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }
    
   
}

