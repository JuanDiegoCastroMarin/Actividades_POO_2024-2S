package Ejercicio.4.1;

class CuentaCorriente extends Cuenta {
    private float sobregiro;

    public CuentaCorriente(float saldo, float tasaAnual) {
        super(saldo, tasaAnual);
        sobregiro = 0;
    }

    @Override
    public void retirar(float cantidad) {
        if (cantidad > saldo) {
            sobregiro += (cantidad - saldo);
            saldo = 0;
        } else {
            super.retirar(cantidad);
        }
    }

    @Override
    public void consignar(float cantidad) {
        if (sobregiro > 0) {
            if (cantidad > sobregiro) {
                saldo += (cantidad - sobregiro);
                sobregiro = 0;
            } else {
                sobregiro -= cantidad;
            }
        } else {
            super.consignar(cantidad);
        }
    }

    public void imprimir() {
        System.out.println("Saldo = $"  + saldo);
        System.out.println("Cargo Mensual = $"  + comisionMensual);
        System.out.println("Número de transacciones = " + (numeroConsignaciones + numeroRetiros));
        System.out.println("Valor de sobregiro = $" +(numeroConsignaciones + numeroRetiros));
        System.out.println();
    }
}
