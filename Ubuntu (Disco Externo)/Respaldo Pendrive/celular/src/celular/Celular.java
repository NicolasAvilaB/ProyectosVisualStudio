package celular;

/**
 *
 * @author seba
 */
public class Celular {
    
    private String estado;
    private int nivel_de_bateria;
    private String modelo;
    public int numero;
    public String destinatario;
    
    
    //constructor
    public Celular(int nivel_de_bateria, String modelo) {
        this.nivel_de_bateria = nivel_de_bateria;
        this.modelo = modelo;
    }
    

    //metodos y funciones

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
    
    
    
    
    
    
    
    
    
    
    public static void main(String[] args) {
        
    }
    
}
