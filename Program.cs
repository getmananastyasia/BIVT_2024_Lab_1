﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int x = 2; x <= 35; x += 3)
            answer += x;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int x = 1; x <= 10.0; x++)
            answer += 1.0 / x;
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int x = 2; x <= 112; x += 2)
            answer += x / (x + 1.0);
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double y = 1;
        if (x == 0) return 0;
        for(int i=1;i<=9;i++)
        {
            answer += Math.Cos(i * x) / y;
            y *= x;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int n = 0; n <= 9; n++)
            answer += (p + h * n) * (p + h * n);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1;
        for (int x = 1; x <= 6; x++)
        {
            f *= x;
        }
        answer = f;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        for(int x = 1;x<=6;x++)
        {
            f *= x;
            answer += f;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f = 1, c = 1, b = 1;
        for(int a = 1; a<=6;a++)
        {
            
            c = c * (-1);
            b = b * 5;
            f *= a;
            answer += (c * b) / f;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int k = 1;
        for (int n = 1; n <= 7; n++)
        {
            k *= 3;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int x = 1; x <= 6; x++)
            Console.Write(x);
        Console.WriteLine();
        for (int x = 1; x <= 6;x++)
            Console.Write(5);

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double f = 1.0;
        if (x == 0) return 0;
        for(int a =0; a<= 10;a++)
        {
            answer += 1.0 / f;
            f *= x;
    
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x<=-1)
        {
            answer =1;
        }
        else if(x >1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int i = 1, k = 1, m = 1, s = 0;
        Console.WriteLine('1');
        Console.WriteLine('1');
        while (i != 7)
        {
            s = m + k;
            k = m;
            m = s;
            Console.WriteLine(s);
        }

        // code here

    }
    public double Task_1_15()
    {
        // code here
        double answer = 0;
        double ch1 = 1;
        double ch2 = 2;
        double zn1 = 1;
        double zn2 = 1;
        double ch3 = 0;
        double zn3 = 0;
        for (int x = 1; x <= 3; x++)
        {
            ch3 = ch1 + ch2;
            zn3 = zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch3;
            zn2 = zn3;
            answer = ch3 / zn3;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0.0;
        int power = 0;

        // code here
        int i = 1;
        double z = 1.0;
        while(i!= 65)
        {
            answer += z;
            z *= 2;
            i++;
        }
        answer /= 15;
        power = (int)Math.Log10(answer);
        answer = answer/Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        // end
        ;
        return (answer,power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        const int R = 6350;

        // code here
        answer += Math.Sqrt(((x + R) * (x + R)) - (R * R));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
 
        for(int h = 0; h<x; h+=3)
        {
            answer *= 2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        int n = 1;
        double a = 1;
        // code here
        while(a>=0.0001)
        {
            answer += Math.Cos(x * n) / (n * n);
            n++;
            a = Math.Abs(Math.Cos(n*x)/(n*n));  
        }
      
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;
        double s = 0;
        // code here
        do
        {
            if (p > (a + (answer * h)))
            {
                answer++;
                s += a + (answer * h);
            }
            else
            {
                answer = 0;
                break;
            }
        } while (s <= p);
        
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        if (N == 0 || M == 0)
        {
            quotient = 0;
            remainder = 0;
        }
        else if (N > 0)
        {
            while (N >= M)
            {
                N -= M;
                quotient++;
                remainder = N;
            }
        }
        else
        {
            while (N <= M)
            {
                M -= N;
                quotient++;
                remainder = M;
            }
        }
        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0.0,s = 10.0;
        int x = 0;

        // code here
        while(x<7)
        {
            answer += s;
            x++;
            s *= 1.1;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        double answer = 0.0, s =10.0;
        int  n = 0;

        // code here
        while(answer<100)
        {
            answer+=s;
            n++;
            s = s * 1.1;
        }
        Console.WriteLine(n);
        
        // end
        
        return n;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        const double d = 20.0;
        double s = 10.0;
        // code here
        while(s<d)
        {
            s *= 1.1;
            answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;
        double l = 0.1;
        double da = 0.0000000001;
        // code here;
        while(l > da)
        {
            answer++;
            l /= 2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;
        int i = 1;
        int p = -1;
        // code here
        while (Math.Abs(p*Math.Cos(x * i )/(i*i)) >= 0.0001)
        {
            S += p * Math.Cos(x * i) / (i * i);
            p *= -1;
            i++;
        }
        Console.WriteLine(S);
        y = ((x * x - (double.Pi * double.Pi / 3)) / 4);
        // end
        Console.WriteLine(y);

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;
        // code here
       
        // end
        
        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}