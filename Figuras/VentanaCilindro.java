package Figuras;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class VentanaCilindro extends JFrame implements ActionListener {
    private JTextField campoRadio, campoAltura;
    private JLabel volumen, superficie;
    private JButton calcular;

    public VentanaCilindro() {
        setTitle("Cilindro");
        setSize(280, 210);
        setLocationRelativeTo(null);
        setResizable(false);
        setLayout(new GridLayout(4, 2));

        add(new JLabel("Radio (cms):"));
        campoRadio = new JTextField();
        add(campoRadio);

        add(new JLabel("Altura (cms):"));
        campoAltura = new JTextField();
        add(campoAltura);

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
        double altura = Double.parseDouble(campoAltura.getText());
        Cilindro cilindro = new Cilindro(radio, altura);
        volumen.setText("Volumen: " + cilindro.getVolumen());
        superficie.setText("Superficie: " + cilindro.getSuperficie());
    }
}
