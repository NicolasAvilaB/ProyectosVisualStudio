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
 public class futbolista extends seleccion
 {
    private int dorsal;
    private String demarcacion;

    public futbolista() 
    {
        
    }
    
    public futbolista(String nombre, String apellidos, int edad, int dorsal, String demarcacion) 
    {
        super(nombre, apellidos, edad);
	this.dorsal = dorsal;
	this.demarcacion = demarcacion;
    }

    public int getDorsal() {
        return dorsal;
    }

    public String getDemarcacion() {
        return demarcacion;
    }

    public void setDorsal(int dorsal) {
        this.dorsal = dorsal;
    }

    public void setDemarcacion(String demarcacion) {
        this.demarcacion = demarcacion;
    }

    
    
        	
 }
    
