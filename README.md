Lunch Restaurant Voter
===========
User Stories

```gherkin
@requires_database
Funcionalidade: Estória 1 - Um professional só pode votar em um restaurante por dia.
    Eu como profissional faminto
    Quero votar no meu restaurante favorito
    Para que eu consiga democraticamente levar meus colegas a comer onde eu gusto.

Contexto: 
        Dados os seguintes profissionais: Bruno, Kauã, Ahmed, Maicon
        E os seguintes restaurantes: Piazza, Colegiais, Banquette

Cenário: Um professional só poderia votar em um restaurante por dia.
        Dado que o 'Ahmed' votou no restaurante 'Piazza' 'hoje'
        Então o 'Ahmed' não deveria poder votar no restaurante 'Piazza' 'hoje' novamente
        E o 'Ahmed' não deveria poder votar no restaurante 'Colegiais' 'hoje' novamente
        Mas 'Kauã, Maicon' deveriam poder votar no restaurante 'Piazza' 'hoje'
        E o 'Bruno' deveria poder votar no restaurante 'Colegiais' 'hoje'

```

```gherkin
@requires_database
Funcionalidade: Estória 2 - O mesmo restaurante não pode ser escolhido mais de uma vez durante a semana.
        Eu como facilitador do processo de votação
        Quero que um restaurante não possa ser repetido durante a semana
        Para que não precise ouvir reclamações infinitas!

Cenário: O mesmo restaurante não deve poder ser escolhido mais de uma vez durante a semana.
        Dados os seguintes profissionais: Aderopo, Paulo
        Dados os seguintes restaurantes: Pallato, Badoo, Pizza Hut, Arizona
        Dado que o 'Aderopo' votou no restaurante 'Badoo' 'ontem'
        Então os restaurantes elegíveis 'hoje' deveriam ser: Pallato, Pizza Hut, Arizona

Esquema do Cenário: O mesmo restaurante não deve poder ser escolhido mais de uma vez durante a semana(alternativa).
        Dados os seguintes profissionais: <profissionais>
        Dados os seguintes restaurantes: <restaurantes>
        Dado que o '<eleitor>' votou no restaurante '<votado>' '<data_voto_passado>'
        Então os restaurantes elegíveis '<data_consulta>' deveriam ser: <disponíveis_para_votação>

        Exemplos:
            | restaurantes                    | profissionais  | eleitor | votado   | data_voto_passado | data_consulta | disponíveis_para_votação        |
            | Big E, Plazza, Calibu, Bellview | Aderopo, Paulo | paulo   | Bellview | ontem             | hoje          | Big E, Plazza, Calibu           |
            | Big E, Plazza, Calibu, Bellview | Aderopo, Paulo | paulo   | Bellview | hoje              | hoje          | Big E, Plazza, Calibu, Bellview |
```

```gherkin
@requires_database
Funcionalidade: Estória 3 - Mostrar de alguma forma o resultado da votação.
    Eu como profissional faminto
    Quero saber antes do meio dia qual foi o restaurante escolhido
    Para que eu possa me despir de preconceitos e preparar o psicológico.

Contexto: Empate na votação
        Dados os seguintes profissionais: Bruno, Kauã, Maicon, Brian, Matheus, Tiago
        E os seguintes restaurantes: Piazza, Pinguin, Banquette, Speedy

Cenário: Caso houver empate, Os mais votados deveriam ser retornados como os escolhidos.
        Dado que o 'Matheus' votou no restaurante 'Speedy' 'hoje'
        Então o restaurante mais votado no momento deveria ser: Speedy
        Dado que 'Bruno, Kauã' votaram no restaurante 'Piazza' 'hoje'
        Então o restaurante mais votado no momento deveria ser: Piazza
        Dado que 'Maicon, Brian' votaram no restaurante 'Banquette' 'hoje'
        Então os restaurantes mais votados no momento deveriam ser: Piazza, Banquette
        Dado que o 'Tiago' votou no restaurante 'Piazza' 'hoje'
        Então os restaurantes mais votados deveriam ser: Piazza
```
