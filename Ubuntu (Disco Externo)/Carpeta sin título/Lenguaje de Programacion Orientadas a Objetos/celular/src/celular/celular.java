/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package celular;
import javax.swing.JOptionPane;

/**
 *
 * @author aiep
 */
public class celular 
{
    //atributos
    private String estado; //estado en que se encuentra el celular (encendido o apagado)
    private int nivel_de_bateria; //almacena el valor de carga del celular
    private String modelo; //almacena el modelo (marca) del celular

    //constructor
    public celular(int nivel_de_bateria, String modelo) {
        this.nivel_de_bateria = nivel_de_bateria;
        this.modelo = modelo;
    }
   
    //metodos - funciones
    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
        
    }

    public int getNivel_de_bateria() {
        return nivel_de_bateria;
    }

    public String getModelo() {
        return modelo;
    }
    
    
    
    
    
    
    
}
