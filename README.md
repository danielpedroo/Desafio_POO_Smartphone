# Projeto de Programação Orientada a Objetos em .NET - DIO Trilha .NET

Este projeto faz parte da trilha .NET oferecida pela DIO (Digital Innovation One) e tem como objetivo modelar um sistema que trabalha com celulares. O desafio consiste em criar uma abstração para celulares, permitindo que diferentes marcas e modelos tenham seu próprio comportamento, seguindo os princípios da programação orientada a objetos.

## Estrutura do Projeto
O sistema deve ser implementado em .NET e ter uma estrutura de classes de acordo com o diagrama fornecido.

### Classes do Projeto

#### Classe Abstrata `Smartphone`

- Deve ser abstrata, não permitindo instanciar diretamente.
- Servirá apenas como modelo para outras classes.

#### Classe `Nokia`

- Deve ser uma classe filha de `Smartphone`.
- Deve sobrescrever o método `InstalarAplicativo` para implementar a lógica específica de instalação de aplicativos para a marca Nokia.

#### Classe `Iphone`

- Deve ser uma classe filha de `Smartphone`.
- Deve sobrescrever o método `InstalarAplicativo` para implementar a lógica específica de instalação de aplicativos para a marca iPhone.

### Regras e Validações

1. A classe `Smartphone` deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. As classes `Nokia` e `Iphone` devem ser classes filhas de `Smartphone`.
3. O método `InstalarAplicativo` deve ser sobrescrito na classe `Nokia` e `Iphone`, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Implementação da Solução
O código está pela metade, e você deverá dar continuidade obedecendo às regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

O código-fonte e as instruções detalhadas podem ser encontrados [aqui]((https://github.com/digitalinnovationone/trilha-net-poo-desafio)https://github.com/digitalinnovationone/trilha-net-poo-desafio)).
