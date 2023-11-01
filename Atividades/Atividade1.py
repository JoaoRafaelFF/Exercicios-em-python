#!/usr/bin/env python
# -*- coding: latin -*-

print 'digite sua idade em dias ou uma quantia de dias: '
EntDias = int(input())

anos = EntDias/360

meses = (EntDias/30)-((EntDias/360)*12)

dias = EntDias - ((EntDias/30)*30)

print 'quantia de dias digitado é:', EntDias,
print()
print 'resultara em uma idade"ano/meses/dias" de: ', anos, 'anos', meses, 'meses e', dias, 'dias'
