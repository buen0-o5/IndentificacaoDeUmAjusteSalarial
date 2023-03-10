# Indentificacao de um Ajuste salarial

📝 Descrição:
Programa que solicita ao usuário que informe o salário mínimo atual, e os seguintes dados de um estagiário:

- Turno de trabalho 
- Número de horas trabalhadas

Com base no turno do trabalho do funcionário, será calculado o coefiecente com acrescimo de porcentagem de acordo com o turno:
- Matutino: 1% do salário mínimo;
- Vespertino: 2% do salário mínimo;
- Noturno: 3% do salário mínimo.

Tendo o valor do coeficiente calculado, com base nele é obtido o salário
bruto do estagiário, que é o produto dele (coeficiente) e as horas trabalhadas.

Sobre o salário bruto é calculado um imposto hipotético a ser descontado,
como segue:
- Calouro: salário < 300,00 tem imposto de 1%;
- Salário >= 300,00 tem imposto de 2%;
- Veterano: salário < 400,00 tem imposto de 3%;
- Salário >= 400,00 tem imposto de 4%

Para alguns estagiários, será também pago um valor em forma de gratificação. Para os que preencherem todos os requisitos, ela será de R$ 50,00;
caso contrário, de R$ 30,00.
Os requisitos são:
- Turno: noturno;
- Número de horas trabalhadas: superior a 80.

Também é oferecido o auxílio-alimentação. Se o estagiário preencher algum dos requisitos, seu auxílio-alimentação será de um terço do seu salário
bruto; caso contrário, será de metade deste terço. Os requisitos são:
- Categoria: calouro;
- Salário bruto: menor que a metade do salário mínimo.

Uma classificação é atribuída ao salário líquido: bruto menos imposto, mais gratificação, mais auxílio-alimentação. Essa classificação seguem os requisitos a seguir:
- Menor que R$ 350,00: mal remunerado;
- Entre R$ 350,00 e R$ 600,00: normal;
- Maior que R$ 600,00: bem remunerado.

🚀 Tecnologias:

Esse projeto foi desenvolvido com as seguintes tecnologias:

- C# (Windows Forms)
