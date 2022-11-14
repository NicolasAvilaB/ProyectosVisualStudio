/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package liga;

/**
 *
 * @author nicolas
 */
public class Liga2 {
     protected String nclub, descripcion,plantilla;
    protected int fnaci,nlibertadores,nsudamericana,nchileno,
            nchile;
    
    public Liga2(){
        this.nclub = "San Luis";
        this.fnaci = 2025;
        this.nlibertadores = 777;
        this.plantilla = "portero: Guanajuatoi "
                + " Defensas: Marcelo , pinilla , escarpelo , simba"
                + " Mediocampistas: el roboto , la volo , el mr who"
                + " Delanteros: Profesores , espinela , escar";
        this.descripcion = "club formado por ex jugadores de magallanes comandados por flacodens,"
                + "ex capitan del club de la bandita, lo cual formó el primer clásico de la historia chilena."
                + "Chespirito murió en 2028 jugando por los albos en España en pleno de un partido amistoso, por eso la franja negra "
                + "en la camiseta actual del cacique en señal de luto. " ;
        this.nchileno = 777;
    }
   
    
    public Liga2(String nclub,int fnaci,int nlibertadores,int nsudamericana,
            int nchileno,int nchile,String plantilla,String descripcion){
       
        nclub = "Club Social San Luis";
        fnaci = 2025;
        nlibertadores = 152;
        nsudamericana = 0;
        nchileno = 16;
        nchile = 10;
        plantilla = "Portero: Guanajuatoi "
                + " Defensas: Marcelo , pinilla , escarpelo , simba"
                + " Mediocampistas: el roboto , la volo , el mr who"
                + " Delanteros: Profesores , espinela , escar";
        descripcion = "club formado por ex jugadores de magallanes comandados por flacodens,"
                + "ex capitan del club de la bandita, lo cual formó el primer clásico de la historia chilena."
                + "Chespirito murió en 2028 jugando por los albos en España en pleno de un partido amistoso, por eso la franja negra "
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
}
