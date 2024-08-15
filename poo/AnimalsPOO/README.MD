# Programação Orientada a Objetos (POO)

## 1. Introdução à POO
Programação Orientada a Objetos (POO) é um paradigma de programação que utiliza "objetos" – instâncias de classes – para representar e manipular dados. POO foca em organizar o software em unidades reutilizáveis e escaláveis, promovendo a manutenção e a expansão do código.

## 2. Conceitos Fundamentais

### 2.1. **Classe**
Uma classe é um modelo ou um molde para criar objetos. Ela define atributos (dados) e métodos (funções) que os objetos criados a partir dela terão.

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    public void Falar()
    {
        Console.WriteLine("Olá!");
    }
}
```

### 2.2. **Objeto**

Um objeto é uma instância de uma classe. Ele contém atributos e métodos definidos pela classe.

```csharp 
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Jeferson";
pessoa.Falar();
 ```

### 2.3. **Encapsulamento**

Encapsulamento é o princípio de esconder os detalhes internos de um objeto e expor apenas o que é necessário. Isso é feito usando modificadores de acesso como **public**, **private**, e **protected**.

```csharp 
public class ContaBancaria
{
    private decimal saldo;

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public decimal ObterSaldo()
    {
        return saldo;
    }
}
```
### 2.4. **Herança**

Herança permite que uma classe derive de outra classe, herdando seus atributos e métodos. A classe derivada pode adicionar novos comportamentos ou modificar os existentes.

```csharp 
public class Animal
{
    public void Comer()
    {
        Console.WriteLine("Comendo...");
    }
}

public class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("Au Au!");
    }
}
```

### 2.5. **Polimorfismo**
Polimorfismo permite que métodos com o mesmo nome se comportem de forma diferente em classes derivadas. Isso pode ser feito através de métodos **sobrescritos(override)**  ou **sobrecarregados (overload)** .

```csharp 
public class Forma
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhando uma forma.");
    }
}

public class Circulo : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um círculo.");
    }
}
```

### 2.6. **Abstração**
Abstração é o processo de ocultar detalhes complexos e mostrar apenas as características essenciais de um objeto. As classes abstratas ou interfaces são frequentemente usadas para definir um contrato que outras classes devem seguir.

```chsharp 
public abstract class FormaGeometrica
{
    public abstract double CalcularArea();
}

public class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}
```

## 3. Relacionamentos Entre Objetos

### 3.1. **Composição**

Composição é quando uma classe é composta de uma ou mais instâncias de outras classes. É uma relação "tem-um" onde os objetos dependem da existência do objeto maior.

```csharp
public class Motor
{
    public int Potencia { get; set; }
}

public class Carro
{
    public Motor Motor { get; set; }

    public Carro(Motor motor)
    {
        Motor = motor;
    }
}
```

### 3.2. **Agregação**
Agregação é uma forma mais fraca de composição onde uma classe pode conter outra, mas os objetos podem existir independentemente.

```csharp
public class Departamento
{
    public List<Funcionario> Funcionarios { get; set; }
}

public class Funcionario
{
    public string Nome { get; set; }
}
```

## 4. Benefícios da POO 

**Reusabilidade**: Código pode ser reutilizado através de herança e composição.
**Manutenção**: POO facilita a manutenção e atualização do código.
**Organização**: Classes e objetos permitem uma estrutura de código mais organizada.
**Escalabilidade**: Novas funcionalidades podem ser adicionadas sem afetar o código existente.

## 5. Conclusão 

POO é uma abordagem poderosa para estruturar e organizar o código, facilitando a criação de aplicações complexas. Entender e aplicar seus conceitos fundamentais é essencial para se tornar um desenvolvedor eficiente em linguagens que suportam esse paradigma.