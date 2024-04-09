using System;


double Fact(double n) {
  if(n == 0)
    return 1;
  else
    return n * Fact(n - 1);
}

double Sinus(double Gr) {
    return Math.Sin((Gr / 180D) * Math.PI);
}

double Cosinus(double Gr) {
    if (Math.Abs(Gr/360)>1) {
        double f= Math.Round(Gr/360);
        Gr= Gr- f*360;
    }
    if ((Gr>90 && Gr<270)||(Gr<-90 && Gr>-270)) {
        return -Math.Pow(1-Math.Pow(Math.Sin((Gr / 180D) * Math.PI),2),0.5);
    }
    else {
        return Math.Pow(1-Math.Pow(Math.Sin((Gr / 180D) * Math.PI),2),0.5);
    }
}

double Tangens(double Gr) {
    return Math.Tan((Gr / 180D) * Math.PI);
}

double Cotangens(double Gr) {
    return 1/(Math.Tan((Gr / 180D) * Math.PI));
}

{
    Console.WriteLine("Use 'rules' or 'Rules'");
    string Str ="",Function="";
    double N1=0;
    while (Str!= "Ex" && Str!="ex") {
        if (Str =="Cl" || Str=="Clear" || Str=="cl" || Str=="clear") {
            N1=0;
            Str="";
            Console.Write("Res: ");
            Console.WriteLine(N1);
        }
        if (Str== "Rules" || Str=="rules") {
            Console.WriteLine("Use +, *, -, /, ^, sqrt or Sqrt, Log or log, Ln or ln, Abs or abs, Fact or fact, Sin or sin, Cos or cos, Tan or tan, Cotan or cotan");
            Console.WriteLine("Use Cl or cl or Clear or clear to refresh memory");
            Console.WriteLine("Function: sqrt, Log, Ln, Abs, Fact, Sin, Cos, Tan, Cotan - Have no memory");
            Console.WriteLine("If you want to get out, use Ex or ex");
        }
        Str=Console.ReadLine();
        if (double.TryParse(Str,out double Num) == true) {
            if (N1!=0) {
                if (Function=="+") {
                    Console.Write("Res: ");
                    Console.WriteLine(N1+Num);
                    N1=N1+Num;
                }
                if (Function=="*") {
                    Console.Write("Res: ");
                    Console.WriteLine(N1*Num);
                    N1=N1*Num;
                }
                if (Function=="-") {
                    Console.Write("Res: ");
                    Console.WriteLine(N1-Num);
                    N1=N1-Num;
                }
                if (Function=="/") {
                    if(Num==0) {
                        Console.Write("Res: ");
                        Console.WriteLine("Error");
                        N1=0;
                        Num=0;
                    }
                    else {
                        Console.Write("Res: ");
                        Console.WriteLine(N1/Num);
                        N1=N1/Num;
                    }
                }
                // 10 функций калькулятора, не считая базовых. Это была база. Теперь спец.
                if (Function=="^") {                //1
                    Console.Write("Res: ");
                    Console.WriteLine(Math.Pow(N1,Num));
                    N1= Math.Pow(N1,Num);
                }
                if (Function=="sqrt" || Function=="Sqrt") { //2
                    if (Num<0) {
                        Console.WriteLine("Error");
                    }
                    else {
                    Console.Write("Res: ");
                    Console.WriteLine(Math.Pow(Num,0.5));
                    N1= Math.Pow(Num,0.5);
                    }
                }
                if (Function== "Log" || Function=="log") { //3
                    Console.Write("Base: ");
                    string Str1 = Console.ReadLine();
                    double.TryParse(Str1,out double Base);
                    if (Num<=0 && Base<=0 && Base==1) {
                        Console.WriteLine("Error");
                    }
                    else {
                        Console.Write("Res: ");
                        Console.WriteLine(Math.Log(Num,Base));
                        N1= Math.Log(Num,Base);
                    }

                }
                if (Function=="Ln" || Function== "ln") { //4
                    if (Num<=0) {
                        Console.WriteLine("Error");
                    }
                    else {
                        Console.Write("Res: ");
                        Console.WriteLine(Math.Log(Num));
                        N1= Math.Log(Num);
                    }
                }
                if (Function=="Abs" || Function=="abs") { //5
                    Console.Write("Res: ");
                    Console.WriteLine(Math.Abs(Num));
                    N1= Math.Abs(Num);
                }
                if (Function == "Fact" || Function=="fact") { //6
                    if (Num<=0) {
                        Console.WriteLine("Error");
                    }
                    else {
                        Console.Write("Res: ");
                        Console.WriteLine(Fact(Num));
                        N1=Fact(Num);
                    }
                }
                if (Function=="Sin" || Function== "sin") { //7
                    Console.Write("Res: ");
                    Console.WriteLine(Sinus(Num));
                    N1=Sinus(Num);
                }
                if (Function=="Cos" || Function=="cos") { //8
                    Console.Write("Res: ");
                    Console.WriteLine(Cosinus(Num));
                    N1=Cosinus(Num);
                }
                if (Function=="Tan" || Function=="tan") { //9
                    Console.Write("Res: ");
                    Console.WriteLine(Tangens(Num));
                    N1=Tangens(Num);
                }
                if (Function=="Cotan" || Function== "cotan") { //10
                    Console.Write("Res: ");
                    Console.WriteLine(Cotangens(Num));
                    N1=Cotangens(Num);
                }
            }
            else {
                N1=Num;
            }
        }
        else {
            Function= Str;
            if ((Function=="sqrt" || Function =="Sqrt" || Function =="Log" || Function=="log" || Function=="Ln" || Function=="ln" || Function=="Abs" ||Function=="abs" || Function=="Fact" || Function=="fact" || Function=="Sin" || Function=="sin" || Function=="Cos" || Function=="cos" || Function=="Tan" || Function=="tan" || Function=="Cotan" || Function=="cotan")&& N1==0) {
                N1=1;
            }
        }
    }

}