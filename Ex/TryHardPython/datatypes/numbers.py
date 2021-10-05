from decimal import Decimal as D
# Output: Decimal('3.3')
# print(D('1.1') + D('2.2'))
 
# Output: Decimal('3.000')
# print(D('1.2') * D('2.50'))

# print(1.2 * 2.50)

import fractions as F
 
# Output: 3/2
# print(F.Fraction(3/2))
 
# Output: 5
# print(fractions.Fraction(5))
 
# Output: 1/3
# print(fractions.Fraction(1,3))

# Output: 11/10
# print(fractions.Fraction('1.1'))

import random
 
# Output: 16
print(random.randrange(10,20))
 
x = ['a', 'b', 'c', 'd', 'e']
 
# Get random choice
print(random.choice(x))
 
# Shuffle x
random.shuffle(x)
 
# Print the shuffled x
print(x)
 
# Print random element
print(random.random())