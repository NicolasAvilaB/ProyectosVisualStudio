/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio4;
import javax.swing.DefaultListModel;
/**
 *
 * @author nicolas
 */
public class Ejerc extends javax.swing.JFrame {
DefaultListModel par = new DefaultListModel();
DefaultListModel impares = new DefaultListModel();
DefaultListModel inversa = new DefaultListModel();
DefaultListModel primo = new DefaultListModel();
    /**
     * Creates new form Ejerc
     */
    public Ejerc() {
        initComponents();
        setLocationRelativeTo(null);
        setResizable(false);
        setTitle("Ingreso de Numeros");
        pares.setModel(par);
        impar.setModel(impares);
        nuinversa.setModel(inversa);
        nuprimo.setModel(primo);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        impares2 = new javax.swing.JTextField();
        impares3 = new javax.swing.JButton();
        jProgressBar1 = new javax.swing.JProgressBar();
        jLabel1 = new javax.swing.JLabel();
        pares1 = new javax.swing.JButton();
        num = new javax.swing.JTextField();
        impares1 = new javax.swing.JButton();
        numinversa = new javax.swing.JButton();
        numprimo = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        pares = new javax.swing.JList<>();
        restaurar = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        impar = new javax.swing.JList<>();
        jScrollPane3 = new javax.swing.JScrollPane();
        nuinversa = new javax.swing.JList<>();
        jScrollPane4 = new javax.swing.JScrollPane();
        nuprimo = new javax.swing.JList<>();

        impares3.setFont(new java.awt.Font("Ubuntu Light", 1, 15)); // NOI18N
        impares3.setText("Impares");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Ubuntu Light", 1, 15)); // NOI18N
        jLabel1.setText("Indica tu Numero");

        pares1.setFont(new java.awt.Font("Ubuntu Light", 1, 15)); // NOI18N
        pares1.setText("Pares");
        pares1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                pares1ActionPerformed(evt);
            }
        });

        impares1.setFont(new java.awt.Font("Ubuntu Light", 1, 15)); // NOI18N
        impares1.setText("Impares");
        impares1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                impares1ActionPerformed(evt);
            }
        });

        numinversa.setFont(new java.awt.Font("Ubuntu Light", 1, 15)); // NOI18N
        numinversa.setText("Numero Inversa");
        numinversa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                numinversaActionPerformed(evt);
            }
        });

        numprimo.setFont(new java.awt.Font("Ubuntu Light", 1, 15)); // NOI18N
        numprimo.setText("Numeros Primos");
        numprimo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                numprimoActionPerformed(evt);
            }
        });

        jScrollPane1.setViewportView(pares);

        restaurar.setFont(new java.awt.Font("Ubuntu Light", 1, 15)); // NOI18N
        restaurar.setText("Restaurar");
        restaurar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                restaurarActionPerformed(evt);
            }
        });

        jScrollPane2.setViewportView(impar);

        jScrollPane3.setViewportView(nuinversa);

        jScrollPane4.setViewportView(nuprimo);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(226, 226, 226)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 228, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(119, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                            .addComponent(pares1, javax.swing.GroupLayout.DEFAULT_SIZE, 116, Short.MAX_VALUE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(impares1, javax.swing.GroupLayout.DEFAULT_SIZE, 116, Short.MAX_VALUE)
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                        .addGap(30, 30, 30)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 123, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(numinversa))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(numprimo)
                            .addComponent(jScrollPane4, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(num)
                            .addComponent(restaurar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addContainerGap())))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(num, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(pares1)
                    .addComponent(impares1)
                    .addComponent(numinversa)
                    .addComponent(numprimo))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jScrollPane4, javax.swing.GroupLayout.DEFAULT_SIZE, 163, Short.MAX_VALUE)
                    .addComponent(jScrollPane1)
                    .addComponent(jScrollPane2)
                    .addComponent(jScrollPane3, javax.swing.GroupLayout.Alignment.TRAILING))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 12, Short.MAX_VALUE)
                .addComponent(restaurar)
                .addGap(18, 18, 18))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void pares1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_pares1ActionPerformed
       int nu;
        nu = Integer.parseInt(num.getText());
       
        
        pares1.setEnabled(false);
        impares1.setEnabled(false);
        numinversa.setEnabled(false);
        numprimo.setEnabled(false);
        num.setEnabled(false);
        
        
        for (int i=2; i < nu; i+=2){
          
            
            par.addElement(""+i);
       }
        
    }//GEN-LAST:event_pares1ActionPerformed

    private void impares1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_impares1ActionPerformed
        
        int nu2;
        nu2 = Integer.parseInt(num.getText());
       
        pares1.setEnabled(false);
        impares1.setEnabled(false);
        numinversa.setEnabled(false);
        numprimo.setEnabled(false);
        num.setEnabled(false);
 
        for (int i=1; i < nu2; i+=2){
                     
            impares.addElement(""+i);
       }
        
    }//GEN-LAST:event_impares1ActionPerformed

    private void numinversaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_numinversaActionPerformed
         int nu3;
        nu3 = Integer.parseInt(num.getText());
       
        pares1.setEnabled(false);
        impares1.setEnabled(false);
        numinversa.setEnabled(false);
        numprimo.setEnabled(false);
        num.setEnabled(false);
        for (int i=-1; i >= nu3; i--){
                     
            inversa.addElement(""+i);
       }
    }//GEN-LAST:event_numinversaActionPerformed

    private void numprimoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_numprimoActionPerformed
         int nu4;
        nu4 = Integer.parseInt(num.getText());
       int aux;
        pares1.setEnabled(false);
        impares1.setEnabled(false);
        numinversa.setEnabled(false);
        numprimo.setEnabled(false);
        num.setEnabled(false);
        for (int i=2; i < nu4; i++){
                     aux = nu4 % i;
           if (aux==0)          
            primo.addElement(""+i);
      
        
        }    }//GEN-LAST:event_numprimoActionPerformed

    private void restaurarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_restaurarActionPerformed
        pares1.setEnabled(true);
        impares1.setEnabled(true);
        numinversa.setEnabled(true);
        numprimo.setEnabled(true);
        par.removeAllElements();
        impares.removeAllElements();
        primo.removeAllElements();
        inversa.removeAllElements();
        num.setText("");
        num.setEnabled(true);
        
       num.requestFocus();
    }//GEN-LAST:event_restaurarActionPerformed

    /**
     * @param args the command line arguments
     */
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
            java.util.logging.Logger.getLogger(Ejerc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Ejerc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Ejerc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Ejerc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Ejerc().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JList<String> impar;
    private javax.swing.JButton impares1;
    private javax.swing.JTextField impares2;
    private javax.swing.JButton impares3;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JProgressBar jProgressBar1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JList<String> nuinversa;
    private javax.swing.JTextField num;
    private javax.swing.JButton numinversa;
    private javax.swing.JButton numprimo;
    private javax.swing.JList<String> nuprimo;
    private javax.swing.JList<String> pares;
    private javax.swing.JButton pares1;
    private javax.swing.JButton restaurar;
    // End of variables declaration//GEN-END:variables
}
