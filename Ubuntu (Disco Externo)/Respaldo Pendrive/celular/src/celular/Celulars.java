package celular;

import javax.swing.JOptionPane;
import java.applet.AudioClip;

/**
 *
 * @author sebastian alvarez
 */
public class Celulars extends javax.swing.JFrame {

     Celular telefono = new Celular(90,"MOTOROLAS");
     Celulars reproducir = new Celulars();
      
     
    
    
    /**
     * Creates new form Celulars
     */
    public Celulars() {
     
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        BTNLLAMAR = new javax.swing.JButton();
        lblTelefono = new javax.swing.JLabel();
        BTNAPAGAR = new javax.swing.JButton();
        BTNENCENDIDO = new javax.swing.JButton();
        pantalla = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        BTNCOLGAR = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setBackground(java.awt.Color.black);
        setFocusable(false);

        BTNLLAMAR.setText("llamar");
        BTNLLAMAR.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BTNLLAMARActionPerformed(evt);
            }
        });

        lblTelefono.setText("   ");
        lblTelefono.setOpaque(true);

        BTNAPAGAR.setText("APAGAR");
        BTNAPAGAR.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BTNAPAGARActionPerformed(evt);
            }
        });

        BTNENCENDIDO.setText("ENCENDER");
        BTNENCENDIDO.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BTNENCENDIDOActionPerformed(evt);
            }
        });

        pantalla.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                pantallaActionPerformed(evt);
            }
        });

        jButton1.setText("Mensaje");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        BTNCOLGAR.setText("COLGAR");
        BTNCOLGAR.setEnabled(false);
        BTNCOLGAR.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BTNCOLGARActionPerformed(evt);
            }
        });

        jButton2.setText("Reproductor");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(BTNLLAMAR, javax.swing.GroupLayout.PREFERRED_SIZE, 105, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 132, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(35, 35, 35)
                        .addComponent(jButton2, javax.swing.GroupLayout.PREFERRED_SIZE, 114, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(pantalla, javax.swing.GroupLayout.PREFERRED_SIZE, 301, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BTNCOLGAR, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(96, 96, 96)
                        .addComponent(BTNAPAGAR)
                        .addGap(18, 18, 18)
                        .addComponent(BTNENCENDIDO))
                    .addComponent(lblTelefono, javax.swing.GroupLayout.PREFERRED_SIZE, 225, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(23, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(BTNLLAMAR, javax.swing.GroupLayout.DEFAULT_SIZE, 35, Short.MAX_VALUE)
                    .addComponent(jButton1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButton2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(pantalla, javax.swing.GroupLayout.PREFERRED_SIZE, 316, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BTNCOLGAR, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblTelefono, javax.swing.GroupLayout.PREFERRED_SIZE, 29, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 56, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BTNAPAGAR)
                    .addComponent(BTNENCENDIDO))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BTNLLAMARActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BTNLLAMARActionPerformed
        JOptionPane.showInputDialog(null,"ingrese su numero para llamar");
        telefono.setEstado("Realizando llamada ...");
        pantalla.setText(telefono.getEstado());
        BTNCOLGAR.setEnabled(rootPaneCheckingEnabled);
        LLAMAR();
        
    }//GEN-LAST:event_BTNLLAMARActionPerformed
        public void LLAMAR()
    {
        reproducir.setVisible(true);
        AudioClip llamado;
        llamado = java.applet.Applet.newAudioClip(getClass().getResource("/celular/llamada.mp3"));
        llamado.play();
    }
    private void BTNENCENDIDOActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BTNENCENDIDOActionPerformed
         JOptionPane.showMessageDialog(null,"SU CELULAR HA SIDO ENCENDIDO ");
        BTNENCENDIDO.setVisible(false);
        telefono.setEstado("BIENVENIDO,Se ha encendido su celular" );
        pantalla.setText(telefono.getEstado());
        lblTelefono.setText(telefono.getModelo());
        
    }//GEN-LAST:event_BTNENCENDIDOActionPerformed

    private void BTNAPAGARActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BTNAPAGARActionPerformed
        pantalla.setText("CELULAR APAGADO ");
        lblTelefono.setText(" ");
        JOptionPane.showMessageDialog(null,"SU CELULAR SE HA APAGADO, BUEN DIA ");
        pantalla.setVisible(false);
        System.exit(0);
        
        
    }//GEN-LAST:event_BTNAPAGARActionPerformed

    private void BTNCOLGARActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BTNCOLGARActionPerformed
        JOptionPane.showMessageDialog(null,"llamada terminada");
        telefono.setEstado("**********llamada finalizada**********");
        pantalla.setText(telefono.getEstado());
        
    }//GEN-LAST:event_BTNCOLGARActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        JOptionPane.showInputDialog(null,"ingrese el numero"); 
        telefono.setEstado("**********mensaje enviado**********");
        pantalla.setText(telefono.getEstado());
    }//GEN-LAST:event_jButton1ActionPerformed

    private void pantallaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_pantallaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_pantallaActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
         
    }//GEN-LAST:event_jButton2ActionPerformed
    public static void main(String args[]) {
      
        
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Celulars.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Celulars.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Celulars.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Celulars.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BTNAPAGAR;
    private javax.swing.JButton BTNCOLGAR;
    private javax.swing.JButton BTNENCENDIDO;
    private javax.swing.JButton BTNLLAMAR;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel lblTelefono;
    private javax.swing.JTextField pantalla;
    // End of variables declaration//GEN-END:variables
}
