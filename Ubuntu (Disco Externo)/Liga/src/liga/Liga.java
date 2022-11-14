/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package liga;

/**
 *
 * @author seba
 */
public class Liga {
    protected String nclub, descripcion,plantilla;
    protected int fnaci,nlibertadores,nsudamericana,nchileno,
            nchile;
    
    public Liga(){
        this.nclub = "O´higgins";
        this.fnaci = 1925;
        this.nlibertadores = 1;
        this.plantilla = "portero: Don Ramon,  "
                + " Defensas: Godines , El Chavo , ÑOÑO , KIKO"
                + " Mediocampistas: Chilindrina , Paty , POPis"
                + " Delanteros: Profesor Jirafales , Señor Barriga , Don Jaimito";
        this.descripcion = "club formado por ex jugadores de magallanes comandados por Chespirito,"
                + "ex capitan del club de la bandita, lo cual formó el primer clásico de la historia chilena."
                + "Chespirito murió en 1927 jugando por los albos en España en pleno de un partido amistoso, por eso la franja negra "
                + "en la camiseta actual del cacique en señal de luto. " ;
        this.nchileno = 2583;
    }
   
    
    public Liga(String nclub,int fnaci,int nlibertadores,int nsudamericana,
            int nchileno,int nchile,String plantilla,String descripcion){
       
        nclub = "Club Social O´higgins";
        fnaci = 1925;
        nlibertadores = 1;
        nsudamericana = 0;
        nchileno = 16;
        nchile = 10;
        plantilla = "portero: Don Ramon , "
                + " defensas:Godines ,  El Chavo , ÑOÑO , KIKO"
                + " mediocampistas: Chilindrina , Paty , POPis"
                + " delanteros: Profesor Jirafales , Señor Barriga , Don Jaimito";
        descripcion = "club formado por ex jugadores de magallanes comandados por Chespirito,"
                + "ex capitan del club de la bandita, lo cual formó el primer clásico de la historia chilena."
                + "Chespirito murió en 1927 jugando por los albos en España en pleno de un partido amistoso, por eso la franja negra "
                + "en la camiseta actual del cacique en señal de luto. " ;
    }
    public String getNombre_club() {
        return nclub;
    }

    public void setNombre_club(String nclub) {
        this.nclub = nclub;
    }

    public int getFecha_nacimiento() {
        return fnaci;
    }

    public void setFecha_nacimiento(int fnaci) {
        this.fnaci = fnaci;
    }

    public int getNumero_libertadores() {
        return nlibertadores;
    }

    public void setNumero_libertadores(int nlibertadores) {
        this.nlibertadores = nlibertadores;
    }

    public int getNumero_sudamericana() {
        return nsudamericana;
    }

    public void setNumero_sudamericana(int nsudamericana) {
        this.nsudamericana = nsudamericana;
    }

    public int getNumero_campeonato_chileno() {
        return nchileno;
    }

    public void setNumero_campeonato_chileno(int nchileno) {
        this.nchileno = nchileno;
    }

    public int getNumero_copa_chile() {
        return nchile;
    }

    public void setNumero_copa_chile(int nchile) {
        this.nchile = nchile;
    }
    
    /**
     * @param args the command line arguments
     */
    
    
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
}
