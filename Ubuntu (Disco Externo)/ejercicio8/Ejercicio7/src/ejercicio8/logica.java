/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio8;
import javax.swing.JTextField;
import javax.swing.JRadioButton;

/**
 *
 * @author Oscar Rodrigo
 */
public class logica {
    
   
    
    public void hexa(JTextField numero1,JTextField numero2, JRadioButton r1,JRadioButton r2,JRadioButton r3,JRadioButton r4)
    {
        if (r1.isSelected()==true)
        {
        String base=numero1.getText();
        if (r2.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,16);
            numero2.setText(Integer.toOctalString(numero));
            
        }
        if (r3.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,16);
            numero2.setText(Integer.toString(numero));
            
        }
        if (r4.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,16);
            numero2.setText(Integer.toBinaryString(numero));
            
        }
        
        
        
        
       
       }
        
    
}
    public void octa(JTextField numero1,JTextField numero2, JRadioButton r1,JRadioButton r2,JRadioButton r3,JRadioButton r4)
    {
        if (r1.isSelected()==true)
        {
        String base=numero1.getText();
        if (r2.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,8);
            numero2.setText(Integer.toHexString(numero));
            
        }
        if (r3.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,8);
            numero2.setText(Integer.toString(numero));
            
        }
        if (r4.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,8);
            numero2.setText(Integer.toBinaryString(numero));
            
        }
        
        
        
        
       
       }
        
    
}
    public void decimal(JTextField numero1,JTextField numero2, JRadioButton r1,JRadioButton r2,JRadioButton r3,JRadioButton r4)
    {
        if (r1.isSelected()==true)
        {
        String base=numero1.getText();
        if (r2.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,10);
            numero2.setText(Integer.toHexString(numero));
            
        }
        if (r3.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,10);
            numero2.setText(Integer.toOctalString(numero));
            
        }
        if (r4.isSelected()==true)
        {
            Integer numero=Integer.valueOf(base ,10);
            numero2.setText(Integer.toBinaryString(numero));
            
        }
        
        
        
        
       
       }
        
    
}
    public void binario(JTextField numero1,JTextField numero2, JRadioButton r1,JRadioButton r2,JRadioButton r3,JRadioButton r4)
    {
        if (r1.isSelected()==true)
        {
        String base=numero1.getText();
             if (r2.isSelected()==true)
           {
            Integer numero=Integer.valueOf(base ,2);
            numero2.setText(Integer.toHexString(numero));
            
           }
               if (r3.isSelected()==true)
               {
                Integer numero=Integer.valueOf(base ,2);
                 numero2.setText(Integer.toOctalString(numero));
            
               }
                  if (r4.isSelected()==true)
                 {
                   Integer numero=Integer.valueOf(base ,2);
                    numero2.setText(Integer.toString(numero));
            
                  }
                                
        }
        
}
    
    public void seleccion(JRadioButton r1,JRadioButton r2,JRadioButton r3,JRadioButton r4,JRadioButton r11,JRadioButton r22,JRadioButton r33,JRadioButton r44)
    {
        if (r1.isSelected()==true)
        {
            r11.setEnabled(false);
            
            r22.setEnabled(true);
            
            r33.setEnabled(true);
            
            r44.setEnabled(true);
            
        }
        if (r2.isSelected()==true)
        {
            r11.setEnabled(true);
            
            r22.setEnabled(false);
            
            r33.setEnabled(true);
            
            r44.setEnabled(true);
        }
        if (r3.isSelected()==true)
        {
            r11.setEnabled(true);
            
            r22.setEnabled(true);
            
            r33.setEnabled(false);
            
            r44.setEnabled(true);
        }
        if (r4.isSelected()==true)
        {
            r11.setEnabled(true);
            
            r22.setEnabled(true);
            
            r33.setEnabled(true);
            
            r44.setEnabled(false);
        }
    }
    
}
