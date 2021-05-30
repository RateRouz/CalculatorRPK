package com.company;

public class Minuser implements Process {
    @Override
    public double process(double a, double b) {
        return a - b;
    }

    @Override
    public int modProcess(int a, int b, int m) {
        return (a - b) % m;
    }
}
