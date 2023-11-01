#!/usr/bin/env python
# -*- coding: latin -*-

print 'digite tres valores:(obs: separe por enter) '
a = float(input()); b = float(input()); c = float(input())

if a > b+c:
    print 'nao forma triangulo! valores digitados: ', a, ',', b, ',', c, 'valor A:', a, ',', 'é o maior'
elif b > a+c:
    print 'nao forma triangulo! valores digitados: ', a, ',', b, ',', c, 'valor B:', b, ',', 'é o maior'
elif c > a+b:
    print 'nao forma triangulo! valores digitados: ', a, ',', b, ',', c, 'valor C:', c, ',', 'é o maior'
else:
    prt = (a+b+c)/2
    ara = prt * (prt - a) * (prt - b) * (prt - c)
    print 'area do triangulo é: ',ara

