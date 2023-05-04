# Projeto_pagamento

Sistema de pagamento de uma loja virtual
Este projeto é um sistema de pagamento de uma loja virtual que permite aos clientes escolherem entre pagar em boleto, cartão de crédito ou cartão de débito. O sistema é capaz de calcular o valor a ser pago de acordo com as regras de negócio descritas abaixo.

Diagrama de Classes
As classes do programa foram desenvolvidas com base no seguinte diagrama de classes UML:

image

Funcionalidades
O programa possui as seguintes funcionalidades:

Pagamento em boleto: essa opção permite que o cliente pague em boleto bancário com desconto de 12%. O programa calcula o valor a ser pago com o desconto aplicado e exibe o código de barras do boleto juntamente com o valor a ser pago.

Pagamento em cartão de crédito: essa opção permite que o cliente pague em cartão de crédito com limite estabelecido e parcelamento máximo de 12x. Se o parcelamento for de até 6x, será acrescentado um juros de 5% no valor da compra. Já se o parcelamento for entre 7x e 12x, será acrescentado um juros de 8% no valor da compra. O programa calcula o valor a ser pago com os juros aplicados e exibe o valor final.

Pagamento em cartão de débito: essa opção permite que o cliente pague em cartão de débito com valor à vista, sem desconto. O programa verifica se o valor da compra é menor ou igual ao saldo em conta pré-definido e, caso seja, realiza o pagamento. Caso contrário, exibe uma mensagem informando que o saldo em conta é insuficiente.

Cancelar operação: essa opção permite que o cliente cancele a operação de pagamento.

Sair do sistema: essa opção permite que o cliente saia do sistema.

Como utilizar o programa
Baixe os arquivos do projeto e abra o arquivo main.py em um editor de código.
Execute o programa.
Informe o valor da compra.
Selecione uma das opções do menu:
Pagamento em boleto
Pagamento em cartão de crédito
Pagamento em cartão de débito
Cancelar operação
Sair do sistema
Siga as instruções do programa e informe os dados solicitados.
O programa irá calcular o valor a ser pago e exibir o resultado.
Considerações finais
Este projeto foi desenvolvido com base nas especificações descritas no diagrama de classes UML. Ele permite que o cliente efetue pagamentos de compras em uma loja virtual de acordo com as regras de negócio estabelecidas. O programa pode ser facilmente estendido para incluir novas funcionalidades e métodos de pagamento.


