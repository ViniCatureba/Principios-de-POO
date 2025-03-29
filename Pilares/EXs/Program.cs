//Ex 1 conta bancaria

using EXs;

ContaBancaria contaVinicius = new ContaBancaria();

contaVinicius.Depositar(1576.06);

double saldo = contaVinicius.VerSaldo();
Console.WriteLine(saldo);

contaVinicius.Sacar(100.44);

saldo = contaVinicius.VerSaldo();
Console.WriteLine(saldo);


//ex 2 funcionario
Funcionario vinicius = new Funcionario();   

vinicius.SetSlario(6439.07);
Console.WriteLine(vinicius.GetSalario());

// ex 3 retangulo

Retangulo retangulo = new Retangulo();

retangulo.SetAltura(10);
Console.WriteLine(retangulo.GetAltura());
retangulo.SetLargura(10);
Console.WriteLine(retangulo.GetLargula());
Console.WriteLine(retangulo.CalcularArea());


