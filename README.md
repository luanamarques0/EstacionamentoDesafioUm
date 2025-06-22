# WEX – End-to-End Engineering
## 1º Desafio : Sistema de Estacionamento

Projeto desenvolvido como parte do **Desafio “Sistema de Estacionamento”** da **[DIO – Trilha .NET / Fundamentos](https://www.dio.me)**.

🔗 **Repositório original do desafio:**
[digitalinnovationone/trilha-net-fundamentos-desafio](https://github.com/digitalinnovationone/trilha-net-fundamentos-desafio)

---

## Funcionalidades

| Ação | Descrição |
|------|-----------|
| **Cadastrar veículo** | Registra a placa digitada pelo usuário. |
| **Remover veículo** | Solicita a placa, pede o nº de horas, calcula e mostra o valor devido. |
| **Listar veículos**  | Exibe todas as placas atualmente estacionadas. |

...

## Estrutura da classe `Estacionamento`

### Propriedades

| Propriedade | Tipo | Descrição |
|-------------|------|-----------|
| `precoInicial` | `decimal` | Valor fixo cobrado na entrada. |
| `precoPorHora` | `decimal` | Valor cobrado por cada hora de permanência. |
| `veiculos` | `List<string>` | Placas dos veículos estacionados. |

### Métodos

| Método | Responsabilidade |
|--------|------------------|
| `AdicionarVeiculo` | Solicita a placa e a adiciona à lista. |
| `RemoverVeiculo`   | Solicita placa + horas, calcula o valor e remove da lista. |
| `ListarVeiculos`   | Exibe todos os veículos ou informa que não há nenhum. |

---

## Tecnologias

- **.NET 8** / C#
- **Console Application**
- **VS Code** (editor)
- **Git** (controle de versão)

---

## Como executar

```bash
# 1. Clonar o repositório
git clone https://github.com/luanamarques0/EstacionamentoDesafioUm.git
cd EstacionamentoDesafioUm

# 2. Restaurar dependências e compilar
dotnet restore
dotnet build

# 3. Executar
dotnet run