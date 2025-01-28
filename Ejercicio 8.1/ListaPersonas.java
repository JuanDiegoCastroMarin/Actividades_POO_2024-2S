package Personas;

import java.util.*;

public class ListaPersonas {
    Vector listaPersonas;

    public ListaPersonas() {
        listaPersonas = new Vector();
    }

    public void anadirPersona(Persona p) {
        listaPersonas.add(p);
    }

    public void eliminarPersona(int i) {
        listaPersonas.removeElementAt(i);
    }

    public void borrarLista() {
        listaPersonas.removeAllElements();
    }

    public Persona getPersona(int i) {
        return (Persona) listaPersonas.get(i);
    }

    public int getSize() {
        return listaPersonas.size();
    }
}