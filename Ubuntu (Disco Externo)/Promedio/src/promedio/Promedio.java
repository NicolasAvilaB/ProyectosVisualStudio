/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package promedio;

/**
 *
 * @author seba
 */
public class Promedio {
    
    public double promedio;
    public String labelAprobado;
    
    
    
    
    public double sacarPromedio(double nota1,double nota2,double nota3)
    {
        
        double promedio = (nota1 + nota2 + nota3) / 3;
       
        
        return promedio;
    }
    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
}
