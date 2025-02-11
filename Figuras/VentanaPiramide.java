package Figuras;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class VentanaPiramide extends JFrame implements ActionListener {
    private JTextField campoBase, campoAltura, campoApotema;
    private JLabel volumen, superficie;
    private JButton calcular;

    public VentanaPiramide() {
        setTitle("Piramide");
        setSize(280, 240);
        setLocationRelativeTo(null);
        setResizable(false);
        setLayout(new GridLayout(5, 2));

        add(new JLabel("Base (cms):"));
        campoBase = new JTextField();
        add(campoBase);

        add(new JLabel("Altura (cms):"));
        campoAltura = new JTextField();
        add(campoAltura);

        add(new JLabel("Apotema (cms):"));
        campoApotema = new JTextField();
        add(campoApotema);

        calcular = new JButton("Calcular");
        calcular.addActionListener(this);
        add(calcular);

        volumen = new JLabel("Volumen (cm3):");
        add(volumen);
        superficie = new JLabel("Superficie (cm2:");
        add(superficie);
    }

    public void actionPerformed(ActionEvent e) {
        double base = Double.parseDouble(campoBase.getText());
        double altura = Double.parseDouble(campoAltura.getText());
        double apotema = Double.parseDouble(campoApotema.getText());
        Piramide piramide = new Piramide(base, altura, apotema);
        volumen.setText("Volumen: " + piramide.getVolumen());
        superficie.setText("Superficie: " + piramide.getSuperficie());
    }
}
