# WEX - End to End Engineering -> 1° desafio: Sistema de Estacionamento

> Projeto desenvolvido como parte do **desafio proposto na Trilha .NET – Fundamentos ** da [DIO](https://www.dio.me/).

---

## Descrição

Este projeto consiste em um **sistema de gerenciamento de estacionamento** em console, com as seguintes funcionalidades:

* Cadastrar um veículo
* Remover um veículo (calculando o valor a ser pago)
* Listar veículos estacionados

A proposta foi construída com base nos conhecimentos adquiridos no módulo de Fundamentos da trilha .NET.

---

## Estrutura da Classe `Estacionamento`

A classe principal possui:

### Propriedades

| Nome           | Tipo           | Descrição                                     |
| -------------- | -------------- | --------------------------------------------- |
| `precoInicial` | `decimal`      | Valor fixo cobrado na entrada                 |
| `precoPorHora` | `decimal`      | Valor cobrado por cada hora de permanência    |
| `veiculos`     | `List<string>` | Lista com as placas dos veículos estacionados |

### Métodos

| Nome               | Responsabilidade                                                         |
| ------------------ | ------------------------------------------------------------------------ |
| `AdicionarVeiculo` | Solicita a placa ao usuário e adiciona à lista de veículos               |
| `RemoverVeiculo`   | Solicita a placa e horas estacionadas, calcula o valor e remove da lista |
| `ListarVeiculos`   | Exibe todos os veículos cadastrados ou informa que não há nenhum         |

---

## Tecnologias Utilizadas

* .NET 8
* C#
* Console Application
* VS Code
* Git

---

## Como Executar

```bash
# Clonar o repositório
$ git clone https://github.com/luanamarques0/EstacionamentoDesafioUm.git
$ cd EstacionamentoDesafioUm

# Restaurar pacotes e compilar
$ dotnet restore
$ dotnet build

# Executar
$ dotnet run
```


