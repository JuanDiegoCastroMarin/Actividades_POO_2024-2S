package Figuras;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class VentanaEsfera extends JFrame implements ActionListener {
    private JTextField campoRadio;
    private JLabel volumen, superficie;
    private JButton calcular;

    public VentanaEsfera() {
        setTitle("Esfera");
        setSize(280, 200);
        setLocationRelativeTo(null);
        setResizable(false);
        setLayout(new GridLayout(3, 2));

        add(new JLabel("Radio (cms):"));
        campoRadio = new JTextField();
        add(campoRadio);

        calcular = new JButton("Calcular");
        calcular.addActionListener(this);
        add(calcular);

        volumen = new JLabel("Volumen (cm3):");
        add(volumen);
        superficie = new JLabel("Superficie (cm2):");
        add(superficie);
    }

    public void actionPerformed(ActionEvent e) {
        double radio = Double.parseDouble(campoRadio.getText());
        Esfera esfera = new Esfera(radio);
        volumen.setText("Volumen: " + esfera.getVolumen());
        superficie.setText("Superficie: " + esfera.getSuperficie());
    }
}
