# TFLP
Trabalho final de lógica de programação

Este programa testa a satisfatibilidade de uma fórmula da lógica proposicional baseado no algoritmo DPLL.
Além de retornar uma valoração que deixa a fórmula verdadeira caso ela seja satisfatível.
Para isto deve receber a fórmula a partir de um arquivo com a seguinte padronização:

c comentario<br />
p cnf 3 2<br />
1 -3 0<br />
2 3 -1 0<br />

Em que o exemplo acima representa a fórmula (p1 | p3) & (p2 | p3 | p1).
Ou seja, o número 3 na linha que inicia com p representa a quantidade de atômicas,
e o número 2 na mesma linha indica a quantidade de cláusulas. Além disso, cada linha abaixo da linha que começa
com p representa uma cláusula da fórmula.
