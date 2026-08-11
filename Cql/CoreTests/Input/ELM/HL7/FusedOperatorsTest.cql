library FusedOperatorsTest version '1.0.0'

define "Numbers": { 1, 2, 3, 4, 5, 2, 3 }

define "AnyGreaterThanFour": exists ("Numbers" N where N > 4)

define "TenTimesEvens": "Numbers" N where N mod 2 = 0 return all N * 10

define "DoublesOverSix": ("Numbers" N return all N * 2) D where D > 6

define "DistinctSquares": "Numbers" N return N * N
