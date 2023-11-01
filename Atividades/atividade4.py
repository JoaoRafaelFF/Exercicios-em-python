#!/usr/bin/env python
# -*- coding: latin -*-
def n_prime(n):
    if n < 2:
        return False
    for i in range(2, n):
        if not n % i:
            return False
    else:
        return True
for nun in range(1, 101):
    if n_prime(nun):
        print nun