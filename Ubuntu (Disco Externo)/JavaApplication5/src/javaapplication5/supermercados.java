/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication5;

/**
 *
 * @author nicolas
 */
public class supermercados {
    protected  String NombreProducto;
    protected String Categoria; 
    protected String NombreDestinatario;

    protected  String NombreProducto2;
    protected String Categoria2; 
    protected String NombreDestinatario2;
 
    protected  String NombreProducto3;
    protected String Categoria3; 
    protected String NombreDestinatario3;
  
  
    
public supermercados(){
    this.NombreProducto = "Libro1: Pet Sematary";
        this.Categoria = "Terror";
        this.NombreDestinatario = "Stephen King";
        
           this.NombreProducto2 = "Libro2: La Guerra de los Mundos";
        this.Categoria2 = "Terror";
        this.NombreDestinatario2 = "Stephen Spielberg";
           
        this.NombreProducto3 = "Cinema1: Terminator X";
        this.Categoria3 = "Accion";
        this.NombreDestinatario3 = "James Cameron";
        
}
    
    public supermercados (String NombreProducto, String Categoria, String NombreDestinatario)
    {
        this.NombreProducto = "Libro1: Pet Sematary";
        this.Categoria = "Terror";
        this.NombreDestinatario = "Stephen King";
        
        this.NombreProducto2 = "Libro2: La Guerra de los Mundos";
        this.Categoria2 = "Terror";
        this.NombreDestinatario2 = "Stephen Spielberg";
           
        this.NombreProducto3 = "Cinema1: Terminator X";
        this.Categoria3 = "Accion";
        this.NombreDestinatario3 = "James Cameron";
        
    }
    public String getNombreProductos()
    {
        return NombreProducto;
    }
     public String getCategorias()
    {
        return Categoria;
    }
      public String getNombreDestinatario()
    {
        return NombreDestinatario;
    }
    public void setNombreProducto(String NombreProducto)
    {
        this.NombreProducto = NombreProducto;
    }
    public void setCategorias(String Categoria)
    {
        this.Categoria = Categoria;
    }
    public void setNombreDestinatario(String NombreDestinatario)
    {
        this.NombreDestinatario = NombreDestinatario;
    }
}

