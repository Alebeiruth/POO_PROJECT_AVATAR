//abaixo criação da classe Naviclass
class Naviclass {
    //atributos da classe Naviclass
    private string name;
    int age;
    int height;

    // abaixo contrutor da classe Naviclass
    public Naviclass(string name, int age, int height) {
        this.name = name;
        this.age = age;
        this.height = height;
    }
//metodos andar, correr e comer abaixo da classe Naviclass
    public void andar() {
        Console.WriteLine($"{name} está andando");   
    }

    public void correr() {
        Console.WriteLine($"{name} está correndo");
    }

    public void comer() {
        Console.WriteLine($"{name} está comendo");
    }
}

// abaixo classe Omaticay que é uma classe filha de Naviclass
    class Omaticay extends Naviclass {
        //constructor da classe Omaticay
        public Omaticay(string name, int age, int height) : base(name, age, height) {
        }
        //metodos da classe Omaticay
        public void nadar(){
            Console.WriteLine($"{name} está nadando");
        }
    }

//criação da classe Avatar (PARA ENCAPSULAMENTO)
class Avatar {
    //atributos da classe Avatar
    private string name;
    private int age;

    //contrutor da classe Avatar
    public Avatar(string name, int age) {
        this.name = name;
        this.age = age;
    }

    //metodo getNome abaixo da classe Naviclass == GET
    public getNome {
        return this.name;
    }
    //metodo setNome abaixo da classe Naviclass == SET
    public setNome(string name) {
        this.name = name;
    }
    //metodo andar e conectar abaixo da classe Avatar
    public void andar() {
        Console.WriteLine($"{name} está andando");   
    }

    public void conectar(){
        Console.WriteLine($"{name} está conectado");
    }

}

//criação da classe human (PARA ABSTRAÇÃO)
class human {
    //atributos da classe human
    private string name;
    private int age;
    //contrutor da classe human
    public human(string name, int age) {
        this.name = name;
        this.age = age;
    }
    //metodo utilizarLink abaixo da classe human
    public void utilizarLink(){
        Console.WriteLine($"{name} está utilizando o link");
    }
}

//criação da classe AnimalDePandora (PARA CLASSE ABSTRATA)
abstract class AnimalDePandora {
    //atributos da classe AnimalDePandora
    public string name;
    //contrutor da classe AnimalDePandora
    public AnimalDePandora(string name) {
        this.name = name;
    }
    //metodo movimentar abaixo da classe AnimalDePandora
    abstract void movimentar();
}

//criação da classe Tulkun (PARA HERANÇA)
//nao precisa de constructor pois herda da classe AnimalDePandora
//sou obrigado implementar o metodo movimentar herdados da classe AnimalDePandora
class public Tulkun extends AnimalDePandora{
    //metodo movimentar abaixo da classe Tulkun
    public void movimentar(){
        Console.WriteLine($"{name} está se movimentando");
    }
}

//criação da classe Ikran (PARA INTERFACE)
class public Ikran extends AnimalDePandora{
    //atributos da classe Ikran
    public string name;
    //contrutor da classe Ikran
    public Ikran(string name) {
        this.name = name;
    }
    //metodo movimentar abaixo da classe Ikran
   public void movimentar(){
        Console.WriteLine($"{name} está se movimentando");
    }
}
//criação da classe AnimaisDePandora (PARA POLIMORFISMO)
public class  AnimaisDePandora {
    //atributos da classe AnimaisDePandora movimentar e emitirSom
    public void movimentar(){
        Console.WriteLine("se movimentando");
    }
    public void emitirSom(){
        Console.WriteLine("emitindo som");
    }
}
//criação da classe Irk (PARA POLIMORFISMO)
class public Irk extends AnimaisDePandora{
    //metodo movimentar abaixo da classe Irk
    public void movimentar(){
        Console.WriteLine("voou");
    }
    //metodo emitirSom abaixo da classe Irk
    public void emitirSom(){
        Console.WriteLine("fez barulho de passaro");
    }
}
//criação da classe Tsurak (PARA POLIMORFISMO)
class public Tsurak extends AnimaisDePandora {
    //metodo movimentar abaixo da classe Tsurak
    public void movimentar(){
        Console.WriteLine("correu");
    }
    //metodo emitirSom abaixo da classe Tsurak
    public void emitirSom(){
        Console.WriteLine("fez barulho de cachorro");
    }
}

//Diferença entre metodos abstratos e metodos concretos
//metodo abstrato
public abstract class Forma {
    public abstract double CalcularArea();
}
//metodo concreto
public class Circulo : Forma
{
    private double raio;
    public Circulo (double raio)
    {
            this.raio = raio;
    }

    public override double CalcularArea() {
    return Math.PI * raio * raio;
    }
    }

// abaixo classe principal
class Program {
    static void Main(string[] args) {
        Naviclass pessoa = new Naviclass("Ale", 25, 170);
        Omaticay omaticay = new Omaticay("Lea", 25, 170);
        human humano = new human("Lae", 25);
        AnimalDePandora payakan = new Tulkun("Payakan");
        AnimaisDePandora irk = new Irk();
        AnimaisDePandora tsurak = new Tsurak();

        string animais AnimaisDePandora[animais] = [irk, tsurak];

        Lae.utilizarLink();//virou avatar
        pessoa.andar();
        pessoa.correr();
        pessoa.comer();
    }
}
