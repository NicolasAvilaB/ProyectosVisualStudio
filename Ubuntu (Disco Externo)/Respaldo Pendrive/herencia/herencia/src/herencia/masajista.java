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
public class masajista extends seleccion 
{

    private String titulo;
    private int años_experiencia;

    public masajista()
    {
        
    }
    
    public masajista(String nombre, String apellidos, int edad, String titulo, int años_experiencia) 
    {
        super(nombre, apellidos, edad);
        this.titulo = titulo;
        this.años_experiencia = años_experiencia;
    }

    public String getTitulo() {
        return titulo;
    }

    public int getAños_experiencia() {
        return años_experiencia;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public void setAños_experiencia(int años_experiencia) {
        this.años_experiencia = años_experiencia;
    }

}
