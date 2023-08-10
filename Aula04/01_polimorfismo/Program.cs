Pessoa p = new("Edson", 46);
Console.Write(p);

p.anoDeNascimento=1990;
Console.Write(p);

Funcionario f = new Funcionario(1500.13M);
Console.WriteLine(f);

f=new("Edson", 46, 1800);
Console.WriteLine(f);


Pessoa paux;
paux = p;
Console.WriteLine("//=-=-=-=-=-=-=-=-");
Console.WriteLine("Pessoa");
Console.WriteLine(paux);
Console.WriteLine("Qual o seu humor?"+paux.humor());
paux = f;
Console.WriteLine("//=-=-=-=-=-=-=-=-");
Console.WriteLine("Funcionario");
Console.WriteLine(paux);
Console.WriteLine("Qual o seu humor?"+paux.humor());
Console.WriteLine("Paux é pessoa? "+(paux is Pessoa));
Console.WriteLine("Paux é funcionario? "+(paux is Funcionario));
if(paux is Funcionario)
 Console.WriteLine("Está satisfeito com o salario?"+(paux as Funcionario).satisfacaoSalarial());

object oaux;
oaux=p;
Console.WriteLine("//=-=-=-=-=-=-=-=-");
Console.WriteLine("oPessoa");
Console.WriteLine(oaux);
Console.WriteLine("Qual o seu humor?"+((Pessoa)oaux).humor());

oaux=f;
Console.WriteLine("//=-=-=-=-=-=-=-=-");
Console.WriteLine("oFuncionanrio");
Console.WriteLine("  //=-=-=-=-=-=-=-=-");
Console.WriteLine(oaux as object);
Console.WriteLine("  //=-=-=-=-=-=-=-=-");
Console.WriteLine(oaux as Pessoa);
Console.WriteLine("  //=-=-=-=-=-=-=-=-");
Console.WriteLine(oaux as Funcionario);
Console.WriteLine("Qual o seu humor?"+(oaux as Pessoa).humor());
Console.WriteLine("Qual o seu humor?"+(oaux as Funcionario).humor());
