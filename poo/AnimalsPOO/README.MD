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