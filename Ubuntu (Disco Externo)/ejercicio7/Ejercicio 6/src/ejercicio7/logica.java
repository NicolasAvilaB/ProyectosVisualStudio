/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio7;
import javax.swing.JTextField;
import javax.swing.JRadioButton;
/**
 *
 * @author Oscar Rodrigo
 */
public class logica {
    
    String texto1;
    
    String texto2;
    
    public void convertir(JTextField txt1,JTextField txt2,JRadioButton r1, JRadioButton r2)
    {
        
    
        
        if (r1.isSelected()==true)
        {
                                          
            this.texto1=txt1.getText();
            
               txt2.setText(texto1.toLowerCase());
        }
        
        if (r2.isSelected()==true)
        {
                   this.texto1=txt1.getText();
                        txt2.setText(texto1.toUpperCase());
        }
        
    }
    
    public void pasar_minusculas(JTextField txt1,JTextField txt2)
    {
        this.texto1=txt1.getText();
                   txt2.setText(texto1.toLowerCase());
    }
}
