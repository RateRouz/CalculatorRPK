package com.company;

public class Divider implements Process {
    public Divider() {
    }

    @Override
    public double process(double a, double b) {
        return a / b;
    }

    @Override
    public int modProcess(int a, int b, int m) {
        if (isPrime(m))
            return (a * inverseElement(b, m) % m);
        else return Integer.MAX_VALUE;
    }

    int binPow(int basa, int p, int m) {
        if (p == 1)
            return basa;
        if (p % 2 == 0) {
            int t = binPow(basa, p / 2, m);
            return (int) (Math.pow(p, 2) % m);
        } else
            return binPow(basa, p - 1, m) * basa % m;
    }

    int inverseElement(int x, int m) {
        return binPow(x, m - 2, m);
    }

    private boolean isPrime(int n) {
        for (int i = 2; i < Math.sqrt(n); i++) {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
