public class Data
{
    private int dia,mes,ano;
    private static string informacao = "Um objeto que armazena um dado";
    public static void imprimeAlgo(){
        Console.WriteLine(informacao);
    }

    public Data(Data d):this(d.dia, d.mes, d.ano){}    
    public Data():this(1,1,1){}
    public Data(int _dia, int _mes):this(_dia, _mes, 2023){}
    public Data(int _dia, int _mes, string _ano){
        ano=Int32.Parse(_ano);
        mes=_mes;
        dia=_dia;
    }
    public Data(int _dia, int _mes, int _ano){
        ano=_ano;
        mes=_mes;
        dia=_dia;
    }
    public void print(){
        Console.WriteLine("dia:"+dia+"\nmês:"+mes+"\nano:"+ano);

    }

    public static Data operator+ (Data dataA, Data dataB){
/*
        int d;
        if(dataA.dia>dataB.dia)
            d=dataA.dia;
        else   
            d=dataB.dia;
*/
        int d = (dataA.dia>dataB.dia)? dataA.dia : dataB.dia;

        int m;
        if(dataA.mes>dataB.mes)
            m=dataA.mes;
        else   
            m=dataB.mes;

        int a;
        if(dataA.ano>dataB.ano)
            a=dataA.ano;
        else   
            a=dataB.ano;

        return new Data(d,m,a);

    }

    public static Data operator+(Data dt, int valor){
        return new Data(dt.dia+valor, dt.mes, dt.ano);
    }


}