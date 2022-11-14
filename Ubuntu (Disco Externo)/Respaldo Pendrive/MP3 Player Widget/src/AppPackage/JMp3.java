/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package AppPackage;

import java.awt.Color;
import java.io.BufferedInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.filechooser.FileFilter;
import javax.swing.filechooser.FileNameExtensionFilter;
import javazoom.jl.decoder.JavaLayerException;
import javazoom.jl.player.Player;


/**
 *
 * @author Felipe
 */
public class JMp3 extends javax.swing.JFrame {

    /**
     * Creates new form JMp3
     */
    
    
    
    Control Music = new Control();
    public JMp3() {
        initComponents();
        setLocationRelativeTo(null);
        
        }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
   
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        Display = new javax.swing.JTextField();
        jPanel1 = new javax.swing.JPanel();
        stop3 = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        stop1 = new javax.swing.JLabel();
        stop2 = new javax.swing.JLabel();
        stop = new javax.swing.JLabel();
        state = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        jMenuItem1 = new javax.swing.JMenuItem();
        jMenuItem2 = new javax.swing.JMenuItem();
        Tools = new javax.swing.JMenu();
        jMenu2 = new javax.swing.JMenu();
        jMenuItem3 = new javax.swing.JMenuItem();
        jMenuItem4 = new javax.swing.JMenuItem();
        jMenuItem5 = new javax.swing.JMenuItem();
        jMenu3 = new javax.swing.JMenu();
        jMenuItem6 = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Reproductor Mp3 Java");
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        Display.setEditable(false);
        Display.setFont(new java.awt.Font("Square721 BT", 0, 24)); // NOI18N
        Display.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        Display.setText(" ");
        getContentPane().add(Display, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 120, 290, -1));

        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        stop3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        stop3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/music_orange.png"))); // NOI18N
        stop3.setToolTipText("Open");
        stop3.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                stop3MouseClicked(evt);
            }
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                stop3MouseEntered(evt);
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                stop3MouseExited(evt);
            }
        });
        jPanel1.add(stop3, new org.netbeans.lib.awtextra.AbsoluteConstraints(315, 17, -1, -1));

        jPanel2.setBackground(new java.awt.Color(51, 51, 51));
        jPanel2.setBorder(new javax.swing.border.SoftBevelBorder(javax.swing.border.BevelBorder.RAISED));

        stop1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/4.png"))); // NOI18N
        stop1.setToolTipText("Stop");
        stop1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                stop1MouseClicked(evt);
            }
        });

        stop2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/5.png"))); // NOI18N
        stop2.setToolTipText("Play/Resume");
        stop2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                stop2MouseClicked(evt);
            }
        });

        stop.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/6.png"))); // NOI18N
        stop.setToolTipText("Pause");
        stop.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                stopMouseClicked(evt);
            }
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                stopMouseEntered(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(29, Short.MAX_VALUE)
                .addComponent(stop1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(stop2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(stop)
                .addGap(32, 32, 32))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(stop2)
                    .addComponent(stop1)
                    .addComponent(stop))
                .addContainerGap())
        );

        jPanel1.add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 10, -1, -1));

        state.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        state.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jPanel1.add(state, new org.netbeans.lib.awtextra.AbsoluteConstraints(303, 88, 59, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 170, 390, 120));

        jLabel3.setFont(new java.awt.Font("Tahoma", 0, 36)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(51, 51, 51));
        jLabel3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/MP3.png"))); // NOI18N
        jLabel3.setText("Reproductor Mp3 Java");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 30, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 0, 20)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(51, 51, 51));
        jLabel4.setText("Design by Artyom");
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 380, -1, -1));

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/audifonos-de-musica-87792.jpg"))); // NOI18N
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, -1));

        jMenu1.setText("File");

        jMenuItem1.setText("Reset");
        jMenuItem1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem1ActionPerformed(evt);
            }
        });
        jMenu1.add(jMenuItem1);

        jMenuItem2.setText("Exit");
        jMenuItem2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem2ActionPerformed(evt);
            }
        });
        jMenu1.add(jMenuItem2);

        jMenuBar1.add(jMenu1);

        Tools.setText("Edit");

        jMenu2.setText("Change Imagen");

        jMenuItem3.setText("Image 1");
        jMenuItem3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem3ActionPerformed(evt);
            }
        });
        jMenu2.add(jMenuItem3);

        jMenuItem4.setText("Image 2");
        jMenuItem4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem4ActionPerformed(evt);
            }
        });
        jMenu2.add(jMenuItem4);

        jMenuItem5.setText("Image 3");
        jMenuItem5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem5ActionPerformed(evt);
            }
        });
        jMenu2.add(jMenuItem5);

        Tools.add(jMenu2);

        jMenuBar1.add(Tools);

        jMenu3.setText("Help");

        jMenuItem6.setText("About");
        jMenuItem6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem6ActionPerformed(evt);
            }
        });
        jMenu3.add(jMenuItem6);

        jMenuBar1.add(jMenu3);

        setJMenuBar(jMenuBar1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void stop1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_stop1MouseClicked
        // TODO add your handling code here:
        Music.Stop();
        state.setText("Stop");
    }//GEN-LAST:event_stop1MouseClicked

    private void stop2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_stop2MouseClicked
        // TODO add your handling code here:
        Music.Resume();
        state.setText("Playing");
    }//GEN-LAST:event_stop2MouseClicked

    private void stopMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_stopMouseClicked
        // TODO add your handling code here:
        Music.Pause();
        state.setText("Pause");
    }//GEN-LAST:event_stopMouseClicked

    private void stop3MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_stop3MouseClicked
        // TODO add your handling code here:
         FileFilter filter = new FileNameExtensionFilter("MP3 Files","mp3","mpeg3");
        
        JFileChooser chooser = new JFileChooser("F:\\Music");
        chooser.addChoosableFileFilter(filter);
        
        int returnVal = chooser.showOpenDialog(null);
        
        if(returnVal == JFileChooser.APPROVE_OPTION){
            
            File myFile = chooser.getSelectedFile();
            String song = myFile + "";
            
            String name = chooser.getSelectedFile().getName();            
            Display.setText(name);
            state.setText("Playing");
            Music.Play(song);
        }
    }//GEN-LAST:event_stop3MouseClicked

    private void stopMouseEntered(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_stopMouseEntered
        // TODO add your handling code here:
    }//GEN-LAST:event_stopMouseEntered

    private void stop3MouseEntered(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_stop3MouseEntered
        // TODO add your handling code here:
        stop3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/music (3).png")));
    }//GEN-LAST:event_stop3MouseEntered

    private void stop3MouseExited(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_stop3MouseExited
        // TODO add your handling code here:
        stop3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/music_orange.png")));
    }//GEN-LAST:event_stop3MouseExited

    private void jMenuItem3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem3ActionPerformed
        // TODO add your handling code here:
        jLabel3.setForeground(Color.black);
        jLabel4.setForeground(Color.black);
        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/audifonos-de-musica-877923.jpg")));
    }//GEN-LAST:event_jMenuItem3ActionPerformed

    private void jMenuItem5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem5ActionPerformed
        // TODO add your handling code here:
        jLabel3.setForeground(Color.black);
        jLabel4.setForeground(Color.black);
        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/audifonos-de-musica-87792.jpg")));
    }//GEN-LAST:event_jMenuItem5ActionPerformed

    private void jMenuItem4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem4ActionPerformed
        // TODO add your handling code here:
        jLabel3.setForeground(Color.ORANGE);
        jLabel4.setForeground(Color.ORANGE);
        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Images/audifonos-de-musica-87792_1_1.jpg")));
    }//GEN-LAST:event_jMenuItem4ActionPerformed

    private void jMenuItem1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem1ActionPerformed
        // TODO add your handling code here:
        dispose();
        JMp3.main(null);
    }//GEN-LAST:event_jMenuItem1ActionPerformed

    private void jMenuItem2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem2ActionPerformed
        // TODO add your handling code here:
        System.exit(0);
    }//GEN-LAST:event_jMenuItem2ActionPerformed

    private void jMenuItem6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem6ActionPerformed
        // TODO add your handling code here:
        About.main(null);
    }//GEN-LAST:event_jMenuItem6ActionPerformed

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
            java.util.logging.Logger.getLogger(JMp3.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JMp3.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JMp3.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JMp3.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new JMp3().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField Display;
    private javax.swing.JMenu Tools;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenu jMenu2;
    private javax.swing.JMenu jMenu3;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JMenuItem jMenuItem1;
    private javax.swing.JMenuItem jMenuItem2;
    private javax.swing.JMenuItem jMenuItem3;
    private javax.swing.JMenuItem jMenuItem4;
    private javax.swing.JMenuItem jMenuItem5;
    private javax.swing.JMenuItem jMenuItem6;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JLabel state;
    private javax.swing.JLabel stop;
    private javax.swing.JLabel stop1;
    private javax.swing.JLabel stop2;
    private javax.swing.JLabel stop3;
    // End of variables declaration//GEN-END:variables
}