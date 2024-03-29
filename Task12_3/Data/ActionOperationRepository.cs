﻿namespace Task12_3
{
    delegate double operFunkHandler(double a, double b);

    internal static class ActionOperationRepository
    {
        public static double Plus(double a, double b) => a + b;

        public static double Subtract(double a, double b) => b - a;

        public static double Division(double a, double b) => b / a;

        public static double Multiply(double a, double b) => a * b;

        public static double Reminder(double a, double b) => b % a;

        public static double Xor(double a, double b) => (int)b ^ (int)a;

        public static double Sin(double a, double b = 0) => Math.Sin(a + b);

        public static double Cos(double a, double b = 0) => Math.Cos(a + b);

        public static double Log(double a, double b = 0) => Math.Log(a + b);

        public static double Pow(double a, double b = 0) => Math.Pow(b , a);

        public static double Sqrt(double a, double b = 0) => Math.Sqrt(a + b);

        public static double Cbrt(double a, double b = 0) => Math.Cbrt(a + b);

    }
}
