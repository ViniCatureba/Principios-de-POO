//Pilares de POO

//Ferramentas - Formas de Trabalhar com POO

//Encapsulamento e Herença

//Abstração e Polimorfismo

//Encapsulamento - Esconder comportamentos e atributos

//public / private / protected / internal (encapsulamento do c#)

// public - Ao usar em atributos, metodos ou classe pode ser acessado por qualquer um

// Private -Esse atributo/metodo/classe só pode ser acessado dentro da propria classe
// Vantagens: 1º Esconder atribulots/metodos/classes; Defino as regras para alteracao ou listagem

// protected/internal - Esse atributo/metodo/clase so pode ser acesso pela classe criada ou pela classe pai



//Get -> Metodo para pegar um atributo privato

//Set -> metodo para alterar atributo privado







// Polimorfismo depende de Heranca
//Polimorfismo - Um metodo (com esse
// nao existe polimorfismo sem heranca

using Pilares;

Carro2 carro1 =new Carro2();   
CarroEletrico carroE = new CarroEletrico();

carro1.modelo = "Fusca";
carro1.marca = "Volkswagen";
carro1.quilometragem = 3000;

carroE.modelo = "Tesla Model 5";
carroE.marca = "Tesla";
carroE.quilometragem = 1000;
carroE.bateria = 200;
carroE.tempoDeCarga = 50;

carro1.MostrarInformacoes();
carroE.MostrarInformacoes();

//outro tipo de polimorfismo
carro1.MostrarInformacoes("vinicius");