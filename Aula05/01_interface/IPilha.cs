public interface IPilha{
    void Empilha(object o);
    object? Desempilha();
    object? Topo{get;}
}