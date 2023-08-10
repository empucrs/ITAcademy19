Pessoa p1 = new("Edson", 46);
Pessoa p2 = new Pessoa("Edson", 46);
Pessoa p3 = p1;

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine("p1 e p2 são a mesma pessoa? "+(p1==p2));
Console.WriteLine("p1 e p3 são a mesma pessoa? "+(p1==p3));
Console.WriteLine("p3 e p2 são a mesma pessoa? "+(p3==p2));

Console.WriteLine("p1 e p2 são a mesma pessoa(Equals)? "+(p1.Equals(p2)));
Console.WriteLine("p1 e p3 são a mesma pessoa(Equals)? "+(p1.Equals(p3)));
Console.WriteLine("p3 e p2 são a mesma pessoa(Equals)? "+(p3.Equals(p2)));
