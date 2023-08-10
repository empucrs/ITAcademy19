public class Pilha: IPilha{

    private List<object> minhaListaDeObjetos;
    private int nElementos;

    public Pilha(){
        minhaListaDeObjetos = new List<object>();
        nElementos=0;
    }

    public void Empilha(object parametro){
        minhaListaDeObjetos.Add(parametro);
        nElementos++;
    }

    public object Desempilha(){
        if(nElementos>0){
            object aux = minhaListaDeObjetos[nElementos-1];
            minhaListaDeObjetos.removeAt(nElementos-1);
            nElementos--;
            return aux;
        }
        else
            return null;
    }

    public object Topo{
        get{
            if(nElementos>0)
                return minhaListaDeObjetos[nElementos-1];
            else
                return null;
        }
    }

    
    
}