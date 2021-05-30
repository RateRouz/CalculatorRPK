package com.company;
public class Main {

    public static void main(String[] args) {
        Adder adder = new Adder();
        Minuser minuser = new Minuser();
        Timeser timeser = new Timeser();
        Divider divider = new Divider();
        System.out.println("Действительные(+)" + adder.process(6, 2));
        System.out.println("Действительные(-)" + minuser.process(6, 2));
        System.out.println("Действительные(*)" + timeser.process(6, 2));
        System.out.println("Действительные(/)" + divider.process(6, 2));
        System.out.println("Комплексные(+)" + adder.process(new Compl(2, 3), new
                Complex(-1, 1)));
        System.out.println("Комплексные(-)" + minuser.process(new Complex(2, 3), new
                Complex(-1, 1)));
        System.out.println("Комплексные(*)" + timeser.process(new Complex(2, 3), new
                Complex(-1, 1)));
        System.out.println("Комплексные(/)" + divider.process(new Complex(2, 3), new
                Complex(-1, 1)));
        System.out.println("Кватернионы(+)" + adder.process(new Quaternion(1, 2, 3, 4),
                new Quaternion(1, 2, 3, 4)));
        System.out.println("Кватернионы(-)" + minuser.process(new Quaternion(1, 2, 3, 4),
                new Quaternion(1, 2, 3, 4)));
        System.out.println("Кватернионы(*)" + timeser.process(new Quaternion(1, 2, 3, 4),
                new Quaternion(1, 2, 3, 4)));
        System.out.println("Кватернионы(/)" + divider.process(new Quaternion(1, 2, 3, 4),
                new Quaternion(1, 2, 3, 4)));
        System.out.println("По модулю(+)" + adder.modProcess(31, 7, 5));
        System.out.println("По модулю(-)" + minuser.modProcess(31, 7, 5));
        System.out.println("По модулю(*)" + timeser.modProcess(31, 7, 5));
        System.out.println("По модулю(/)" + divider.modProcess(31, 7, 5));
    }
}
